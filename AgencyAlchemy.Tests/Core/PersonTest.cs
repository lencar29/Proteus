using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using AgencyAlchemy.Core.Data;
using AgencyAlchemy.Core.Utility;

namespace AgencyAlchemy.Tests.Core
{
    [TestClass]
    public class PersonTest
    {
        Person _person;

        [TestMethod]
        public void FetchPersonById()
        {
            _person = Person.FetchPersonById(2);

            Assert.IsNotNull(_person);
        }

        [TestMethod]
        public void SavePerson()
        {
            _person = Person.GetNew();

            _person.people_firstname = "Leonard";
            _person.people_lastname = "Carter";
            _person.people_email = "carter.leonard71@gmail.com";
            _person.Save();

            var sp = ServiceLocator.GetNew();
            var pers = sp.ServiceProvider.people.Where(p => p.people_lastname == "Carter" && p.people_firstname == "Leonard").Single();

            Assert.IsNotNull(pers);
        }

        [TestMethod]
        public void UpdatePerson()
        {
            _person = _person = Person.FetchPersonById(2);

            _person.people_firstname = "Leonard";
            _person.Update();

            _person = _person = Person.FetchPersonById(2);

            Assert.AreNotEqual("Scott", _person.people_firstname);
        }

        [TestMethod]
        public void DeletePerson()
        {
            _person = Person.FetchPersonById(5018);

            _person.Delete();

            _person = Person.FetchPersonById(5018);

            Assert.IsNull(_person);
        }
    }
}
