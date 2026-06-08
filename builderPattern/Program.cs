using builderPattern.Builders;
using builderPattern.Directors;
using System;

namespace builderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerBuilder builder = new ComputerBuilder();
            ComputerDirector director = new ComputerDirector();

            var gamingPC = director.BuildGamingPC(builder);

            Console.WriteLine("Gaming PC:");
            Console.WriteLine(gamingPC);
        }
    }
}