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
        public void ForAll(IRegister r)
        {
            var rpyProcess = new LiveProcess("../plugins/rpy/rwy/rwy.py");
            r.RegisterInstance<IPyProcess>(rpyProcess, DILifeTime.Singleton);
        }

        public void ForLinux(IRegister r)
        {
            r.Register<IGPIOBusiness, Implementations.GPIOInvokerNotImplemented>();
            ForAll(r);
        }

        public void ForRaspberry(IRegister r)
        {
            r.Register<IGPIOBusiness, Implementations.RaspberryRNetInvoker>();
            ForAll(r);
        }

        public void ForWindows(IRegister r)
        {
            r.Register<IGPIOBusiness, Implementations.GPIOInvokerNotImplemented>();
            ForAll(r);
        }
    }
}
