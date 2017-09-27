using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Constraints;


namespace Console_PostSharp_Test
{

    
    class Program
    {
       
        static void Main(string[] args)
        {
            ShowName();           
        }

      //[PostSharp_SYS_EntryAttribute(BusinessName = "")]
      
        public static string ShowName()
        {
            Console.WriteLine("函数主要输出内容在这儿函数主要输出内容在这儿函数主要输出内容在这儿函数主要输出内容在这儿");
            return "这是返回结果";            
        }
    }
    
   

}
