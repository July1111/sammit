//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SummitService
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int ID_User { get; set; }
        public string FIO { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();
            if (string.IsNullOrWhiteSpace(this.FIO))
                errors.Add(new ValidationResult("Не указано ФИО пользователя"));
            if (string.IsNullOrWhiteSpace(this.Login))
                errors.Add(new ValidationResult("Не указан логин"));
            if (string.IsNullOrWhiteSpace(this.Password))
                errors.Add(new ValidationResult("Не указан пароль"));
            return errors;
        }
    }
}
