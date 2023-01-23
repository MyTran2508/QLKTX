using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.Services
{
    public abstract class ServiceTemplate<T>
    {
        public abstract void Insert(T entity);

        public abstract void Update(T entity);

        public abstract void Remove(T entity);

    }
}
