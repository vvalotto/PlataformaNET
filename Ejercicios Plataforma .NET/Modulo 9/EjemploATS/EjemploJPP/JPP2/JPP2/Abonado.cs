///////////////////////////////////////////////////////////
//  Abonado.cs
//  Implementation of the Class Abonado
//  Generated by Enterprise Architect
//  Created on:      17-Oct-2010 10:00:37 p.m.
//  Original author: Victor
///////////////////////////////////////////////////////////




namespace JPP2 {
	public class Abonado {

		
		private int AbonadoID;
        private string Nombre;
		private string Sector;
		private string Terminal;

		public Abonado(){

		}

		~Abonado(){

		}

		public virtual void Dispose(){

		}

        public int abonadoID
        {
            //read property
            get { return AbonadoID; }
            //write property
            set { AbonadoID = value; }
        }

        public string nombre
        {
            //read property
            get { return Nombre; }
            //write property
            set { Nombre = value; }
        }

        public string sector
        {
            //read property
            get { return Sector; }
            //write property
            set { Sector = value; }
        }
        public string terminal
        {
            //read property
            get { return Terminal; }
            //write property
            set { Terminal = value; }
        }

	}//end Abonado

}//end namespace JPP2