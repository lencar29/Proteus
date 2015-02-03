using System;
using System.Collections.Generic;
using AgencyAlchemy.Core.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgencyAlchemy.Tests
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void FetchByAgencyId()
        {
            int totalRecords;

            IEnumerable<Client> clients = Client.GetAgencyClients(5, out totalRecords, 2);
            List<Client> list = new List<Client>();

            list.AddRange(clients);

            Assert.IsNotNull(clients);
            Assert.IsTrue(list.Count > 1);
        }

        [TestMethod]
        public void FetchByClientId()
        {
            Client client = Client.FetchByClientId(35);

            Assert.IsNotNull(client);
            Assert.AreEqual(client.client_name, "Wives R Us");
        }
    }
}
