using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Linq;

namespace SerqUtil.Converters.Tests
{
    [TestClass]
    public class Base64ConverterTests
    {
        [TestMethod]
        public void ConvertToBase64()
        {
           EncodingInfo encoding =  Encoding.GetEncodings().Where(e=>e.Name== "utf-8").First();
           string text =  Base64Converter.ConvertToBase64("Serq Frus", encoding);
        }

        [TestMethod]
        public void ConvertFromBase64()
        {
            EncodingInfo encoding = Encoding.GetEncodings().Where(e => e.Name == "utf-8").First();
            string text = Base64Converter.ConvertFromBase64("U2VycSBGcnVz", encoding);
        }
    }
}
