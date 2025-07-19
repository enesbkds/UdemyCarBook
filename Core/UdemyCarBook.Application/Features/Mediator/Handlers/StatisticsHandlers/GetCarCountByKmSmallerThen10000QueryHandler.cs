using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResult;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarCountByKmSmallerThen10000QueryHandler : IRequestHandler<GetCarCountByKmSmallerThen10000Query, GetCarCountByKmSmallerThen10000QueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarCountByKmSmallerThen10000QueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByKmSmallerThen10000QueryResult> Handle(GetCarCountByKmSmallerThen10000Query request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByKmSmallerThen10000();
            return new GetCarCountByKmSmallerThen10000QueryResult
            {
                CarCountByKmSmallerThen10000 = value
            };
        }
    }
}