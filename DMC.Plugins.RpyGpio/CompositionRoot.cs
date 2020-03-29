using DMC.Invokers;
using NetXP.NetStandard.DependencyInjection;
using rnet.lib;
using rnet.lib.Implementations.Live;
using System;
using System.Collections.Generic;
using System.Text;

namespace DMC.Plugins.RpyGpio
{
    public class CompositionRoot : DMC.Invokers.ICompositionRoot
    {
        public PluginContext PluginContext { get; set; }

        public void ForAll(IRegister r)
        {

            var rpyProcess = new LiveProcess($"{PluginContext.Dir}/rwy/rwy.py");
            r.RegisterInstance<IPyProcess>(rpyProcess, DILifeTime.Singleton);
        }

        public void ForLinux(IRegister r)
        {
            ForAll(r);
            r.Register<IGPIOBusiness, Implementations.GPIOInvokerNotImplemented>();
        }

        public void ForRaspberry(IRegister r)
        {
            ForAll(r);
            r.Register<IGPIOBusiness, Implementations.RaspberryRNetInvoker>();
        }

        public void ForWindows(IRegister r)
        {
            ForAll(r);
            r.Register<IGPIOBusiness, Implementations.GPIOInvokerNotImplemented>();
        }
    }
}
