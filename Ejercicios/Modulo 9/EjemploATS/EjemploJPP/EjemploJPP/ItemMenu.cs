///////////////////////////////////////////////////////////
//  ItemMenu.cs
//  Implementation of the Class ItemMenu
//  Generated by Enterprise Architect
//  Created on:      17-Oct-2010 08:06:15 a.m.
///////////////////////////////////////////////////////////



namespace EjemploJPP {
	public class ItemMenu {

		private string Descripcion;
		public string descripcion{
			//read property
            get { return Descripcion; }
			//write property
			set{Descripcion = value;}
		}
		private int ItemID;
		public int itemID{
			//read property
			get{return ItemID;}
			//write property
			set{ItemID = value;}
		}
		private decimal precio{
			//read property
			get{return Precio;}
			//write property
			set{Precio = value;}
		}
		private decimal Precio;

		public ItemMenu(){

		}

		~ItemMenu(){

		}

		public virtual void Dispose(){

		}

	}//end ItemMenu

}//end namespace EjemploJPP