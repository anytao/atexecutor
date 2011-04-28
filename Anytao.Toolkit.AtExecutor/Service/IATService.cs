using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Toolkit.AtExecutor
{
    public interface IATService
    {
        // Execute achievement for specific user
        void DoAchieve(int gangId);

        // Execute event for specific user
        void DoEvent(int gangId);

        // Execute activity for specific user
        void DoActivity(int gangId, int activityId);

        // Execute archievement for all users
        void DoAchieves();
        // Execute events for all users
        void DoEvents();
    }
}
