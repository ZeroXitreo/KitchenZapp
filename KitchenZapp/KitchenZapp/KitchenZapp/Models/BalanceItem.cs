﻿using System;

namespace KitchenZapp.Models
{
    public class BalanceItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; } = 1;
        public DateTime DateTime { get; set; }

        public double Total => -Price * Amount;

        public bool IsTotalNegative => Total < 0;
    }
}
