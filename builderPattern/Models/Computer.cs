using System;
using System.Collections.Generic;
using System.Text;

namespace builderPattern.Models
{
    public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string GPU { get; set; }

        public override string ToString()
        {
            return $"CPU: {CPU}, RAM: {RAM}, Storage: {Storage}, GPU: {GPU}";
        }
    }
}
