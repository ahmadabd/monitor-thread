using System;
using System.Threading;
using System.Collections.Generic;

namespace getProcessMyPc
{
    class sync
    {
        List<object> listOfNum = new List<object>();
        object lck = new object();
        public void add(object number)
        {
            try
            {
                Monitor.Enter(lck) ;
                if (!listOfNum.Contains(number))
                {
                    listOfNum.Add(number);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception");
            }
            finally
            {
                Monitor.Exit(lck);
            }
        }
        public int count()
        {
            return listOfNum.Count;
        }
    }
}
