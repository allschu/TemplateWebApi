using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateWebApi.Application.Commands
{
    public class AddCarCommand : IRequest<int>
    {
        public string Name { get; set; }
    }
}
