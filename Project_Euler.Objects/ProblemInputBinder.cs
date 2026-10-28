using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Project_Euler.Objects
{
  public static class ProblemInputBinder
  {
    public static TInput Bind<TInput>(string input)
      where TInput : notnull
    {
      ArgumentNullException.ThrowIfNull(input);

      var values = Tokenize(input);
      var constructors = typeof(TInput).GetConstructors(
        BindingFlags.Public | BindingFlags.Instance);

      if (constructors.Length != 1)
      {
        throw new InvalidOperationException(
          $"Input type '{typeof(TInput).Name}' must have exactly one public constructor.");
      }

      var constructor = constructors[0];
      var parameters = constructor.GetParameters();

      var hasOptionalDebug =
        parameters.Length > 0 &&
        string.Equals(parameters[^1].Name, "Debug", StringComparison.Ordinal) &&
        parameters[^1].ParameterType == typeof(bool) &&
        parameters[^1].IsOptional &&
        parameters[^1].HasDefaultValue &&
        Equals(parameters[^1].DefaultValue, false);

      var requiredParameterCount = parameters.Length - (hasOptionalDebug ? 1 : 0);

      if (values.Count != requiredParameterCount &&
          !(hasOptionalDebug && values.Count == parameters.Length))
      {
        // Keep the existing input-shape error handling, updated to mention
        // the two accepted counts when Debug is optional.
        throw new FormatException(
          $"Expected {requiredParameterCount} value(s): {string.Join(" ", parameters.Select(parameter =>
            $"<{parameter.ParameterType.Name} {parameter.Name}>"))}. " +
          $"Received {values.Count}. Enclose values containing spaces in double quotes.");
      }

      var convertedValues = new object?[parameters.Length];

      for (var i = 0; i < parameters.Length; i++)
      {
        var parameter = parameters[i];

        if (hasOptionalDebug && i == parameters.Length - 1)
        {
          if (values.Count == requiredParameterCount)
          {
            convertedValues[i] = parameter.DefaultValue;
          }
          else
          {
            convertedValues[i] = values[i] switch
            {
              "0" => false,
              "1" => true,
              _ => throw new FormatException("Debug must be 0 or 1.")
            };
          }

          continue;
        }

        var destinationType =
          Nullable.GetUnderlyingType(parameter.ParameterType) ?? parameter.ParameterType;

        try
        {
          var converter = TypeDescriptor.GetConverter(destinationType);
          if (!converter.CanConvertFrom(typeof(string)))
          {
            throw new NotSupportedException(
              $"Type '{destinationType.Name}' cannot be converted from console text.");
          }

          var convertedValue = converter.ConvertFrom(
            context: null,
            culture: CultureInfo.InvariantCulture,
            value: values[i]);

          if (convertedValue is null &&
              parameter.ParameterType.IsValueType &&
              Nullable.GetUnderlyingType(parameter.ParameterType) is null)
          {
            throw new FormatException("The converted value was null.");
          }

          convertedValues[i] = convertedValue;
        }
        catch (Exception exception) when (
          exception is FormatException or
          NotSupportedException or
          ArgumentException or
          OverflowException)
        {
          var parameterName = parameter.Name ?? $"#{i + 1}";
          throw new FormatException(
            $"Could not convert input value {i + 1} ('{values[i]}') " +
            $"to {parameter.ParameterType.Name} for '{parameterName}'.",
            exception);
        }
      }

      var result = (TInput)constructor.Invoke(convertedValues);

      Validator.ValidateObject(
        result,
        new ValidationContext(result),
        validateAllProperties: true);

      return result;
    }

    private static List<string> Tokenize(string input)
    {
      var values = new List<string>();
      var token = new StringBuilder();
      var inQuotes = false;
      var afterQuotedValue = false;
      var tokenStarted = false;

      foreach (var character in input)
      {
        if (inQuotes)
        {
          if (character == '"')
          {
            inQuotes = false;
            afterQuotedValue = true;
          }
          else
          {
            token.Append(character);
          }

          continue;
        }

        if (afterQuotedValue)
        {
          if (!char.IsWhiteSpace(character))
          {
            throw new FormatException(
              "A quoted input value must be followed by whitespace or the end of the line.");
          }

          values.Add(token.ToString());
          token.Clear();
          tokenStarted = false;
          afterQuotedValue = false;
          continue;
        }

        if (char.IsWhiteSpace(character))
        {
          if (tokenStarted)
          {
            values.Add(token.ToString());
            token.Clear();
            tokenStarted = false;
          }
          continue;
        }

        if (character == '"')
        {
          if (tokenStarted)
          {
            throw new FormatException(
              "Double quotes must enclose an entire input value.");
          }

          inQuotes = true;
          tokenStarted = true;
          continue;
        }

        token.Append(character);
        tokenStarted = true;
      }

      if (inQuotes)
      {
        throw new FormatException("An input value has an unmatched double quote.");
      }

      if (afterQuotedValue || tokenStarted)
      {
        values.Add(token.ToString());
      }

      return values;
    }
  }
}

