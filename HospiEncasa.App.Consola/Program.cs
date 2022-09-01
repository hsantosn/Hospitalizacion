
using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());


        static void Main(string[] args)

        {
            Console.WriteLine("Hello, World!");
            AddPaciente();
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Ruben",
                Apellido = "Blades",
                NumeroTelefono = "213",
                Direccion = "Panama",
                Ciudad = "Ciudad de Panama",
                FechaNacimiento = new DateTime(1948, 07, 16),
                /*Familiar = "Carlos Suarez",
                Enfermera = "Paola",
                Medico = "Albert",
                Historia = "HC-2097",*/
                Genero = Genero.masculino,

            };

            _repoPaciente.AddPaciente(paciente);

        }



    }


}



