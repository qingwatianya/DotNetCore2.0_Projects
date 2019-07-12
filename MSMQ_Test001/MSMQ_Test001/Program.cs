using Grumpy.MessageQueue.Enum;
using Grumpy.MessageQueue.Msmq;
using System;
using System.Threading;

namespace MSMQ_Test001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //MessageQueue msgQueue = new MessageQueue(@".\private$\myQueue");

            var queueFactory = new QueueFactory(null);

            using (var queue = queueFactory.CreateLocale("test002", true, LocaleQueueMode.DurableCreate, true, AccessMode.Send))
            {
                
                // Message will be serialized to json and chumped into pieces, all pieces send in the same transaction
                queue.Send("MyMessage");

                // The receive has a timeout of 1 sec, and the message will be deserialized to the type (here string). This receive will automatically Ack the message
                var response = queue.Receive<string>(1000, new CancellationToken());
            }
        }
    }
}
