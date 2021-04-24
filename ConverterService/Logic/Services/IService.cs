using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConverterService.Logic.Services
{
    interface IService<T, E>
    {
        public T DoService(E entity);
    }
}
