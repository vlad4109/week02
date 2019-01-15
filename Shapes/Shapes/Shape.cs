using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public int width { get;  }

        public int height { get; set; }

        public abstract double CalculateSurface();

        //public abstract string Figure(); ---- puteam sa las aici metoda abstracta si sa dau override
        //la metoda Figure() in rectangle si triangle dar problema cere ca Shape.cs sa contina o
        //singura metoda abstracta asa ca am adaugat interfata IFigure care va fi mostenita de catre
        //clasele Rectangle si Triangle

        public virtual void Print()
        {

        }
    }
}
