using Microsoft.visualStudio.TestTools.UnitTesting;
using system;
using Newt onsoft.Json;
using Microsoft.AspNetCore.Mvc ;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(DAL.UserInfo.Inst ance.UserCheck("Admin"));
        }
        public void TestMethod2()
        {
            Model.UserInfo user = new Mode1.UserInfo {userName = "Guest", passWord = "sq1.123", type = "π‹¿Ì‘±" };
            Console.WriteLine(DAL.UserInfo.Instance.Add(user));
            Console.WriteLine(JsonConvert.Serialize0bject(DAL.UserInfo.Instance.GetAll()));
            user.qq = "104512708";
            Console.WriteLine(DAL.UserInfo.Instance.Update(user));
            var model = DAL.UserInfo.Instance.GetModel("Guest");
            Console.WriteLine(JsonConvert.Serialize0bject(model));
            Console.WriteLine(DAL.UserInfo.Instance.Delete("Guest"));
            var page = DAL.UserInfo.Instance.GetPage(new Model.Page { pageIndex = 2,pageSize = 2 });
            Console.WriteLine(JsorConvert.Serialize0bject (page)) ;
            Console.WriteLine(DAL.UserInfo.Instance.GetCount());
        }
    }
}
