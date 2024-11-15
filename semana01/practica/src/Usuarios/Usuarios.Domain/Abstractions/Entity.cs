namespace Usuarios.Domain.Abstractions;

    public abstract class Entity
    {
        private readonly List<IDomainEvent> _domainEvents = new();
        protected Entity(){}
        public Guid Id {get; init;}

        public void ClearDomainEvents(){
            _domainEvents.Clear();
        }

    }
