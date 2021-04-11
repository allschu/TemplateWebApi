using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TemplateWebApi.Application.Commands;

namespace TemplateWebApi.Application.CommandHandlers
{
    public class AddCarCommandHandler : IRequestHandler<AddCarCommand, int>
    {
        public Task<int> Handle(AddCarCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
