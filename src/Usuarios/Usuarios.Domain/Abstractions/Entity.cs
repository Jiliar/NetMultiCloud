namespace Usuarios.Domain.Abstractions;

    public abstract class Entity
    {
        private readonly List<IDomainEvent> _domainEvents = new();
        protected Entity(){}
        protected Entity(Guid Id){ this.Id = Id; }
        public Guid Id {get; init;}

        public void ClearDomainEvents(){
            _domainEvents.Clear();
        }

        public void RaiseDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }
        
        public IReadOnlyList<IDomainEvent> GetDomainEvents()
        {
            return _domainEvents.ToList();
        }

    }
