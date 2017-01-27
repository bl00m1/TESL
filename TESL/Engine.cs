using System;
using System.IO;
using System.Linq;

namespace TESL
{
    public class Engine
    {
        public static void Run(Stream reader)
        {
            var v = reader.SplitByTokens('(', ')')
                .Select(s=>s.Replace('\n',' '))
                .Select(SExpression.SExpression.Parse)
                .ToArray();
            Console.WriteLine();

        }
    }
}