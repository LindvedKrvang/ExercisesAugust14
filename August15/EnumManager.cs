using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace August15
{
    class EnumManager
    {
        public class DisplayText : Attribute {
            public string text { get; set; }

            public DisplayText(string text) {
                this.text = text;
            }
        }
    }

    public static class DescriptionOfEnums {
        public static string ToDescription(this Enum en) {
            Type type = en.GetType();

            MemberInfo[] memInfo = type.GetMember(en.ToString());

            if (memInfo != null && memInfo.Length > 0) {
                object[] attrs = (object[])memInfo[0].GetCustomAttributes(typeof(EnumManager.DisplayText), false);
                if (attrs != null && attrs.Length > 0) {
                    return ((EnumManager.DisplayText)attrs[0]).text;
                }
            }
            return en.ToString();
        }
    }
}
