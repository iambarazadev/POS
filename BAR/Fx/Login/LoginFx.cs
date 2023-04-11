using System;
using System.ComponentModel.DataAnnotations;
namespace BAR.Fx.Login;

public class LoginFx{
    
    [Required(ErrorMessage="Valid e-mail address please!"),MaxLength(30),MinLength(3),DataType(DataType.EmailAddress)]
    [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Not valid e-mail")] 
    public string? UserName {get;set;}
    
    [Required]
    [StringLength(18, ErrorMessage = "Min 8 chars, atleast one numb, char & symbol", MinimumLength = 8)]
    [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
    [DataType(DataType.Password)]
    public string? Password {get;set;}
    
    public LoginFx()
    {
        this.UserName = null;
        this.Password = null;
    }
}