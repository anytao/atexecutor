using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Toolkit.AtExecutor
{
    /// <summary>
    /// A light data process framework
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <remarks>anytao / 2011/4/27</remarks>
    /// <code>https://github.com/anytao/atexecutor</code>
    public interface IDataExecutor<in TDataContext> where TDataContext : IDataContext
    {
        void Execute(TDataContext data);
    }
}
