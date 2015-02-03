using System;
using System.Collections.Generic;
using AgencyAlchemy.Core.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgencyAlchemy.Tests.Core
{
    [TestClass]
    public class EventStatTest
    {
        [TestMethod]
        public void GetAgencyEventStats()
        {
            List<EventStat> list = new List<EventStat>();
            int recordCount;

            list.AddRange(EventStat.GetAgencyEventStats(5, out recordCount));

            Assert.IsTrue(recordCount > 20);
            Assert.AreEqual(list.Count, 10);
        }
    }
}
