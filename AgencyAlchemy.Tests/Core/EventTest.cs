using System;
using System.Collections.Generic;
using AgencyAlchemy.Core.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgencyAlchemy.Tests.Core
{
    [TestClass]
    public class EventTest
    {
        [TestMethod]
        public void GetAgencyEvents()
        {
            List<Event> list = new List<Event>();
            int recordCount;

            list.AddRange(Event.GetAgencyEvents(5, out recordCount));

            Assert.IsTrue(recordCount > 20);
            Assert.AreEqual(list.Count, 10);
        }
    }
}
