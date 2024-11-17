using Usuarios.Domain.Abstractions;
namespace Usuarios.Domain.Events;
public sealed record UserCreateDomainEvent(Guid id) : IDomainEvent; 