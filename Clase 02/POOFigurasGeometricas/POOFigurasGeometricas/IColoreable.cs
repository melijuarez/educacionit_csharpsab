using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOFigurasGeometricas
{
    public interface IColoreable
    {
        int Color { get; set; }

        void Pintar(int Color);
    }
}
