///////////////////////////////////////////////////////////
//  GestorIU.cs
//  Implementation of the Class GestorIU
//  Generated by Enterprise Architect
//  Created on:      17-Oct-2010 08:16:04 a.m.
//  Original author: Victor
///////////////////////////////////////////////////////////


using System;

namespace EjemploJPP {
	public class GestorIU {

		public GestorIU(){

		}

		~GestorIU(){

		}

		public virtual void Dispose(){

		}

		public void ingresarAbonado(){

                GestorAbonado unGestor = new GestorAbonado();
                Console.Clear();
                Console.WriteLine("Crear un Abonado");
                Console.WriteLine("----------------");
                unGestor.crearAbonado();
                unGestor.mostrarAbonado();
                Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Ingresar un Abonado");
                Console.WriteLine("----------------");
                unGestor.llenarAbonado();
                unGestor.mostrarAbonado();
                Console.ReadLine();
		}

		public void ingresarPedido(){

		}

        public void SeleccionarEntidad()
        {
            int opcion;
            //Muestra Menu Inicial
            Console.Clear();
            Console.WriteLine("Ejemplo de Aplicacion");
            Console.WriteLine("---------------------");

            Console.WriteLine("Seleccionar");
            Console.WriteLine("Tratar Abonado: 1");
            Console.WriteLine("Tratar Pedido: 2");
            Console.WriteLine("Salir: 0");

            Console.Write("Opcion:");
            opcion = Convert.ToInt32(Console.ReadLine());

            while (opcion != 0)
            {

                if (opcion == 1)
                {
                    //Console.WriteLine("Abonado");
                    ingresarAbonado();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Pedido");
                    Console.ReadLine();
                }
                Console.Clear();
                Console.WriteLine("Ejemplo de Aplicacion");
                Console.WriteLine("---------------------");

                Console.WriteLine("Seleccionar");
                Console.WriteLine("Tratar Abonado: 1");
                Console.WriteLine("Tratar Pedido: 2");
                Console.WriteLine("Salir: 0");

                Console.Write("Opcion:");
                opcion = Convert.ToInt32(Console.ReadLine());
            }            
        }
	}//end GestorIU

}//end namespace EjemploJPP