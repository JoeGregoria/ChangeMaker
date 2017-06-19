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
            
            while ((changeLeft >= 10))
            {
                change.DimesCount++;
                changeLeft=changeLeft-10;
            }

            while (changeLeft >= 5)
            {
                change.NicklesCount++;
                changeLeft=changeLeft-5;
            }

            change.PenniesCount = changeLeft;
            return change;
        }
    }
}
