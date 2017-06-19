using System.Collections.Generic;
using System.Text;

namespace src
{
    public class Change
    {
        public int PenniesCount {set; get;}
        public int NicklesCount { get; set; }
        public int DimesCount {get; set;}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{DimesCount} Dimes");
            sb.AppendLine($"{NicklesCount} Nickles");
            sb.AppendLine($"{PenniesCount} Pennies");
            return sb.ToString();
        }
    }
}