using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Iterador
{
    public interface IIteradorSinFiltro<T>
    {
        void primero();

        T actual();

        void siguiente();

        bool haTerminado();
    }
}
