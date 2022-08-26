//--------------------------------------------------------------------------------
// <copyright file="Train.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace ClassLibrary
{
    /// <summary>
    /// Esta clase representa un tren muy básico.
    /// </summary>
    public class Train
    {
        /// <summary>
        /// Obtiene un valor que indica si las maquinas del tren han sido encendidas o no.
        /// </summary>
        /// <value><c>true</c> si las máquinas fueron encendidas, <c>false</c> en caso contrario.</value>
        public bool IsEngineStarted { get; private set; }
        public static int count = 0; //Creo la variable de clase count para contar las veces que se crea una instancia y la hago publica para poder accederla desde el main
        string Identificador {get; set;}

        /// <summary>
        /// Enciende las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser encendidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StartEngines()
        {
            if (this.IsEngineStarted)
            {
                Console.Write("The engines are already running");
                return false;
            }

            this.IsEngineStarted = true;
            Console.Write("Engines on");
            return true;
        }

        /// <summary>
        /// Detiene las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser detenidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StopEngines()
        {
            if (this.IsEngineStarted)
            {
                this.IsEngineStarted = false;
                Console.Write("Engines off");
                return true;
            }

            Console.Write("The engines are already stopped");
            return this.IsEngineStarted;
        }
        public Train(string identificador) //Agrego el parametro del identificador
        {
            count++;//Agrega +1 al contador
            this.Identificador = identificador;
            Console.WriteLine($"CONSTRUCTOR: Creando tren {Identificador} N° {count}");//Msj para saber cuando se ejecuta el constructor
        }
        ~Train()
        {
            Console.WriteLine($"DESTRUCTOR: Borrando tren {this.Identificador} N° {count}");//Msj para saber cuando se ejecuta el destructor
            count--; //Se resta 1 del contador
        } 
        public override string ToString()
        {
            return $"\n Tren {this.Identificador} - Cantidad de trenes actual {count}.";
        }
    }
}