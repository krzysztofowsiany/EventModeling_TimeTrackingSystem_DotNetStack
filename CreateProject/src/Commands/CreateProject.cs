using System;
using MediatR;

namespace CreateProject.Commands
{
    public class CreateProject :  IRequest
    {
        public string Name { get; set; }       
        public Guid ProjectId { get; set; }
        public Guid ProjectOwnerId { get; set; }
    }
}