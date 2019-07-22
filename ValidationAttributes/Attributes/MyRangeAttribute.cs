using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.Attributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private readonly int minValue;
        private readonly int maxValue;

        public MyRangeAttribute(int minValud, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public override bool IsValid(object ob)
        {
            int value = Convert.ToInt32(ob);

            if (value < this.minValue || value > this.maxValue)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
