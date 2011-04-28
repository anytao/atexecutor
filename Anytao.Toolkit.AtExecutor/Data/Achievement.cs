using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Toolkit.AtExecutor.Data
{
    public sealed class Achievement : DataContextBase, IDataContext
    {
        public string Title { get; set; }

        public string Desc { get; set; }

        public override DataType Type
        {
            get { return DataType.Achievement; }
        }
    }
}
