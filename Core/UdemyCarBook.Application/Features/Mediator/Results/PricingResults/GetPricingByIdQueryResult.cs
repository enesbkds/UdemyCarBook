﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Results.PricingResults
{
    public class GetPricingByIdQueryResult
    {
        public int PricingID { get; set; }
        public string Name { get; set; }
    }
}
