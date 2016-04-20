using System.ComponentModel;

namespace AcuCafe.Constants
{
    public class Enumerations
    {
        public enum DrinkType
        {
            [Description("Expresso")] 
            Expresso,
            [Description("IceTea")]
            IceTea,
            [Description("HotTea")]
            HotTea,
        }
    }
}
