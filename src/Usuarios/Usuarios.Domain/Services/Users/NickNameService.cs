namespace Usuarios.Domain.Services.Users;
using Usuarios.Domain.ValueObjects.Generics;
using Usuarios.Domain.ValueObjects.Users;

public class NickNameService
{
    public NickName GenerateNickName(
        Name firstName,
        LastName lastName
    )
    {
        var initialName = firstName.Value.Substring(0, 1);
        var remainingName = lastName.Value.Trim();
        return NickName.Create(initialName + remainingName);
    }
}
