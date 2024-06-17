using CQRS.Practico.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Practico.Infrastructure.Queries
{
    public record GetTaskByIdQuery(int Id): IRequest<TaskItemDto>;

}
