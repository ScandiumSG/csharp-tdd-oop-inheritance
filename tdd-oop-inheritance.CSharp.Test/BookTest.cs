using NUnit.Framework;
using LiteraryWorks;
using tdd_oop_inheritance.CSharp.Main.Interface;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        private IAuthor author = new Author()
        {
            Name = "Author Authorson",
            ContactInformation = "An Address 1, 9999 El Dorado",
            Website = "MySuperAwesomeSite.com"
        };

        [Test]
        public void shouldCheckOutIfAvailable()
        {
            LiteraryWork book = new Book("NUnit Rocks", author);
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            LiteraryWork book = new Book("NUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            LiteraryWork book = new Book("NUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            LiteraryWork book = new Book("NUnit Rocks", author);

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }

        [Test]
        public void shouldReturnTheAuthor()
        {
            LiteraryWork article = new Book("NUnit Rocks", author);

            IAuthor res = (article as Book).Author;

            Assert.That(res.Name, Is.EqualTo("Author Authorson"));
            Assert.That(res.ContactInformation, Is.EqualTo("An Address 1, 9999 El Dorado"));
            Assert.That(res.Website, Is.EqualTo("MySuperAwesomeSite.com"));
        }
    }
}