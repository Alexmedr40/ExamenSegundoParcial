/*    Crear una clase base llamada MaterialBibliografico con propiedades y métodos comunes para todos los materiales bibliográficos. 
 *    Esta clase debe incluir:
        Un título.
        Un autor.
        Un método para mostrar información del material.

    Crear clases derivadas de MaterialBibliografico, como Libro y Revista. Cada clase derivada debe:
        Incluir propiedades adicionales específicas, como numeroDePaginas para Libro y numeroDeEdicion para Revista.
        Implementar un método para mostrar información detallada que sobrescriba el método de la clase base.

    Implementar una clase Biblioteca que gestione una colección de materiales bibliográficos. Esta clase debe:
        Permitir agregar nuevos materiales.
        Mostrar la información de todos los materiales almacenados.*/

using System;
using System.Collections.Generic;
using System.Data;

namespace ExamenSegundoParcial
{
    public class MaterialBibliografico
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
        }
    }

    public class Libro : MaterialBibliografico
    {
        public int NumeroDePaginas { get; set; }

        public void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Número de páginas: {NumeroDePaginas}");
        }
    }

    public class Revista : MaterialBibliografico
    {
        public int NumeroDeEdicion { get; set; }

        public void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Número de edición: {NumeroDeEdicion}");
        }
    }

    public class Biblioteca
    {
        private MaterialBibliografico materiales = new MaterialBibliografico();

        public void AgregarMaterial(MaterialBibliografico material)
        {
            
        }

        public void MostrarInformacionMateriales()
        {
            
        }
    }
}