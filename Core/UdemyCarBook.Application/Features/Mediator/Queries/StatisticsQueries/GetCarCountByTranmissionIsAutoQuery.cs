﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResult;

namespace UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries
{
    public class GetCarCountByTranmissionIsAutoQuery:IRequest<GetCarCountByTranmissionIsAutoQueryResult>
    {
    }
}
