using System;

namespace WP.MvcIntermediario.Dominio.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        public abstract bool EhValido();
    }
}
