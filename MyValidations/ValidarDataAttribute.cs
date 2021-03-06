using System;
using System.ComponentModel.DataAnnotations;

namespace MyValidations
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class ValidarDataAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var inputValue = value as string;
            DateTime dateValue;

            if (DateTime.TryParse(inputValue, out dateValue) && dateValue <= DateTime.Today) // datas com formato correto e não podem ser datas futuras
            {            
                return true;
            }
            else
            {            
                // throw new Exception("data inválida: use o formato DD/MM/AAAA");
                return false;
            }
        }        
    }
}