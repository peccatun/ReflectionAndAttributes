using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Utilities
{
    public static class Validator
    {
        public static bool IsValid(object ob)
        {
            PropertyInfo[] propertyInfos = ob
                .GetType()
                .GetProperties();

            foreach (var property in propertyInfos)
            {
                MyValidationAttribute[] attributes = property
                    .GetCustomAttributes()
                    .Where(a => a is MyValidationAttribute)
                    .Cast<MyValidationAttribute>()
                    .ToArray();

                foreach (MyValidationAttribute attribute in attributes)
                {
                    if (!attribute.IsValid(property.GetValue(ob)))
                    {
                        return false;
                    }
                }

            }
            return true;
        }
    }
}
