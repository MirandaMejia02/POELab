using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    internal class Tiempo
    {
        public enum Días
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
        };

        public enum Horas
        { One = 1, Two, Three, Four, Five, Seven, 
        Eight, Nine, };

        public enum Horario
            { AM,PM};


    }
}
