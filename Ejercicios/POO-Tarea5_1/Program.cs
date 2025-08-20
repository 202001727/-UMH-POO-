using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Directorio.Clases;

namespace Directorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            Marcador marcador = new Marcador();
            string nombrecompleto = string.Empty;

            persona.setNombre("Florinda");
            persona.setApellidos("Meza");

            nombrecompleto = persona.getNombreCompleto();

            Console.WriteLine("Persona 1" + nombrecompleto + "Salario" + marcador.getSalario(44 * 4));

            nombrecompleto = persona.getNombreCompleto("Florinda", "Meza");

            Console.WriteLine("Persona 2" + nombrecompleto + "Salario" + marcador.getSalario(35 * 4));

            Console.ReadLine();

        }
    }
}
