﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenKarolPalma.Clases
{
    class Alumno
    {


        public string alumno_rne { get; set; }
        public string alumno_nombre1 { get; set; }
        public string alumno_nombre2 { get; set; }
        public string alumno_ape1 { get; set; }
        public string alumno_ape2 { get; set; }
        public string alumno_genero { get; set; }
        public string alumno_fnac { get; set; }

        public string nombrec => $"{alumno_nombre1} {alumno_nombre2} {alumno_ape1} {alumno_ape2}";
    }
}
