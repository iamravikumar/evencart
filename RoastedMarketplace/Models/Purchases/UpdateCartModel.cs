﻿using RoastedMarketplace.Infrastructure.Mvc.Models;

namespace RoastedMarketplace.Models.Purchases
{
    public class UpdateCartModel : FoundationModel
    {
        public string DiscountCoupon { get; set; }

        public string GiftCode { get; set; }

        public int? CartItemId { get; set; }

        public int? Quantity { get; set; }

        public bool RemoveCoupon { get; set; }
    }
}