using System.Collections.Generic;
using System.Text;

namespace src
{
    public class Change
    {
        public int PenniesCount {set; get;}
        public int NickelsCount { get; set; }
        public int DimesCount {get; set;}
        public int QuartersCount {get; set;}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{QuartersCount} Quarters");
            sb.AppendLine($"{DimesCount} Dimes");
            sb.AppendLine($"{NickelsCount} Nickles");
            sb.AppendLine($"{PenniesCount} Pennies");
            return sb.ToString();
        }
    }
}