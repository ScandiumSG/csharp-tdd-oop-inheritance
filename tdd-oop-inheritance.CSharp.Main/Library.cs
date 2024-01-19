using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        List<LiteraryWork> works = new List<LiteraryWork>();

        public void addToStock(LiteraryWork work) 
        {
            this.works.Add(work);
        }


        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        public string checkInWork(string title) 
        {
            List<LiteraryWork> filtered = (List<LiteraryWork>)this.works.Where(work => work.title.Equals(title));

            if (filtered.Count() < 1) 
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutWork(string title)
        {
            List<LiteraryWork> filtered = (List<LiteraryWork>)this.works.Where(work => work.title.Equals(title));

            if (filtered.Count() < 1) 
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }
    }
}
