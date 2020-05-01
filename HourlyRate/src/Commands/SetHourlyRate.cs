using System;
using MediatR;

namespace HourlyRate.Commands
{
    public class SetHourlyRate :  IRequest
    {
        public short HourlyRate { get; set; }       
        public Guid UserId { get; set; }       
    }
}