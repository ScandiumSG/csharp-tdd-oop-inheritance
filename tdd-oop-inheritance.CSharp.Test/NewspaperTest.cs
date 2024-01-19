using NUnit.Framework;
using LiteraryWorks;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class NewspaperTest
    {
        [Test]
        public void shouldBeUnavailableForCheckIn()
        {
            LiteraryWork newspaper = new Newspaper("The Daily C#");
            Assert.AreEqual("newspapers are not available for loan", newspaper.checkIn());
        }

        [Test]
        public void shouldBeUnavailableForCheckOut()
        {
            LiteraryWork newspaper = new Newspaper("The Daily C#");
            Assert.AreEqual("newspapers are not available for loan", newspaper.checkOut());
        }
    }
}