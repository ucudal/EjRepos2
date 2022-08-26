//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;
using System.Collections.Generic;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            var train = new Train("Coco"); //Creo el tren Coco para probar :)
            train.StartEngines();
            Console.WriteLine("Hello World!");
            List<Train> trenes = new List<Train>(); //Creo una lista de Train para poder instanciar 100 trenes

            /*for (int i = 0; i < 100; i++) //Bucle para agregar 100 trenes como loco
            {
                trenes.Add(new Train($"Tren{i}")); //Agrego trenes cuyo nombre se vaya modificando a medida que sube el bucle
            }
            Console.WriteLine(string.Join(", ",trenes)); //Un writeline para comprobar que tenga los trenes
            Console.WriteLine(Train.count); //Imprime 101 trenes porque son 100 + Coco*/

            /*for (int i = 0; i < 10000000; i++) //Bucle para crear 10 millones de instancias. Tarda mucho en terminar de correr!!!
            {
                trenes.Add(new Train($"Tren{i}"));
            }
            Console.WriteLine(string.Join(", ",trenes));*/

            var t1 = new Train("Last Train To London"); //Creo las instancias t1, t2 y t3
            var t2 = new Train("Last Train To London");
            var t3 = new Train("Runaway Train");
            Console.WriteLine(t1 == t2); //Retorna False porque son dos instancias diferentes. No es lo mismo que si hiciera var t2 = t1
            t2 = t1;
            Console.WriteLine(t1 == t2); //Ahora si retorna True, porque t2 apunta a la dirección de t1
            Console.WriteLine(t2 == t3); //Retorna false porque son diferentes
        }
    }
}