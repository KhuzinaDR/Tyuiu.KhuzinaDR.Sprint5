using System.IO;
using Tyuiu.KhuzinaDR.Sprint5.Task1.V25.Lib;
namespace Tyuiu.KhuzinaDR.Sprint5.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            string path = @"C:\Users\Ïîëüçîâàòåëü\AppData\Local\Temp\OutPutFileTask1.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}