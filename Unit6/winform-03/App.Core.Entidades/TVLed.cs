using App.Core.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Entidades
{
    public class TVLed
    {
        public string Pantalla { get; private set; }

        /*
        public void Imprimir(Profesor profesor)
        {
            Pantalla = profesor.Nombre;
        }

        public void Imprimir(Alumno alumno)
        {
            Pantalla = alumno.Nombre;
        }
        */

        //public void Imprimir(PersonaBase persona)
        //{
        //    Pantalla = persona.Nombre;
        //}


        public void Imprimir(IConNombre objConNombre)
        {
            Pantalla = objConNombre.Nombre;
        }

    }
}
