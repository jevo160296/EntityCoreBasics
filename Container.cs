using Microsoft.EntityFrameworkCore;

namespace EntityCoreBasics
{
    public abstract class Container<T>
        where T : DbContext
    {
        public T Context
        {
            get;
            protected set;
        }
    }
}
