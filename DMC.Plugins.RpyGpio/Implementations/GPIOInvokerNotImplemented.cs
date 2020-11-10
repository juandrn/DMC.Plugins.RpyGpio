using System;
using System.Collections.Generic;
using System.Text;
using DMC.Invokers.Domains;
using System.Linq;
using DMC.Invokers.Exceptions;
using System.IO;
using System.Text.RegularExpressions;

namespace DMC.Plugins.RpyGpio.Implementations
{
    public class GPIOInvokerNotImplemented : IGPIO
    {
        public string Analog(AnalogGPIOBDM gpio)
        {
            throw new NotImplementedException("Not Implemented.");
        }

        public string Digitial(DigitalGPIOBDM gpio)
        {
            throw new NotImplementedException("Not Implemented.");
        }

        public void Dispose()
        {
            Console.WriteLine("Disposing");
        }
    }
}
