using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS.SH.Common
{
    public class Factory<T>
    {
        public static T Resolve(string type)
        {
            return (T)Activator.CreateInstance(typeof(Type));
        }
    }
}
