using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace ProcessChanger.Infrastructure.Validators
{
    public class EmailDomainValidationAttributem : ValidationAttribute
    {
        public EmailDomainValidationAttributem()
        {
            this.ErrorMessage = "You must use correct domain adress";
        }

        public override bool IsValid(object value)
        {
            var strValue = value as string;

            if (string.IsNullOrEmpty(strValue))
                return false;

            MailAddress adress = new MailAddress(strValue);
            string host = adress.Host;

            return host == "grupoantolin.com";
        }
    }
}