using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcessChanger.Validators
{
    public class ValidationResult
    {
        public ValidationResult(string key, string errorMessage)
        {
            Key = key;
            ErrorMessage = errorMessage;
        }

        public string Key { get; }
        public string ErrorMessage { get; }
    }
}