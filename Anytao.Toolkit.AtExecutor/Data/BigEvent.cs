using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Toolkit.AtExecutor.Data
{
    public sealed class BigEvent : DataContextBase, IDataContext
    {
        public override DataType Type
        {
            get { return DataType.BigEvent; }
        }
    }
}
