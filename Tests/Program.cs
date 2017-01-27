using System.IO;
using TESL;

namespace Tests
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Engine.Run(File.Open("test0.tesl.lisp",FileMode.Open,FileAccess.Read));
        }
    }
}