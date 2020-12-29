using System;

namespace Domain.Entities
{
    /// <summary>
    /// Identity Field Pattern
    /// </summary>
    public abstract class Entity
    {
        public int Id { get; set; }
    }
}
