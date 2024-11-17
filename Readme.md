```Usuarios.Domain
│
├── Aggregates
│   └── UserAggregate
│       ├── User.cs
│       ├── UserRole.cs
│       └── Address.cs (si pertenece exclusivamente al agregado)
│
├── ValueObjects
│   ├── Email.cs
│   ├── Password.cs
│   └── FullName.cs
│
├── Entities
│   └── Order.cs
│
├── Repositories
│   └── IUserRepository.cs
│
└── Services
└── UserService.cs
```
