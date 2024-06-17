using CQRS.Practico.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Practico.Infrastructure.Commands
{
    public record UpdateTaskCommand(int Id, string Title, string Description, bool IsCompleted): IRequest<TaskItemDto>;
}
