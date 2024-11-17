namespace Usuarios.Domain.Repositories;
using Usuarios.Domain.Entities;
using Usuarios.Domain.ValueObjects.Users;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    void Add(User user);
    void Delete(User user);
    Task<bool> EmailExistsAsync(Email email, CancellationToken cancellationToken = default);
}