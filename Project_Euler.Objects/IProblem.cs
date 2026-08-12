using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Objects
{
    public interface IProblem
    {
        List<ArgType> GetArgTypes();
        List<string> Solve(List<Argument> args);
    }
}
