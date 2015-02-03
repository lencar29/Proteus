using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgencyAlchemy.Core.Data;
using System.Collections.Generic;

namespace AgencyAlchemy.Tests.Core
{
    [TestClass]
    public class ProfileTest
    {
        [TestMethod]
        public void FetchByAgencyId()
        {
            List<UserProfile> profiles = new List<UserProfile>();
            int totalRecords;

            profiles.AddRange(UserProfile.FetchByAgencyId(5, out totalRecords));

            Assert.IsNotNull(profiles);
            Assert.IsTrue(profiles.Count == 10);
        }

        [TestMethod]
        public void GetFreeLancers()
        {
            List<UserProfile> profiles = new List<UserProfile>();
            int totalRecords;

            profiles.AddRange(UserProfile.FetchFreeLancers(out totalRecords));

            Assert.IsNotNull(profiles);
            Assert.IsTrue(profiles.Count == 10);
        }
    }
}
