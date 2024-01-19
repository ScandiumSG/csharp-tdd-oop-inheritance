﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main.Interface;

namespace LiteraryWorks
{
    public class Article : LiteraryWork, IAuthorable
    {
        IAuthor _author;
        public Article(string title, IAuthor author) : base(title)
        {
            _author = author;
        }

        public IAuthor Author { get { return _author; } set { _author = value; } }
    }
}
