using System.Collections.Generic;
using System.Text;

namespace src
{
    public class Change
    {
        public int PenniesCount {set; get;}
        public int NicklesCount { get; set; }

        public Change()
        {
            PenniesCount = 0;
            NicklesCount = 0;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{NicklesCount} Nickles");
            sb.AppendLine($"{PenniesCount} Pennies");
            return sb.ToString();
        }
    }
}