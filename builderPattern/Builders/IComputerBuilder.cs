using builderPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace builderPattern.Builders
{
    public interface IComputerBuilder
    {
        void SetCPU(string cpu);
        void SetRAM(string ram);
        void SetStorage(string storage);
        void SetGPU(string gpu);

        Computer GetComputer();
    }
}
