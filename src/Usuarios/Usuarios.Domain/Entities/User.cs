namespace Usuarios.Domain.Entities;
using Usuarios.Domain.Entities.Errors;
using Usuarios.Domain.ValueObjects.Users;
using Usuarios.Domain.ValueObjects.Generics;
using Usuarios.Domain.Enums;
using Usuarios.Domain.Events;
using Usuarios.Domain.Abstractions;
using Usuarios.Domain.Services.Users;

    public class User : Entity
    {
        public NickName? UserName {get; private set;}   
        public Name? FirstName {get; private set;}
        public Name? SecondName {get; private set;}
        public LastName? FirstLastName {get; private set;}
        public LastName? SecondLastName {get; private set;}
        public Password? Password {get; private set;}
        public DateTime DateOfBirthday {get; private set;}
        public Address? Address {get; private set;}
        public Role? UserRole {get; private set;}
        public Status Status {get; private set;}
        public DateTime RegistrationDate {get; private set;}
        public DateTime UpdateDate {get; private set;}

        private User(
            Guid id,
            NickName? userName = null,
            Name? firstName = null,
            Name? secondName = null,
            LastName? firstLastName = null,
            LastName? secondLastName = null,
            Password? password = null,
            DateTime dateOfBirthday = default,
            Address? address = null,
            Role? userRole = null,
            Status status = Status.Inactive,
            DateTime registrationDate = default,
            DateTime updateDate = default
            ):base(id)
        {
            UserName = userName;
            FirstName = firstName;
            SecondName = secondName;
            FirstLastName = firstLastName;
            SecondLastName = secondLastName;
            Password = password;
            DateOfBirthday = dateOfBirthday == default ? DateTime.MinValue : dateOfBirthday;
            Address = address;
            UserRole = userRole;
            Status = status;
            RegistrationDate = registrationDate;
            UpdateDate = updateDate;
        }

        public static User Create(
            Name firstName,
            Name secondName,
            LastName firstLastName,
            LastName secondLastName,
            Password password,
            DateTime dateOfBirthday,
            Address address,
            Role userRole,
            Status status,
            NickNameService nickNameService)
        {
            var userName = nickNameService.GenerateNickName(firstName, firstLastName);

            var user = new User(
                Guid.NewGuid(),
                userName,
                firstName,
                secondName,
                firstLastName,
                secondLastName,
                password,
                dateOfBirthday,
                address,
                userRole,
                status
            );

            user.RaiseDomainEvent(new UserCreateDomainEvent(user.Id));

            return user;
        }

        public Result Activate(DateTime utcNow)
        {
            if (Status == Status.Active)
            {
                return Result.Failure(UserError.AlreadyActive);
            }

            Status = Status.Active;
            UpdateDate = utcNow;

            return Result.Success();
        }

        public Result Deactivate(DateTime utcNow)
        {
            if (Status == Status.Inactive)
            {
                return Result.Failure(UserError.AlreadyInactive);
            }

            Status = Status.Inactive;
            UpdateDate = utcNow;

            return Result.Success();
        }


    }