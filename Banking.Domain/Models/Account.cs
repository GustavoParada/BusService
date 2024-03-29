﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Banking.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string FromAccount { get; set; }
        public string ToAccount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TransferAmount { get; set; }
    }
}
