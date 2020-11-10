using DMC.Invokers;
using NetXP.NetStandard.DependencyInjection;
using rnet.lib;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DMC.Plugins.RpyGpio
{
    public class Initializer : IInitializer
    {
        private readonly IPyProcess pyProcess;

        public Initializer(IPyProcess pyProcess)
        {
            this.pyProcess = pyProcess;
        }

        public void Init()
        {
            pyProcess.Start();
        }
    }
}
