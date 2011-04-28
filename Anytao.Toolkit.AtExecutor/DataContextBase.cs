using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Toolkit.AtExecutor
{
    /// <summary>
    /// DataContext base
    /// </summary>
    /// <remarks>anytao / 2011/4/27</remarks>
    /// <code>https://github.com/anytao/atexecutor</code>
    public abstract class DataContextBase : IDataContext
    {
        #region IExecuteData Members

        public int Id { get; set; }

        public string Name { get; set; }

        public string Executor { get; set; }

        public abstract DataType Type { get; }

        public long MemberId { get; set; }

        #endregion
    }
}
