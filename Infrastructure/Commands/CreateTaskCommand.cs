using CQRS.Practico.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Practico.Infrastructure.Commands
{
    public record CreateTaskCommand(string Title, string Description): IRequest<TaskItemDto>;

}
