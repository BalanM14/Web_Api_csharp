using APiAuthAngular.Models;

namespace ApiAuthAngular.Models.DTO
{
    public class UserRegisterDTO : User
    {
        /*public string? EmailClear { get; set; }*/
        public string? PasswordClear { get; set; }
    }
}
