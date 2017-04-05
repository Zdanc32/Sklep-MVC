using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sklepik.Models.ViewModels
{
    public class UserSignUpView
    {
            [Key]
            [Required(ErrorMessage = "Podaj imię")]
            [Display(Name = "Imię:")]
            public string Login { get; set; }

            [Required(ErrorMessage = "Podaj hasło")]
            [DataType(DataType.Password)]
            [Display(Name = "Hasło:")]
            public string Password { get; set; }

            [Required(ErrorMessage = "Podaj e-mail")]
            [DataType(DataType.EmailAddress)]
            [Display(Name = "E-mail:")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Podaj nazwisko")]
            [DataType(DataType.EmailAddress)]
            [Display(Name = "nazwisko:")]
            public string Nazwisko { get; set; }

            [Required(ErrorMessage = "Podaj nr telefonu")]
            [DataType(DataType.EmailAddress)]
            [Display(Name = "nazwisko:")]
            public string Telefon { get; set; }

    }
}