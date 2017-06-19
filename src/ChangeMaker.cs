using System;

namespace src
{
    public class ChangeMaker
    {
        public Change MakeChange(decimal money)
        {
            decimal moneyLeft = money;
            var change = new Change();
            change.PenniesCount = (int) moneyLeft;
            return change;
        }
    }
}
