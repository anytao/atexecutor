using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anytao.Toolkit.AtExecutor.Data;

namespace Anytao.Toolkit.AtExecutor.Executor
{
    public abstract class ActivityExecutorBase : DataExecutorBase<Activity>
    {
        protected override void DoExecute(Activity data)
        {
            throw new NotImplementedException();
        }
    }
}
