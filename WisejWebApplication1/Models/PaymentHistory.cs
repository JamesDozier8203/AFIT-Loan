﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFIT_Cooperative.Models
{
    public class PaymentHistory
    {
        public PaymentHistory()
        {
            Id = Guid.NewGuid();
            PaidAt = DateTime.Now;
        }

        public Guid Id { set; get; }
        public virtual Member Member { set; get; }
        public double Amount { set; get; }
        public DateTime PaidAt { set; get; }
    }

    public class PaymentHistoryDisplay
    {
        public Guid Id { set; get; }
        public string Fullname { set; get; }
        public string Amount { set; get; }
        public string Date { set; get; }
    }
}