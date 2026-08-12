using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Euler.Objects;

namespace Project_Euler
{
    public static class Validator
    {

        public static List<Argument> ValidateAndParseArgs(List<ArgType> argTypes, string input)
        {
            List<Argument> results = new List<Argument>();

            String[] args = input.Split(' ');
            if (argTypes.Count != args.Count())
            {
                results.Add(new Argument()
                {
                    Error = String.Format("Expected arguments ({0}) and actual arguments supplied ({1}) are different.", argTypes.Count, args.Count())
                });
            }
            else
            {
                for (int i = 0; i < argTypes.Count; i++)
                {
                    results.Add(ValidateAndParseArg(argTypes[i], args[i]));
                }
            }

            return results;
        }

        public static Argument ValidateAndParseArg(ArgType argType, string input)
        {
            Argument result = new Argument();
            int parsedInt;
            double parsedDouble;
            
            switch (argType)
            {
                case ArgType.Integer:
                    if (int.TryParse(input, out parsedInt))
                    {
                        result = new Argument()
                        {
                            Type = ArgType.Integer,
                            Value = parsedInt
                        };
                    }
                    else
                    {
                        result = new Argument()
                        {
                            Error = String.Format("Expected {0} but was {1}", argType, input)
                        };
                    }
                        
                    break;
                case ArgType.PositiveInteger:
                    if (int.TryParse(input, out parsedInt) || parsedInt <= 0)
                    {
                        result = new Argument()
                        {
                            Type = ArgType.Integer,
                            Value = parsedInt
                        };
                    }
                    else
                    {
                        result = new Argument()
                        {
                            Error = String.Format("Expected {0} but was {1}", argType, input)
                        };
                    }
                    break;
                case ArgType.Double:
                    if (double.TryParse(input, out parsedDouble))
                    {
                        result = new Argument()
                        {
                            Type = ArgType.Integer,
                            Value = parsedDouble
                        };
                    }
                    else
                    {
                        result = new Argument()
                        {
                            Error = String.Format("Expected {0} but was {1}", argType, input)
                        };
                    }
                    break;
                case ArgType.PositiveDouble:
                    if (double.TryParse(input, out parsedDouble) || parsedDouble <= 0)
                    {
                        result = new Argument()
                        {
                            Type = ArgType.Integer,
                            Value = parsedDouble
                        };
                    }
                    else
                    {
                        result = new Argument()
                        {
                            Error = String.Format("Expected {0} but was {1}", argType, input)
                        };
                    }
                    break;

                case ArgType.String:
                    if (!String.IsNullOrWhiteSpace(input))
                    {
                        result = new Argument()
                        {
                            Type = ArgType.String,
                            Value = input
                        };
                    }
                    else
                    {
                        result = new Argument()
                        {
                            Error = String.Format("Expected {0} but was {1}", argType, input)
                        };
                    }
                    break;
                default:
                    result = new Argument()
                    {
                        Error = String.Format("Validator not implemented for {0}", argType)
                    };
                    break;

            }

            return result;
        }

    }
}
