﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstRestApi.Contract.Dto
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
    }
}
