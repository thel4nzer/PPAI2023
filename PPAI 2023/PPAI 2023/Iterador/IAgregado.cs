using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Iterador
{
    internal interface IAgregado<T>
    {
        IIterador<T> crearIterador(List<T> elementos, List<Func<T, bool>> filtros);
    }
}
