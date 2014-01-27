///////////////////////////////////////////////////////////
//  GestorPedido.cs
//  Implementation of the Class GestorPedido
//  Generated by Enterprise Architect
//  Created on:      17-Oct-2010 10:00:37 p.m.
//  Original author: Victor
///////////////////////////////////////////////////////////


using System;

using JPP2;
namespace JPP2 {
	public class GestorPedido {

		public Pedido mPedido;
        private ItemMenu mItem;
        

		public GestorPedido(){

		}

		~GestorPedido(){

		}

		public virtual void Dispose(){

		}

		public void agregarItem(){
            int opcion;
            Console.Clear();
            Console.WriteLine("Agregar Items al Pedido");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Seleccionar");
            Console.WriteLine("Agregar Item: 1");
            Console.WriteLine("Salir: 0");
            Console.WriteLine(" ");
            Console.WriteLine("Cantidad de Itemes: " + mPedido.Longitud);

            Console.Write("Opcion:");
            opcion = Convert.ToInt32(Console.ReadLine());

            while (opcion != 0)
            {

                if (opcion == 1)
                {
                    ItemMenu mItem = new ItemMenu();
                    Console.Clear();
                    Console.WriteLine("Agregar Item");
                    Console.Write("Descripcion: ");
                    mItem.descripcion = Console.ReadLine();
                    Console.Write("ID del Item: ");
                    mItem.itemID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Precio: ");
                    mItem.precio = Convert.ToDecimal(Console.ReadLine());
                    mPedido.agregarItem(mItem);
                    
                }

                Console.Clear();
                Console.WriteLine("Agregar Items al Pedido");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Seleccionar");
                Console.WriteLine("Agregar Item: 1");
                Console.WriteLine("Salir: 0");
                Console.WriteLine(" ");
                Console.WriteLine("Cantidad de Itemes: " + mPedido.Longitud);

                Console.Write("Opcion:");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
		}

		public void crearItem(){
            ItemMenu unItem = new ItemMenu();
            unItem.descripcion = "Sin Descripcion";
            unItem.itemID = 0;
            unItem.precio = 0;
		}

		public void crearPedido(){
            Pedido unPedido = new Pedido();
            unPedido.estado = 0;
            unPedido.fechaDescarga = "SinFecha";
            unPedido.fechaPedido = "SinFecha";
            this.crearItem();
            mPedido = unPedido;

		}

		public void llenarPedido(Abonado pAbonado){
            Console.Write("Ingresar ID del Pedido:");
            mPedido.pedidoID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresar Fecha de Hoy:");
            mPedido.fechaPedido = Console.ReadLine();
            this.asignarAbonado(pAbonado);
            this.agregarItem();

  		}

		public void mostrarPedido(){
            Console.Clear();
            Console.WriteLine("Datos del Pedido");
            Console.WriteLine("-----------------");
            Console.WriteLine("ID del Pedido: " + mPedido.pedidoID);
            Console.WriteLine("Fecha del Pedido: " + mPedido.fechaPedido);
            Console.WriteLine("Abonado: " + mPedido.mAbonado.nombre);
            for (int i = 0; i < mPedido.Longitud; i++ )
                Console.WriteLine("Item: " + mPedido.ListaItem[i].descripcion);  
		}

        public void asignarAbonado(Abonado pAbonado)
        {
            if (pAbonado == null)
            {
                Console.WriteLine("Abonado relacionado: No hay Abonado");
            }
            else
            {
                mPedido.mAbonado = pAbonado;
            }
        }
	}//end GestorPedido

}//end namespace JPP2