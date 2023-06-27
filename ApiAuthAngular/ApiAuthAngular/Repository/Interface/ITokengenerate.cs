using ApiAuthAngular.Models.DTO;

namespace ApiAuthAngular.Repository.Interface
{
    public interface ITokengenerate
    {
        public string GenerateToken(UserDTO user);

    }
}
