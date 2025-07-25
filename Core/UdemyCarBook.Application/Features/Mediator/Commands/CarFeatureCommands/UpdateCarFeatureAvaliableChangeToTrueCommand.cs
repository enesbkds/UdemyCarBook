using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.Mediator.Commands.CarFeatureCommands
{
    public class UpdateCarFeatureAvaliableChangeToTrueCommand:IRequest
    {
        public int Id { get; set; }

        public UpdateCarFeatureAvaliableChangeToTrueCommand(int id)
        {
            Id = id;
        }
    }
}
