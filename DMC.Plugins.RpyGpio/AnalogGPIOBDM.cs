using DMC.Invokers.Attributes;

namespace DMC.Plugins.RpyGpio
{
    public class AnalogGPIOBDM
    {
        [InvokerProperty(Id = "p", Name = "p", Regex = "^(12|13|18|19)$", Help = "Available gpios 12,13,18 and 19.")]
        public uint Pin { get; set; }

        [InvokerProperty(Id = "v", Name = "v", MinLength = 0, MaxLength = 1024, Help = "Range from 0 to 1024")]
        public int Value { get; set; }
    }
}