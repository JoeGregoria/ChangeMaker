using System;

namespace src
{
    public class ChangeMaker
    {
        public Change MakeChange(double money)
        {
            var change = new Change();
            change.PenniesCount = 1;
            return change;
        }
    }
}
