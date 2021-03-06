﻿#region License
// Copyright (c) Sojatia Infocrafts Private Limited.
// The following code is part of EvenCart eCommerce Software (https://evencart.co) Dual Licensed under the terms of
// 
// 1. GNU GPLv3 with additional terms (available to read at https://evencart.co/license)
// 2. EvenCart Proprietary License (available to read at https://evencart.co/license/commercial-license).
// 
// You can select one of the above two licenses according to your requirements. The usage of this code is
// subject to the terms of the license chosen by you.
#endregion

using System.Collections.Generic;
using EvenCart.Areas.Administration.Models.Store;
using EvenCart.Infrastructure.Mvc.Models;
using EvenCart.Infrastructure.Mvc.Validator;
using FluentValidation;

namespace EvenCart.Areas.Administration.Models.Catalog
{
    public class CatalogModel : FoundationEntityModel, IRequiresValidations<CatalogModel>
    {
        public string Name { get; set; }

        public IList<int> StoreIds { get; set; }

        public void SetupValidationRules(ModelValidator<CatalogModel> v)
        {
            v.RuleFor(x => x.Name).NotEmpty();
        }
    }
}