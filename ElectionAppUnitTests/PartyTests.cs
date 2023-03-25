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
            // Arrange
            int expectedListNumber = 1;
            string expectedName = "Test Party";

            // Act
            Party party = new Party(expectedListNumber, expectedName);

            // Assert
            Assert.AreEqual(expectedListNumber, party.ListNumber);
            Assert.AreEqual(expectedName, party.Name);
            Assert.AreEqual(0, party.Votes);
        }

        [TestMethod]
        public void TestConstructorWithListNumberNameAndPreferenceNumber()
        {
            // Arrange
            int expectedListNumber = 1;
            string expectedName = "Test Party";
            int expectedPreferenceNumber = 1;

            // Act
            Party party = new Party(expectedListNumber, expectedName, expectedPreferenceNumber);

            // Assert
            Assert.AreEqual(expectedListNumber, party.ListNumber);
            Assert.AreEqual(expectedName, party.Name);
            Assert.AreEqual(expectedPreferenceNumber, party.PreferenceNumber);
            Assert.AreEqual(0, party.Votes);
        }

        [TestMethod]
        public void TestIDSetterWithValidValue()
        {
            // Arrange
            Party party = new Party();
            int expectedID = 1;

            // Act
            party.ID = expectedID;

            // Assert
            Assert.AreEqual(expectedID, party.ID);
        }

        [TestMethod]
        public void TestIDSetterWithInvalidValue()
        {
            // Arrange
            Party party = new Party();

            // Assert
            Assert.ThrowsException<ArgumentException>(() => party.ID = 0);
        }

        [TestMethod]
        public void TestNameSetterWithValidValue()
        {
            // Arrange
            Party party = new Party();
            string expectedName = "Test Party";

            // Act
            party.Name = expectedName;

            // Assert
            Assert.AreEqual(expectedName, party.Name);
        }

        [TestMethod]
        public void TestNameSetterWithNullOrEmptyValue()
        {
            // Arrange
            Party party = new Party();

            // Assert
            Assert.ThrowsException<ArgumentException>(() => party.Name = null);
            Assert.ThrowsException<ArgumentException>(() => party.Name = "");
        }

        [TestMethod]
        public void TestListNumberSetterWithValidValue()
        {
            // Arrange
            Party party = new Party();
            int expectedListNumber = 1;

            // Act
            party.ListNumber = expectedListNumber;

            // Assert
            Assert.AreEqual(expectedListNumber, party.ListNumber);
        }

        [TestMethod]
        public void TestPreferenceNumberSetterWithValidValue()
        {
            // Arrange
            Party party = new Party();
            int expectedPreferenceNumber = 1;

            // Act
            party.PreferenceNumber = expectedPreferenceNumber;

            // Assert
            Assert.AreEqual(expectedPreferenceNumber, party.PreferenceNumber);
        }

        [TestMethod]
        public void TestVotesGetterAndSetter()
        {
            // Arrange
            Party party = new Party();
            int expectedVotes = 10;

            // Act
            party.Votes = expectedVotes;

            // Assert
            Assert.AreEqual(expectedVotes, party.Votes);
        }
    }
}
