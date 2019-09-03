﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Transfer.Domain.Models
{
    public class TransferLog
    {
        public int Id { get; set; }

        public int FromAccount { get; set; }

        public int ToAccount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TransferAmount { get; set; }
    }
}
