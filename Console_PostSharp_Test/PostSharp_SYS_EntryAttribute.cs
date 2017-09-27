using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_PostSharp_Test
{
   
    [Serializable]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    public sealed class PostSharp_SYS_EntryAttribute : OnMethodBoundaryAspect
    {
        public string BusinessName { get; set; }


        public override void OnEntry(MethodExecutionArgs eventArgs)
        {
            string tmpStr = string.Format("函数{0}开始执行->执行时间：{1}",eventArgs.Method.Name, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff"));
            Console.WriteLine(tmpStr);
        }

        public override void OnExit(MethodExecutionArgs eventArgs)
        {
            string tmpStr = string.Format("函数{0}执行结束->执行时间：{1}", eventArgs.Method.Name, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff"));
            Console.WriteLine(tmpStr);

            
            if (eventArgs.ReturnValue!=null)
            {
                tmpStr = string.Format("函数{0}执行结束->返回结果：{1}", eventArgs.Method.Name, eventArgs.ReturnValue);
                Console.WriteLine(tmpStr);
            }
            else
            {
                tmpStr = string.Format("函数{0}执行结束->返回结果：无结果返回", eventArgs.Method.Name);
                Console.WriteLine(tmpStr);
            }
        }

        public override void OnSuccess(MethodExecutionArgs eventArgs)
        {
            string tmpStr = string.Format("函数{0}执行成功->执行成功：{1}", eventArgs.Method.Name, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff"));
            Console.WriteLine(tmpStr);
        }

        public override void OnException(MethodExecutionArgs eventArgs)
        {
            string tmpStr = string.Format("函数{0}执行异常->异常内容：{1}", eventArgs.Method.Name, eventArgs.Exception.ToString());
            Console.WriteLine(tmpStr);         
        }
        public override void OnYield(MethodExecutionArgs eventArgs)
        {
            Console.WriteLine(BusinessName + "OnYield：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff"));
        }

    }
}
