using System;
using System.Threading;

namespace getProcessMyPc
{
    class Program
    { 
        static void Main(string[] args)
        {
            sync syncObj = new sync();
            Thread[] threads = new Thread[1000];
            for(int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(syncObj.add));
            }
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Start(22);
            }
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }

            // for(int i = 0; i < 1000; i++){
            //     ThreadPool.QueueUserWorkItem(syncObj.add, 12);
            // }
            
            Console.WriteLine(syncObj.count());
            
            Console.ReadKey();
        }
    }
}
