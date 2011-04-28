using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Toolkit.AtExecutor
{
    /// <summary>
    /// Executor's base
    /// </summary>
    /// <typeparam name="TDataContext"></typeparam>
    /// <remarks>anytao / 2011/4/27</remarks>
    /// <code>https://github.com/anytao/atexecutor</code>
    public abstract class DataExecutorBase<TDataContext> : IDataExecutor<TDataContext> where TDataContext : IDataContext
    {
        #region IDataExecutor Members

        public void Execute(TDataContext data)
        {
            if (EnableExecute(data.Id))
            {
                //todo:{WT}, to hook a pre-event here

                DoExecute(data);

                //todo:{WT}, to hook a post-event here, for example to hook a log
            }
            else
            {
                throw new Exception(string.Format("{0} has executed already.", data.Name));
            }
        }

        #endregion

        protected abstract void DoExecute(TDataContext data);

        private bool EnableExecute(int id)
        {
            return true;
        }
    }
}
