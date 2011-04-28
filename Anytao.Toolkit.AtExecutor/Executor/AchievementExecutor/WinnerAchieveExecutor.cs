using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Toolkit.AtExecutor.Executor
{
    public class WinnerAchieveExecutor : AchievementExecutorBase
    {
        protected override void DoExecute(Data.Achievement data)
        {
            Console.WriteLine("{0}, {1}，授予你[{2}]称号。", data.MemberId, data.Desc, data.Title);
        }
    }
}
