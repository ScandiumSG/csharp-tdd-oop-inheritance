using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class LibraryTest
    {
        Library lib = new Library();
        [OneTimeSetUp]
        public void SetUp()
        {
            lib = new Library();
            LiteraryWork work1 = new Book("The Old Man and the Sea");
            LiteraryWork work2 = new Book("Animal farm");
            LiteraryWork work3 = new Book("The Count of Monte Cristo");

            LiteraryWork work4 = new Newspaper("The Newspaper");
            LiteraryWork work5 = new Newspaper("The New Newspaper");
            LiteraryWork work6 = new Newspaper("The CIA front");

            LiteraryWork work7 = new Article("Why Python is slow");
            LiteraryWork work8 = new Article("Is Rust the future?");
            LiteraryWork work9 = new Article("Matlab is the greatest programming language ever");

            lib.addToStock(work1);
            lib.addToStock(work2);
            lib.addToStock(work3);
            lib.addToStock(work4);
            lib.addToStock(work5);
            lib.addToStock(work6);
            lib.addToStock(work7);
            lib.addToStock(work8);
            lib.addToStock(work9);

        }

        [Test, Order(1)]
        [TestCase("Why Python is slow", "item has been checked out")]
        [TestCase("Choosing the correct programming socks", "item is not part of the library's collection")]
        [TestCase("Animal farm", "item has been checked out")]
        [TestCase("The CIA front", "newspapers are not available for loan")]
        public void CheckOutWorkTest(string item, string expectedOutput) 
        {
            // Arrange
            // Done in SetUp

            // Act
            string res = lib.checkOutWork(item);

            // Assert
            Assert.That(res, Is.EqualTo(expectedOutput));

        }

        [Test, Order(2)]
        [TestCase("Why Python is slow", "item has been checked in")]
        [TestCase("How to select a mechanical keyboard", "item is not part of the library's collection")]
        [TestCase("The Old Man and the Sea", "item is not currently on loan")]
        [TestCase("The CIA front", "newspapers are not available for loan")]
        public void CheckInWorkTest(string item, string expectedOutput)
        {
            // Arrange
            // Done in SetUp

            // Act
            string res = lib.checkInWork(item);

            // Assert
            Assert.That(res, Is.EqualTo(expectedOutput));

        }
    }
}
