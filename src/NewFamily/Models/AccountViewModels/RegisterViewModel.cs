using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics.Views;
using Microsoft.DotNet.ProjectModel;

namespace NewFamily.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "В {0} должно быть не менее {2} и не более {1} символов.", MinimumLength = 6)]
        [RegularExpression(@"^.*(?=.{6,100})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=<>]).*$", ErrorMessage = "Пароль должен иметь по крайней мере один не алфавитно-цифровой символ.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Пароль и подтверждение пароля не совпадают.")]
        public string ConfirmPassword { get; set; }
    }
}
