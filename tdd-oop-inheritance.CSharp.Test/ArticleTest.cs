using NUnit.Framework;
using LiteraryWorks;
using tdd_oop_inheritance.CSharp.Main.Interface;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
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
                LiteraryWork article = new Article("NUnit Rocks", author);
                Assert.AreEqual("item has been checked out", article.checkOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
                LiteraryWork article = new Article("NUnit Rocks", author);
                article.checkOut();

                Assert.AreEqual("item is currently on loan", article.checkOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
                LiteraryWork article = new Article("NUnit Rocks", author);
                article.checkOut();

                Assert.AreEqual("item has been checked in", article.checkIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
                LiteraryWork article = new Article("NUnit Rocks", author);

                Assert.AreEqual("item is not currently on loan", article.checkIn());
            }

        [Test]
        public void shouldReturnTheAuthor()
        {
            LiteraryWork article = new Article("NUnit Rocks", author);

            IAuthor res = (article as Article).Author;

            Assert.That(res.Name, Is.EqualTo("Author Authorson"));
            Assert.That(res.ContactInformation, Is.EqualTo("An Address 1, 9999 El Dorado"));
            Assert.That(res.Website, Is.EqualTo("MySuperAwesomeSite.com"));
        }
    }
}