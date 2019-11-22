﻿using System;
using System.Collections.Generic;

namespace Interfaces
{
    public class Customer : Person, ICloneable
    {
        public List<Credit> Credits;
        public object Clone()
        {
            Customer customer = (Customer)this.MemberwiseClone();
            customer.Credits = new List<Credit>();
            foreach (Credit item in Credits)
            {
                customer.Credits.Add(new Credit { Date = item.Date, Amount = item.Amount });
            }
            return customer;
        }
        public int GetAmounts()
        {
            int total = 0;
            foreach (Credit item in Credits)
            {
                total += item.Amount;
            }
            return total;
        }
        public override string ToString()
        {
            return $"{Name} {Surname} {GetAmounts()}";
        }
    }
}