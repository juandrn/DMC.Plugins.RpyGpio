using DMC.Invokers.Attributes;

namespace DMC.Plugins.RpyGpio
{
    public class DigitalGPIOBDM
    {
        [InvokerProperty(Id = "p", Name = "p", MaxLength = 50, MinLength = 0)]
        public uint Pin { get; set; }

        [InvokerProperty(Id = "v", Name = "v", MaxLength = 1, MinLength = 0)]
        public bool Value { get; set; }

    }
}