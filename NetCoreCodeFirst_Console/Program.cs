using System;
using System.Linq;

namespace NetCoreCodeFirst_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tmpSuccess = false;
            Console.WriteLine("Save start!");
            using (TestDBContext context = new TestDBContext())
            {
                context.User2.Add(new NetCoreCodeFirst.User2 { Account = "codefirst_" + DateTime.Now.ToString("yyyyMMddHHmmssfff"), Password = "123456" });
               tmpSuccess= context.SaveChanges()>0;
                Console.WriteLine("新增记录{0}", tmpSuccess ? "成功" : "失败");
                string tmpData = context.User2.FirstOrDefault().Account;
                Console.WriteLine(tmpData); 
            }


            Console.ReadKey();
        }
    }
}
