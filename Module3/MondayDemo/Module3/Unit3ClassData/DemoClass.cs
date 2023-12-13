using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit3ClassData
{
    internal class DemoClass
    {
        // traditional fields with getter/setter methods
        private string traditionalField;

        public string GetTraditionalField() { return traditionalField; }
        public void SetTraditionalField(string traditionalField)
        {
            this.traditionalField = traditionalField;
        }

        // property
        private string propertyField;

        public string PropertyField
        {
            get { return propertyField; }
            set { propertyField = value; }
        }

        public string AutoProperty { get; set; }
    }
}
