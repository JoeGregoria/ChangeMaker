using System;

namespace src
{
    public class ChangeMaker
    {
        public Change MakeChange(decimal money)
        {
            if (money >= 1) throw new Exception("only want the change bits");

            int changeLeft = (int)(money * 100);
            var change = new Change();

            while ((changeLeft != 0) && (changeLeft % 5 == 0))
            {
                change.NicklesCount++;
                changeLeft=changeLeft-5;
            }

            change.PenniesCount = changeLeft;
            return change;
        }
    }
}
