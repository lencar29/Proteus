using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgencyAlchemy.Core.Utility
{
    public class UserPathManager
    {
        private UserPathManager upd = null;
        private String role = null;
        private IDictionary<String, String> actionInfo = new Dictionary<String, String>();

        public UserPathManager(String role)
        {
            this.role = role;
        }

        public IDictionary<String, String> GetUserPath(params String[] roles)
        {
            if (roles.Contains(role))
                return actionInfo;
            else
            {
                if (upd != null)
                    return upd.GetUserPath(role);
            }
            return null;
        }

        public void Add(UserPathManager manager)
        {
            if (manager != null && manager != upd)
                upd = manager;
        }

        public void AddActionDetails(String action, String controller)
        {
            actionInfo.Clear();

            actionInfo.Add("Action", action);
            actionInfo.Add("Controller", controller);            

        }
    }
}