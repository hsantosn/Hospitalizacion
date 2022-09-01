using System;

namespace HospiEnCasa.App.Dominio
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroTelefono { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        /*public string Familiar { get; set; }
        public string Enfermera { get; set; }
        public string Medico { get; set; }
        public string Historia { get; set; }*/
        public Genero Genero { get; set; }

    }

}