﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormMVP練習.Model
{
    public class Phone
    {
        public Phone(string name, int price, string description) 
        {
            Name = name;
            Price = price;
            Description = description;
        }
        public string Name { get; set; }
        public int Price {  get; set; }
        public string Description { get; set; } 
    }
}
