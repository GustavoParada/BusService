﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rabbit.MVC.Models.DTO
{
    public class TransferDTO
    {
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmout { get; set; }
    }
}
