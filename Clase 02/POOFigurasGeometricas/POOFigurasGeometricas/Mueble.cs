using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOFigurasGeometricas
{
    public class Mueble : IColoreable
    {
        private const int TELAROJA = 0;

        private const int COLORAMARILLO = 0;

        public readonly int Tela = TELAROJA;
        public Mueble()
        {
            Color = COLORAMARILLO;
            Tela = TELAROJA;
        }
        public Mueble(int color)
        {
            Color = color;
            Tela = TELAROJA;
        }

        public Mueble(int color,int tela)
        {
            Color = color;
            Tela = tela;
        }

        public void CambiarTela(int tela)
        {
            //No puedo porque Tela es readonly
            //Tela = tela;
        }

        public int Color { get; set; }

        public void Pintar(int Color)
        {
            this.Color = Color;
        }
    }
}
