using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AutoMapper;
using AME.Entities;
using AME.UI.Win.Models;

namespace AME.Tests.Presentation
{
    /// <summary>
    /// Test model mapping to entity model.
    /// </summary>
    /// <remarks>See testing pattern <a href="http://wiki.c2.com/?ArrangeActAssert">here</a></remarks>
    [TestClass]
    public class MappingTests
    {
        /// <summary>
        /// Asserts that all individually mapped model properties and values have an equivalent entity model property and value.
        /// </summary>
        [TestMethod]
        public void MemberMapperMapsToExpectedPropertyValues()
        {
            // Arrange
            var model = new MemberModel()
            {
                FirstName = "Robert",
                LastName = "Smith",
                Address = "123 Sunny Lane",
                City = "Tallahassee",
                State = "FL",
                Zip = "12345"
            };

            // Act
            Mapper.Initialize(cfg =>
                cfg.CreateMap<MemberModel, Member>());

            Member member = Mapper.Map<Member>(model);

            // Assert
            Assert.AreEqual("Robert", member.FirstName);
            Assert.AreEqual("Smith", member.LastName);
            Assert.AreEqual("123 Sunny Lane", member.Address);
            Assert.AreEqual("Tallahassee", member.City);
            Assert.AreEqual("FL", member.State);
            Assert.AreEqual("12345", member.Zip);

        }

        /// <summary>
        /// Checks to make sure that every single Destination type member has a corresponding type member on the source type.
        /// </summary>
        [TestMethod]
        public void MemberMapperMapsToExpectedTypes()
        {
            // Arrange
            var model = new MemberModel()
            {
                FirstName = "Robert",
                LastName = "Smith",
                Address = "123 Sunny Lane",
                City = "Tallahassee",
                State = "FL",
                Zip = "12345"
            };

            // Act
            Mapper.Initialize(cfg =>
                cfg.CreateMap<MemberModel, Member>());

            Mapper.Initialize(c => c.AddGlobalIgnore("Errors"));
  
            // Assert
            Mapper.Configuration.AssertConfigurationIsValid();
        }
    }
}
