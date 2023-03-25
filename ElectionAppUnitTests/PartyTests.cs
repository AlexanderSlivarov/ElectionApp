using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Data.Model;

namespace ElectionAppUnitTests
{
    [TestClass]
    public class PartyTests
    {
        [TestMethod]
        public void TestEmptyConstructor()
        {           
            Party party = new Party();            
            Assert.IsNotNull(party);
        }

        [TestMethod]
        public void TestConstructorWithListNumberAndName()
        {            
            int expectedListNumber = 1;
            string expectedName = "Test Party";
            
            Party party = new Party(expectedListNumber, expectedName);
            
            Assert.AreEqual(expectedListNumber, party.ListNumber);
            Assert.AreEqual(expectedName, party.Name);
            Assert.AreEqual(0, party.Votes);
        }

        [TestMethod]
        public void TestConstructorWithListNumberNameAndPreferenceNumber()
        {            
            int expectedListNumber = 1;
            string expectedName = "Test Party";
            int expectedPreferenceNumber = 1;
           
            Party party = new Party(expectedListNumber, expectedName, expectedPreferenceNumber);
            
            Assert.AreEqual(expectedListNumber, party.ListNumber);
            Assert.AreEqual(expectedName, party.Name);
            Assert.AreEqual(expectedPreferenceNumber, party.PreferenceNumber);
            Assert.AreEqual(0, party.Votes);
        }

        [TestMethod]
        public void TestIDSetterWithValidValue()
        {            
            Party party = new Party();
            int expectedID = 1;            
            party.ID = expectedID;            
            Assert.AreEqual(expectedID, party.ID);
        }

        [TestMethod]
        public void TestIDSetterWithInvalidValue()
        {           
            Party party = new Party();            
            Assert.ThrowsException<ArgumentException>(() => party.ID = 0);
        }

        [TestMethod]
        public void TestNameSetterWithValidValue()
        {            
            Party party = new Party();
            string expectedName = "Test Party";            
            party.Name = expectedName;            
            Assert.AreEqual(expectedName, party.Name);
        }

        [TestMethod]
        public void TestNameSetterWithNullOrEmptyValue()
        {            
            Party party = new Party();
            
            Assert.ThrowsException<ArgumentException>(() => party.Name = null);
            Assert.ThrowsException<ArgumentException>(() => party.Name = "");
        }

        [TestMethod]
        public void TestListNumberSetterWithValidValue()
        {            
            Party party = new Party();
            int expectedListNumber = 1;            
            party.ListNumber = expectedListNumber;            
            Assert.AreEqual(expectedListNumber, party.ListNumber);
        }

        [TestMethod]
        public void TestPreferenceNumberSetterWithValidValue()
        {            
            Party party = new Party();
            int expectedPreferenceNumber = 1;           
            party.PreferenceNumber = expectedPreferenceNumber;            
            Assert.AreEqual(expectedPreferenceNumber, party.PreferenceNumber);
        }

        [TestMethod]
        public void TestVotesGetterAndSetter()
        {
            Party party = new Party();
            int expectedVotes = 10;            
            party.Votes = expectedVotes;            
            Assert.AreEqual(expectedVotes, party.Votes);
        }
    }
}
