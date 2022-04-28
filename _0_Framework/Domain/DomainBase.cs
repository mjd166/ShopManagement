using System;

namespace _0_Framework.Domain
{
    public class DomainBase<T>
    {
        public T Id { get; set; }
        public DateTime CreationDate { get; set; }

        public DomainBase()
        {
            CreationDate = DateTime.Now;
        }
    }
}
