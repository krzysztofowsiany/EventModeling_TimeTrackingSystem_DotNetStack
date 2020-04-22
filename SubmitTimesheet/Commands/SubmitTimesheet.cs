using System;
using MediatR;

namespace SubmitTimesheet.Commands
{
    public class SubmitTimesheet :  IRequest
    {
        public Guid TimesheetId { get; set; }       
        public Guid UserId { get; set; }       
        public DateTime StartDate { get; set; }       
        public DateTime EndDate { get; set; }       
    }
}