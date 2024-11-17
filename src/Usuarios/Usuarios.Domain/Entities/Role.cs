namespace Usuarios.Domain.Entities;
using Usuarios.Domain.Abstractions;
using Usuarios.Domain.ValueObjects.Generics;
using Usuarios.Domain.ValueObjects.Users;
using Usuarios.Domain.ValueObjects.Roles;

public class Role : Entity{
    public Role(){}
    private Role(Guid id, Name? roleName, Description? roleDescription) : base(id){
        RoleName = roleName;
        RoleDescription = roleDescription;
    }

    public Name? RoleName { get; private set; }
    public Description? RoleDescription { get; private set; }

    public static Role Create( Name? RoleName, Description? RoleDescription){
        return new Role( new Guid(), RoleName, RoleDescription);
    }

}