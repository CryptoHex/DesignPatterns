using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class HotBeverage
    {
        private string hotBeverageType;
        private string boiledLiquid;
        private string cupSize;
        private List<string> ingridients;

        public string HotBeverageType { get => hotBeverageType; set => hotBeverageType = value; }
        public string BoiledLiquid { get => boiledLiquid; set => boiledLiquid = value; }
        public string CupSize { get => cupSize; set => cupSize = value; }
        public List<string> Ingridients { get => ingridients; set => ingridients = value; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"=== HotBeverage type: {this.HotBeverageType} ===");
            sb.AppendLine($"The main liquid is {this.BoiledLiquid.ToLower()}.");
            sb.AppendLine("    -Ingridients:");
            foreach(var ingridient in this.Ingridients)
            {
                sb.AppendLine($"    ---{ingridient}");
            }
            sb.AppendLine($"    -Cup size: {this.CupSize}.");
            return sb.ToString();
        }
    }
}
