using Grumpy.MessageQueue.Enum;
using Grumpy.MessageQueue.Msmq;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MSMQ_Test002
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageQueue tmpMsmq = new MessageQueue(@".\private$\test001");
            tmpMsmq.Formatter= new XmlMessageFormatter(new Type[] { typeof(string) });
            Task.Run(() =>
            {
                Console.WriteLine("开启线程1发送消息队列：");
                int i = 0;
                while (i++ < 100000) //10秒钟左右能完成
                {                    
                    string tmpStr = string.Format("{0} 生产消息:{1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), i);
                    Console.WriteLine(tmpStr);
                    tmpMsmq.Send(string.Format("{0}", i));
                    //Thread.Sleep(1000);
                }
            });

            Task.Run(() =>
            {
                Console.WriteLine("开启线程2接收消息队列：");
                while (true)
                {
                    //var ddd = tmpMsmq.BeginPeek();
                    //var tmpMsg = tmpMsmq.EndPeek(ddd); //消息无限读取 但是不会消失

                    //var ddd = tmpMsmq.BeginReceive();
                    //var tmpMsg = tmpMsmq.EndReceive(ddd); //无超时等待 直到接收到消息 正常消费

                    var tmpMsg = tmpMsmq.Receive(); //20秒钟可以消费10万条消息
                    Console.WriteLine(string.Format("{0} 消费消息:{1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), tmpMsg.Body.ToString()));
                    Console.WriteLine();
                }
            });

            Console.ReadLine();

            //var queueFactory = new QueueFactory();

            //using (var queue = queueFactory.CreateLocale("test001", true, LocaleQueueMode.DurableCreate, true, AccessMode.Send))
            //{
            //    // Message will be serialized to json and chumped into pieces, all pieces send in the same transaction
            //    queue.Send("MyMessage");

            //    // The receive has a timeout of 1 sec, and the message will be deserialized to the type (here string). This receive will automatically Ack the message
            //    var response = queue.Receive<string>(1000, new CancellationToken());
            //}
        }
    }
}
