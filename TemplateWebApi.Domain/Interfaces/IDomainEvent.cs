using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateWebApi.Domain.Interfaces
{
    public interface IDomainEvent
    {
        public List<DomainEvent> DomainEvents { get; set; }
    }
}
