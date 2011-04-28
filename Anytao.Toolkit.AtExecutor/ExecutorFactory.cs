using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DS.SH.Common;
using Anytao.Toolkit.AtExecutor.Executor;

namespace Anytao.Toolkit.AtExecutor
{
    /// <summary>
    /// Executor factory to build specific executor by context's config
    /// </summary>
    /// <typeparam name="TDataContext"></typeparam>
    /// <remarks>anytao / 2011/4/27</remarks>
    /// <code>https://github.com/anytao/atexecutor</code>
    public class ExecutorFactory<TDataContext> where TDataContext : IDataContext
    {
        //todo:{WT}, to replace dictionary with caching
        public static IDictionary<string, IDataExecutor<TDataContext>> dic = new Dictionary<string, IDataExecutor<TDataContext>>();

        static ExecutorFactory()
        {
            dic.Add("Anytao.Executor.WinnerAchieveExecutor", (new WinnerAchieveExecutor()) as IDataExecutor<TDataContext>);
            dic.Add("Anytao.Executor.MillionRichAchieveExecutor", (new MillionRichAchieveExecutor()) as IDataExecutor<TDataContext>);
        }

        public static IDataExecutor<TDataContext> Build(string executor)
        {
            return dic[executor];
        }
    }
}
