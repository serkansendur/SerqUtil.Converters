using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerqUtil.Converters
{
    public class Base64Converter
    {
        public static string ConvertToBase64(string text, EncodingInfo encoding)
        {
            return Convert.ToBase64String(encoding.GetEncoding().GetBytes(text));
        }

        public static string ConvertFromBase64(string text, EncodingInfo encoding)
        {
            return encoding.GetEncoding().GetString(Convert.FromBase64String(text));
        }

    }
}
