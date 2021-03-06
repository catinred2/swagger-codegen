using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing Pet
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PetTests
    {
        private Pet instance;

		private long petId = 11088;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
			instance = new Pet(Name: "Csharp test", PhotoUrls: new List<string> { "http://petstore.com/csharp_test" });
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Pet
        /// </summary>
        [Test]
        public void PetInstanceTest()
        {
            Assert.IsInstanceOf<Pet> (instance, "instance is a Pet");
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Category'
        /// </summary>
        [Test]
        public void CategoryTest()
        {
            // TODO: unit test for the property 'Category'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'PhotoUrls'
        /// </summary>
        [Test]
        public void PhotoUrlsTest()
        {
            // TODO: unit test for the property 'PhotoUrls'
        }
        /// <summary>
        /// Test the property 'Tags'
        /// </summary>
        [Test]
        public void TagsTest()
        {
            // TODO: unit test for the property 'Tags'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO: unit test for the property 'Status'
        }

		/// <summary>
		/// Test Equal
		/// </summary>
		[Test ()]
		public void TestEqual()
		{
			// create pet
			Pet p1 = new Pet (Name: "Csharp test", PhotoUrls: new List<string> { "http://petstore.com/csharp_test" });
			p1.Id = petId;
			//p1.Name = "Csharp test";
			p1.Status = Pet.StatusEnum.Available;
			// create Category object
			Category category1 = new Category ();
			category1.Id = 56;
			category1.Name = "sample category name2";
			List<String> photoUrls1 = new List<String> (new String[] { "sample photoUrls" });
			// create Tag object
			Tag tag1 = new Tag ();
			tag1.Id = petId;
			tag1.Name = "csharp sample tag name1";
			List<Tag> tags1 = new List<Tag> (new Tag[] { tag1 });
			p1.Tags = tags1;
			p1.Category = category1;
			p1.PhotoUrls = photoUrls1;

			// create pet 2
			Pet p2 = new Pet (Name: "Csharp test", PhotoUrls: new List<string> { "http://petstore.com/csharp_test" });
			p2.Id = petId;
			p2.Name = "Csharp test";
			p2.Status = Pet.StatusEnum.Available;
			// create Category object
			Category category2 = new Category ();
			category2.Id = 56;
			category2.Name = "sample category name2";
			List<String> photoUrls2 = new List<String> (new String[] { "sample photoUrls" });
			// create Tag object
			Tag tag2 = new Tag ();
			tag2.Id = petId;
			tag2.Name = "csharp sample tag name1";
			List<Tag> tags2 = new List<Tag> (new Tag[] { tag2 });
			p2.Tags = tags2;
			p2.Category = category2;
			p2.PhotoUrls = photoUrls2;

			// p1 and p2 should be equal (both object and attribute level)
			Assert.IsTrue (category1.Equals (category2));
			Assert.IsTrue (tags1.SequenceEqual (tags2));
			Assert.IsTrue (p1.PhotoUrls.SequenceEqual (p2.PhotoUrls));

			Assert.IsTrue (p1.Equals (p2));

			// update attribute to that p1 and p2 are not equal
			category2.Name = "new category name";
			Assert.IsFalse (category1.Equals (category2));

			tags2 = new List<Tag> ();
			Assert.IsFalse (tags1.SequenceEqual (tags2));

			// photoUrls has not changed so it should be equal
			Assert.IsTrue (p1.PhotoUrls.SequenceEqual (p2.PhotoUrls));

			Assert.IsFalse (p1.Equals (p2));
		}
    }

}
