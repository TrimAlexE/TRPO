using System.Collections.Generic;

namespace core
{
    abstract class LogAbstract<T>
        where T : LogAbstract<T>, new()
    {
        protected static T i = new T();

        public static T Instance()
        {
            return i;
        }

        protected List<string> log = new List<string>();

        abstract protected void _write();
    }
}
