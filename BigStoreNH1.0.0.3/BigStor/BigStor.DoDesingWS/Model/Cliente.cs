﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigStore.DoDesignWS.Model
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public TLogin IdTLogin { get; set; }
        public string  NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string  Apellido { get; set; }
        public string  Telefono{ get; set; }
        public string  Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string  DNI { get; set; }
        public string NroTargeta { get; set; }
    }
}