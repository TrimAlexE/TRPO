using System;
using core;

namespace Trimailov
{
    class MyLog : LogAbstract<MyLog>, ILogInterface
    {
        public static void Log(string result)
        {
            MyLog.Instance().log.Add(result);
        }
       
        public static void Write()
        {
            MyLog.Instance()._write();
        }
        protected override void _write()
        {
            foreach (string x in log)
            {
                Console.WriteLine(x);
            }
        }
    }
}
