namespace Usuarios.Api.Service;
using Usuarios.Api.Models;
public interface IUserService
{

    Task<UserModel?> GetUserByIdAsync(Guid id);
    Task<UserModel> CreateUserAsync(UserModel user);
    Task<UserModel?> UpdateUserAsync(Guid id, UserModel user);
    Task<bool> DeleteUserAsync(Guid id);
    
}
