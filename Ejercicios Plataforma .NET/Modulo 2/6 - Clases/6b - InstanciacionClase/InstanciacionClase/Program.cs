﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstanciacionClase
{
    class Program
    {

        //Constructores
        public Program()
        {
        }

        public Program (string nuevoNombre)
        {
            this._nombreValue = nuevoNombre;
        }

        // Miembros campo y propiedad
        private string _nombreValue = string.Empty;
        public string nombre
        {
            get
            {
                return _nombreValue;
            }
            set
            {
                _nombreValue = value;
            }
        }

        public void Saludar()
        {
            Console.WriteLine("Bienvenidos a Paraná");
        }

        public void Saludar(string slogan)
        {
            Console.WriteLine(slogan);
        }

        public void Saludar(string slogan, int temporada)
        {
            Console.WriteLine (slogan + " - " + temporada.ToString());
        }

        public string Saludar(int valor)
        {
            return "Este año " + valor.ToString() + " será el mejor.";
        }

        static void Main(string[] args)
        {
            Program p = new Program("Alejo");
            Console.WriteLine(p.nombre);
            Console.ReadLine();

            //Ejemplo de Sobrecarga
            p.nombre = "pepe";
            p.Saludar();
            p.Saludar("Ciudad Paisaje");
            p.Saludar("Pase la mejor temporada", 2011);
            Console.WriteLine(p.Saludar(2011));
            Console.ReadLine();
        }
    }
}