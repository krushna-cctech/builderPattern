using builderPattern.Builders;
using builderPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace builderPattern.Directors
{
    public class ComputerDirector
    {
        public Computer BuildGamingPC(IComputerBuilder builder)
        {
            builder.SetCPU("Intel i9");
            builder.SetRAM("32GB");
            builder.SetStorage("1TB SSD");
            builder.SetGPU("RTX 4080");

            return builder.GetComputer();
        }

        public Computer BuildOfficePC(IComputerBuilder builder)
        {
            builder.SetCPU("Intel i5");
            builder.SetRAM("16GB");
            builder.SetStorage("512GB SSD");
            builder.SetGPU("Integrated Graphics");

            return builder.GetComputer();
        }
    }
}
