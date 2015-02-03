using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgencyAlchemy.Core.Data;
using AgencyAlchemy.Core.Utility;
using AgencyAlchemy.Core.DataModel;

namespace AgencyAlchemy.Tests.Core
{
    [TestClass]
    public class AuthenticateUserTest
    {
        [TestMethod]
        public void AuthenticateInvalidCreds()
        {
           String props = PropertyExtractor.GetProperties(typeof(AgencyUserRole));
            RegisteredUser user = RegisteredUser.Authenticate(5, "scott.detweiler@gmail.com", "371444D0", false, false);

            Assert.IsNull(user);
        }

        [TestMethod]
        public void AuthenticateValidCreds()
        {
            RegisteredUser user = RegisteredUser.Authenticate(5, "scott.detweiler@gmail.com", "371444D8", false, false);

            Assert.IsNotNull(user);
        }
    }
}
