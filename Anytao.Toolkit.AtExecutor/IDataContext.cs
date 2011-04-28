using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Toolkit.AtExecutor
{
    /// <summary>
    /// Executor data context abstraction
    /// </summary>
    /// <remarks>anytao / 2011/4/27</remarks>
    /// <code>https://github.com/anytao/atexecutor</code>
    public interface IDataContext
    {
        int Id { get; }
        string Name { get; }
        string Executor { get; }

        DataType Type { get; }

        long MemberId { get; set; }
    }
}
