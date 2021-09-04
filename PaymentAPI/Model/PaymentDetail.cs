﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Model
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailId { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string CardOwnerName { get; set; }
        [Column(TypeName = "varchar(16)")]
        public string CardNumber { get; set; }
        [Column(TypeName = "varchar(5)")]
        public string ExpirationDate { get; set; }
        [Column(TypeName = "varchar(3)")]
        public string SecurityCode { get; set; }
    }
}
