using FluentValidation.Results;
using System;
using System.Collections.Generic;


namespace HrLeaveManagement.Application.Exceptions
{
    public class ValidationExceptions : ApplicationException
    {
        public List<string> Error = new List<string>();

        public ValidationExceptions(ValidationResult validationResult)
        {
            foreach (var item in validationResult.Errors)
            {
                Error.Add(item.ErrorMessage);
            }
        }
    }
}
