///////////////////////////////////////////////////////////
//  GestorAbonado.cs
//  Implementation of the Class GestorAbonado
//  Generated by Enterprise Architect
//  Created on:      19-Oct-2010 09:01:20 a.m.
//  Original author: Victor
///////////////////////////////////////////////////////////

using System;
using JPP3;
namespace JPP3 {
    public class GestorAbonado
    {

        public Abonado mAbonado;

        public GestorAbonado()
        {

        }

        ~GestorAbonado()
        {

        }

        public virtual void Dispose()
        {

        }

        public void crearAbonado()
        {
            Abonado unAbonado = new Abonado();
            unAbonado.nombre = "Sin Nombre";
            unAbonado.sector = "Sin Sector";
            unAbonado.terminal = "Sin Terminal";
            unAbonado.abonadoID = 0;
            mAbonado = unAbonado;
        }

        public void llenarAbonado()
        {
            Console.Write("Ingresar nombre:");
            mAbonado.nombre = Console.ReadLine();
            Console.Write("Ingresar Sector:");
            mAbonado.sector = Console.ReadLine();
            Console.Write("Ingresar Terminal:");
            mAbonado.terminal = Console.ReadLine();
            Console.Write("Ingresar ID:");
            mAbonado.abonadoID = Convert.ToInt32(Console.ReadLine());

        }

        public void mostrarAbonado()
        {
            Console.Clear();
            Console.WriteLine("Datos del Abonado");
            Console.WriteLine("-----------------");
            Console.WriteLine("Nombre: " + mAbonado.nombre);
            Console.WriteLine("Sector: " + mAbonado.sector);
            Console.WriteLine("Terminal: " + mAbonado.terminal);
            Console.WriteLine("ID: " + mAbonado.abonadoID);
            Console.WriteLine();
            Console.WriteLine("Un tecla para continuar");
            Console.Read();
        }

    }//end GestorAbonado
}//end namespace JPP3