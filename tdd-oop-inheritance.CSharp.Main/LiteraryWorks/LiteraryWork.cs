using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteraryWorks
{
    public abstract class LiteraryWork
    {
        public string title;
        bool onLoan = false;

        public LiteraryWork(string title)
        {
            this.title = title;
        }

        public bool isOnLoan()
        {
            return onLoan;
        }

        public virtual string checkIn()
        {
            if (!isOnLoan())
            {
                return "item is not currently on loan";
            }

            onLoan = false;

            return "item has been checked in";
        }

        public virtual string checkOut()
        {
            if (isOnLoan())
            {
                return "item is currently on loan";
            }

            onLoan = true;

            return "item has been checked out";
        }
    }
}
