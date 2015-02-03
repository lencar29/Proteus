using System;
using AgencyAlchemy.Core.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgencyAlchemy.Tests.Core
{
    [TestClass]
    public class SkinTest
    {
        [TestMethod]
        public void GetMultipleSkins()
        {
            Skin[] skins = Skin.GetMultipleSkins(1, 1, 9);

            Assert.IsNotNull(skins);
        }
    }
}
