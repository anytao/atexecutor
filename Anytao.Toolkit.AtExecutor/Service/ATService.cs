using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anytao.Toolkit.AtExecutor.Data;
using DS.SH.Common;
using System.Xml.Linq;
using Anytao.Toolkit.AtExecutor.Executor;

namespace Anytao.Toolkit.AtExecutor
{
    public class ATService : IATService
    {
        #region IATService Members

        public void DoAchieve(int gangId)
        {
            var achieves = GetUnCheckedAchieveList(gangId);

            foreach (var item in achieves)
            {
                item.MemberId = gangId;
                IDataExecutor<Achievement> executor = ExecutorFactory<Achievement>.Build(item.Executor);
                 
                executor.Execute(item);
            }
        }

        public void DoEvent(int gangId)
        {
            throw new NotImplementedException();
        }

        public void DoActivity(int gangId, int activityId)
        {
            throw new NotImplementedException();
        }

        public void DoAchieves()
        {
            throw new NotImplementedException();
        }

        public void DoEvents()
        {
            throw new NotImplementedException();
        }

        #endregion


        /// <summary>
        /// To load the achievement list which this gang doesn't get
        /// </summary>
        /// <param name="gangId"></param>
        /// <returns></returns>
        private IList<Achievement> GetUnCheckedAchieveList(int gangId)
        {
            var doc = XDocument.Load("_data/achievement.xml");

            var list = (from p in doc.Descendants("achievement")
                       select new Achievement
                       {
                           Id = int.Parse(p.Element("id").Value.ToString()),
                           Name = p.Element("name").Value.ToString(),
                           Title = p.Element("title").Value.ToString(),
                           Executor = p.Element("executor").Value.ToString(),
                           Desc = p.Element("desc").Value.ToString()
                       }).ToList();


            return list;
        }
    }
}
