﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace easyfis.Entities
{
    public class TrnReceivingReceiptItem
    {
        public Int32 Id { get; set; }
        public Int32 RRId { get; set; }
        public Int32 POId { get; set; }
        public String PONumber { get; set; }
        public Int32 ItemId { get; set; }
        public String ItemCode { get; set; }
        public String ItemManualArticleOldCode { get; set; }
        public String ItemDescription { get; set; }
        public String Particulars { get; set; }
        public Int32 UnitId { get; set; }
        public String Unit { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Cost { get; set; }
        public Decimal Amount { get; set; }
        public Int32 BranchId { get; set; }
        public String Branch { get; set; }
        public Int32 VATId { get; set; }
        public String VAT { get; set; }
        public Decimal VATPercentage { get; set; }
        public Decimal VATAmount { get; set; }
        public Int32 WTAXId { get; set; }
        public String WTAX { get; set; }
        public Decimal WTAXPercentage { get; set; }
        public Decimal WTAXAmount { get; set; }
        public Int32 BaseUnitId { get; set; }
        public String BaseUnit { get; set; }
        public Decimal BaseQuantity { get; set; }
        public Decimal BaseCost { get; set; }
    }
}