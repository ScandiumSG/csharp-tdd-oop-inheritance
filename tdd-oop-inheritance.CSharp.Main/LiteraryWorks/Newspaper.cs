using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteraryWorks
{
    public class Newspaper : LiteraryWork
    {
        public Newspaper(string title) : base(title)
        {
        }

        public override string checkIn()
        {
            return "newspapers are not available for loan";
        }

        public override string checkOut()
        {
            return "newspapers are not available for loan";
        }
    }
}
