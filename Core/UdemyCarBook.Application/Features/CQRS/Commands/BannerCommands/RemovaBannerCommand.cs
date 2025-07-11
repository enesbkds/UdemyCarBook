using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.CQRS.Commands.BannerCommands
{
    public class RemovaBannerCommand
    {
        public int Id { get; set; }

        public RemovaBannerCommand(int id)
        {
            Id = id;
        }
    }
}
