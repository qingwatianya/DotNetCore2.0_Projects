using NetCoreDbFirst.Models;
using System;
using System.Linq;

namespace NetCoreDbFirst_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tmpSuccess = false;
            Console.WriteLine("Save start!");
            using (rensanqianContext context = new rensanqianContext())
            {
                context.User2.Add(new User2 { Account = "codefirst_" + DateTime.Now.ToString("yyyyMMddHHmmssfff"), Password = "12345678" });
                tmpSuccess = context.SaveChanges() > 0;
                Console.WriteLine("新增记录{0}", tmpSuccess ? "成功" : "失败");
                string tmpData = context.User2.FirstOrDefault().Account;
                Console.WriteLine(tmpData);
            }
        }
    }
}
