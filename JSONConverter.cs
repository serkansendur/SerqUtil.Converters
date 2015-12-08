using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerqUtil.Converters
{
    public class JSONConverter
    {
        public static dynamic ConvertFromJSON(string json)
        {
           return JsonConvert.DeserializeObject<dynamic>(json);
        }
    }
}
