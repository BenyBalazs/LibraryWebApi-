﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace LibraryWebApi.Models
{
    public class Book
    {
        public long Id { get; set; }
        public string BookTitle { get; set; }
        public bool IsBorrowed { get; set; }

        public override string ToString()
        {
            return $"Azonosító: {Id} Cím: {BookTitle} {(IsBorrowed ? "Kikölcsönözve" : "Könyvtárban")}";
        }
    }
}
