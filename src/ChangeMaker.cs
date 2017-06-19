using System;

namespace src
{
    public class ChangeMaker
    {
        public Change MakeChange(decimal money)
        {
            if (money >= 1) throw new Exception("only want the change bits");
            if (money < 0) throw new Exception("no negatives allowed");

            int changeLeft = (int)(money * 100);
            var change = new Change();
            
            changeLeft = ProcessQuarters(changeLeft, change);

            changeLeft = ProcessDimes(changeLeft, change);

            changeLeft = ProcessNickels(changeLeft, change);

            change.PenniesCount = changeLeft;
            return change;
        }



        private int ProcessQuarters(int amount, Change change)
        {
            change.QuartersCount = GetNumberOfCoins(25, amount, out int remainingValue);
            return remainingValue;
        }

        private int ProcessDimes(int amount, Change change)
        {
            change.DimesCount = GetNumberOfCoins(10, amount, out int remainingValue);
            return remainingValue;
        }

        private int ProcessNickels(int amount, Change change)
        {
            change.NickelsCount = GetNumberOfCoins(5, amount, out int remainingValue);
            return remainingValue;
        }

        private int GetNumberOfCoins(int coinValue, int amount, out int remainingValue)
        {
            int coinCount = 0;
            int leftToProcess = amount;

            while ((leftToProcess >= coinValue))
            {
                coinCount++;
                leftToProcess=leftToProcess-coinValue;
            }

            remainingValue = leftToProcess;
            return coinCount;
        }
    }
}
