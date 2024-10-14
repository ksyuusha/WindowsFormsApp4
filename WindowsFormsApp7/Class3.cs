﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp7;

namespace WindowsFormsApp7
{
    public class NonFictionBook : IBook
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public bool IsAvailable { get; private set; } = true;

        public NonFictionBook(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public bool CheckOut()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                return true;
            }
            return false;
        }

        public void Return()
        {
            IsAvailable = true;
        }
    }
}
