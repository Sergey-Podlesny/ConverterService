using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagnitudeConverter.Logic.Services
{
    public interface IService<T>
    {
        public void DoService(T entity);
    }
}
