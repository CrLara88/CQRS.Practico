using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Practico.Infrastructure.Commands
{
    public record DeleteTaskCommand(int Id): IRequest<bool>;

}
