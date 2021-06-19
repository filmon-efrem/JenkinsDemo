using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Jenkins.Demo;

namespace JenkinsDemo.UnitTests
{
    [TestClass]
    public class TestProgram
    {
        [TestMethod]
        public void MainWrites_HelloWorld_ToConsole()
        {
            string Expected = "Hello World!";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.Main();
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
