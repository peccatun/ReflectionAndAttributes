﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.Attributes
{
    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object ob)
        {
            if (ob == null)
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
