using System;
using System.Collections.Generic;
using AgencyAlchemy.Core.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgencyAlchemy.Tests.Core
{
    [TestClass]
    public class MediaTest
    {
        [TestMethod]
        public void GetTalentMedia()
        {
            List<Media> media = new List<Media>();
            int totalRecords;

            media.AddRange(Media.GetTalentMedia(349, out totalRecords));

            Assert.IsTrue(totalRecords > 50);
            Assert.AreEqual(media.Count, 10);
        }
    }
}
