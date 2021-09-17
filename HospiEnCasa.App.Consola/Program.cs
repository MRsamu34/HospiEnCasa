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
            Console.WriteLine("Hello World! EF!");
            //AddPaciente();
            //BuscarPaciente(1);
            //UpdatePaciente(paciente);
            //DeletePaciente(2);

        }
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Victor",
                Apellidos = "Guarin",
                NumeroTelefono = "5316042",
                Genero = Genero.Masculino,
                Direccion = "Calle 29A Abreo",
                Longitud = 5.07062F,
                Latitud = -75.52290F,
                Ciudad = "Rionegro",
                FechaNacimiento = new DateTime(2003, 05, 16)
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre + " " + paciente.Apellidos);
        }
        //private static void UpdatePaciente(Paciente paciente)
        //{
        //  _repoPaciente.UpdatePaciente(paciente);
        //}
        private static void DeletePaciente(int idPaciente)
        {
            _repoPaciente.DeletePaciente(idPaciente);
        }

    }
}
