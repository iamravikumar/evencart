﻿using RoastedMarketplace.Core.Data;

namespace RoastedMarketplace.Data.Entity.Shop
{
    public class ProductSpecificationValue : FoundationEntity
    {
        public int ProductSpecificationId { get; set; }

        public int AvailableAttributeValueId { get; set; }

        public string Label { get; set; }

        #region Virtual Properties
        public virtual AvailableAttributeValue AvailableAttributeValue { get; set; }
        #endregion
    }
}