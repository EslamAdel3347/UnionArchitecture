using System;

namespace HrLeaveManagement.Application.Exceptions
{
    public class NotFoundExceptions:ApplicationException
    {
        public NotFoundExceptions(string name, object Key) : base($"{name}({Key}) not Found ")
        {

        }
    }
}
