///////////////////////////////////////////////////////////
//  Catalogo.cs
//  Implementation of the Class Catalogo
//  Generated by Enterprise Architect
//  Created on:      14-oct-2010 10:10:51 p.m.
///////////////////////////////////////////////////////////




public class Catalogo {

	private string FechaFinVigencia;
	private string FechaInicioVigenacia;
	private int ID;
	
	public string fechaFinVigencia{
		//read property
		get{return FechaFinVigencia;}
		//write property
        set { FechaFinVigencia = value; }
	}
	public string fechaInicioVigencia{
		//read property
		get{return fechaInicioVigencia;}
		//write property
		set{fechaInicioVigencia = value;}
	}
	public int id{
		//read property
		get{return ID;}
		//write property
		set{ID = value;}
	}
	public ItemMenu juego;
	public ItemMenu m_ItemMenu;

	public Catalogo(){

	}

	~Catalogo(){

	}

	public virtual void Dispose(){

	}

	public void Buscar_Juego(){

	}

}//end Catalogo