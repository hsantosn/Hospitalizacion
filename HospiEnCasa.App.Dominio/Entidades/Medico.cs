using System;

namespace HospiEnCasa.App.Dominio
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroTelefono { get; set; }
        public Genero Genero { get; set; }
    }

}