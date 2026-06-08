using builderPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace builderPattern.Builders
{
    public class ComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void SetCPU(string cpu)
        {
            _computer.CPU = cpu;
        }

        public void SetRAM(string ram)
        {
            _computer.RAM = ram;
        }

        public void SetStorage(string storage)
        {
            _computer.Storage = storage;
        }

        public void SetGPU(string gpu)
        {
            _computer.GPU = gpu;
        }

        public Computer GetComputer()
        {
            return _computer;
        }
    }
}
