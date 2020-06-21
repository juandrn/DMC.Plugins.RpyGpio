using DMC.Invokers;
using NetXP.NetStandard.DependencyInjection;
using rnet.lib;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DMC.RpyGpio.Plugin
{
    public class Initializer : IInitializer
    {
        public void Init(IContainer container)
        {
            var pyProcess = container.Resolve<IPyProcess>();
            pyProcess.Start();

        }
    }
}
