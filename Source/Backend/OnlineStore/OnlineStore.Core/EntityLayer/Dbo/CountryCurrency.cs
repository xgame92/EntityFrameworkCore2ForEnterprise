﻿using System;

namespace OnlineStore.Core.EntityLayer.Dbo
{
    public class CountryCurrency : IAuditableEntity
    {
        public CountryCurrency()
        {
        }

        public int? CountryCurrencyID { get; set; }

        public int? CountryID { get; set; }

        public string CurrencyID { get; set; }

        public string CreationUser { get; set; }

        public DateTime? CreationDateTime { get; set; }

        public string LastUpdateUser { get; set; }

        public DateTime? LastUpdateDateTime { get; set; }

        public byte[] Timestamp { get; set; }
    }
}
