using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgencyAlchemy.Core.Data
{
    public struct AgencyAccountSettings
    {
        public int AgencyId ;
        public int ClientId;
        public Boolean IsAdmin;
        public Boolean IsClient;
        public Boolean IsTalent;
        public Boolean IsClientManager;
        public Boolean IsTalentManager;
        public Boolean IsExclusive;
        public Boolean SendInvite;
        public String Title;
        public String Notes;
    }
}

