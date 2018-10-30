﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConsultorio
{
    public class Paciente //Es publico para que se pueda utilizar en otros lados
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Edad { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public string EnfermedadesCronicas { get; set; }
    }
}
