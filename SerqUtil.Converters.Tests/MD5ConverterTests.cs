using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerqUtil.Converters.Tests
{
    [TestClass]
    public class MD5ConverterTests
    {
        [TestMethod]
        public void ConvertToMD5()
        {
            string hash = MD5Converter.ConvertToMD5("123456");
        }
        [TestMethod]
        public void VerifyMD5Hash()
        {
            bool verified = MD5Converter.VerifyMD5Hash("123456", "e10adc3949ba59abbe56e057f20f883e");
        }
    }
}
