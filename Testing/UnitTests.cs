using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using SimpleShopBasket;

namespace Testing
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void DoRun()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(string.Format("ABCD", Environment.NewLine)))
                {
                    Console.SetIn(sr);

                    Program.Main(new string[] { });

                    string expected = string.Format("39,425{0}", Environment.NewLine);
                    Assert.AreEqual<string>(expected, sw.ToString());
                }
            }
        }

        [TestMethod]
        public void DoRun2()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(string.Format("ABC", Environment.NewLine)))
                {
                    Console.SetIn(sr);

                    Program.Main(new string[] { });

                    string expected = string.Format("36{0}", Environment.NewLine);
                    Assert.AreEqual<string>(expected, sw.ToString());
                }
            }
        }

        [TestMethod]
        public void DoRun3()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(string.Format("AAAA", Environment.NewLine)))
                {
                    Console.SetIn(sr);

                    Program.Main(new string[] { });

                    string expected = string.Format("36{0}", Environment.NewLine);
                    Assert.AreEqual<string>(expected, sw.ToString());
                }
            }
        }
    }
}
