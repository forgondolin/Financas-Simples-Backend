﻿using System;
using FS.Utils.Enums;

namespace FS.Data.Entities
{
    public sealed class Expense : Entity
    {        
        public Guid AccountId { get; set; }
        public decimal Value { get; set; }
        public string Description { get; set; }
        public Account Account { get; set; }
        public ECategory Category { get; set; }
    }
}