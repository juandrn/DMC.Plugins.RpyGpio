using DMC.Invokers;
using NetXP.NetStandard.DependencyInjection;
using rnet.lib;
using rnet.lib.Implementations.Live;
using System;
using System.Collections.Generic;
using System.IO;
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

            r.Register<IInitializer, Initializer>(DILifeTime.Singleton);
        }

        public void ForLinux(IRegister r)
        {
            ForAll(r);
            r.Register<IGPIO, Implementations.GPIOInvokerNotImplemented>(DILifeTime.Singleton);
        }

        public void ForRaspberry(IRegister r)
        {
            ForAll(r);
            r.Register<IGPIO, Implementations.RaspberryRNetInvoker>(DILifeTime.Singleton);
        }

        public void ForWindows(IRegister r)
        {
            ForAll(r);
            r.Register<IGPIO, Implementations.GPIOInvokerNotImplemented>(DILifeTime.Singleton);
        }
    }
}
