///////////////////////////////////////////////////////////
//  Pedido.cs
//  Implementation of the Class Pedido
//  Generated by Enterprise Architect
//  Created on:      19-Oct-2010 02:26:58 p.m.
//  Original author: Victor
///////////////////////////////////////////////////////////




using JPP3;
namespace JPP3 {
	public class Pedido {

		private string Estado;
		private string FechaDescarga;
		private string FechaPedido;
		public ItemMenu [] ListaItem = new ItemMenu[5];
		public int Longitud = 0;
		private Abonado MAbonado;
		private int PedidoID;

        public Pedido()
        {

        }

        ~Pedido()
        {

        }

        public virtual void Dispose()
        {

        }



        public void agregarItem(ItemMenu pItem)
        {
            if (Longitud == 0)
                ListaItem[0] = pItem;
            else
                ListaItem[Longitud] = pItem;
            Longitud += 1;
        }

        public void Calcular_Pedido()
        {
			
        }

        public string estado
        {
            //read property
            get { return Estado; }
            //write property
            set { Estado = value; }
        }

        public string fechaDescarga
        {
            //read property
            get { return FechaDescarga; }
            //write property
            set { FechaDescarga = value; }
        }

        public string fechaPedido
        {
            //read property
            get { return FechaPedido; }
            //write property
            set { FechaPedido = value; }
        }

        public int pedidoID
        {
            //read property
            get { return PedidoID; }
            //write property
            set { PedidoID = value; }
        }

        public Abonado mAbonado
        {
            get { return MAbonado; }
            set { MAbonado = value; }
        }
    

		/* Begin - EA generated code for StateMachine */


		private enum StateType : int
		{
			ProcesarPedido_Entregado,
			ProcesarPedido_Iniciado,
			ProcesarPedido_Encurso,
			ProcesarPedido_Encolado,
			ProcesarPedido_Finalizado,
			ProcesarPedido_Abortado,
			ST_NOSTATE
		}
		private enum TransitionType : int
		{
			ProcesarPedido_Iniciado_to_ProcesarPedido_Encurso,
			ProcesarPedido_Encurso_to_ProcesarPedido_Encolado,
			ProcesarPedido_Encurso_to_ProcesarPedido_Encurso,
			ProcesarPedido_Encolado_to_ProcesarPedido_Entregado,
			ProcesarPedido_Encolado_to_ProcesarPedido_Abortado,
			TT_NOTRANSITION
		}
		private enum CommandType : int 
		{
			Do, 
			Entry, 
			Exit 
		}
		private StateType currState;
		private StateType nextState;
		private TransitionType currTransition;
		private bool transcend;
		private StateType ProcesarPedido_history;

		private void procesarPedido_Entregado(CommandType command)
		{
			switch(command)
			{
				case CommandType.Do:
				{
					// State's Transitions
					nextState = StateType.ST_NOSTATE/*Final State*/;
					break;
				}
				default:
				{
					break;
				}
			}
		}

		private void procesarPedido_Iniciado(CommandType command)
		{
    	}

		private void procesarPedido_Encurso(CommandType command)
		{
		}

		private void procesarPedido_Encolado(CommandType command)
		{
		}

		private void procesarPedido_Finalizado(CommandType command)
		{
        }

		private void procesarPedido_Abortado(CommandType command)
		{
		}

		private void StatesProc(StateType currState, CommandType command)
		{
			switch(currState)
			{
					case StateType.ProcesarPedido_Entregado:
				{
					procesarPedido_Entregado(command);
					break;
				}

				case StateType.ProcesarPedido_Iniciado:
				{
					procesarPedido_Iniciado(command);
					break;
				}

				case StateType.ProcesarPedido_Encurso:
				{
					procesarPedido_Encurso(command);
					break;
				}

				case StateType.ProcesarPedido_Encolado:
				{
					procesarPedido_Encolado(command);
					break;
				}

				case StateType.ProcesarPedido_Finalizado:
				{
					procesarPedido_Finalizado(command);
					break;
				}

				case StateType.ProcesarPedido_Abortado:
				{
					procesarPedido_Abortado(command);
					break;
				}
				default:
					break;
			}
		}
		private void TransitionsProc(TransitionType transition)
		{
			switch(transition)
			{
					case TransitionType.ProcesarPedido_Iniciado_to_ProcesarPedido_Encurso:
				{
					estado = "encurso";
					break;
				}
				case TransitionType.ProcesarPedido_Encurso_to_ProcesarPedido_Encolado:
				{
					estado = "encolado";
					break;
				}
				case TransitionType.ProcesarPedido_Encurso_to_ProcesarPedido_Encurso:
				{
					estado = "encurso";
					break;
				}
				case TransitionType.ProcesarPedido_Encolado_to_ProcesarPedido_Entregado:
				{
					estado = "entregado";
					break;
				}
				case TransitionType.ProcesarPedido_Encolado_to_ProcesarPedido_Abortado:
				{
					estado = "abortado";
					break;
				}
					default:
					break;
			}
		}

		public void initializeStateMachine()
		{ 
			currState = StateType.ProcesarPedido_Iniciado;
			nextState = StateType.ST_NOSTATE;
			currTransition = TransitionType.TT_NOTRANSITION;
            estado = "iniciado";
		}

       	    
        public void seleccionarItem()
        {
            if (currState == StateType.ProcesarPedido_Iniciado)
                this.TransitionsProc(TransitionType.ProcesarPedido_Iniciado_to_ProcesarPedido_Encurso);
            else
                this.TransitionsProc(TransitionType.ProcesarPedido_Encurso_to_ProcesarPedido_Encurso);
        }
        
        public void entregarPedido()
        {
            this.TransitionsProc(TransitionType.ProcesarPedido_Encolado_to_ProcesarPedido_Entregado);
        }

        public void cerrarPedido()
        {
            this.TransitionsProc(TransitionType.ProcesarPedido_Encurso_to_ProcesarPedido_Encolado);
        }

        public void abortarPedido()
        {
            this.TransitionsProc(TransitionType.ProcesarPedido_Encolado_to_ProcesarPedido_Abortado);
        }

		private void runStateMachine()
		{
			while(true)
			{
				if ( currState == StateType.ST_NOSTATE )
				{
					break ; 
				}
			
				currTransition = TransitionType.TT_NOTRANSITION;
				StatesProc(currState, CommandType.Do);
				// and then check if there is any valid transition assigned after the do behavior
				if ( nextState == StateType.ST_NOSTATE)
				{
					break;
				}
			
				if ( currTransition != TransitionType.TT_NOTRANSITION )
				{
					TransitionsProc( currTransition );
				}
				if ( currState != nextState)
				{
					StatesProc(currState, CommandType.Exit);
					StatesProc(nextState, CommandType.Entry);
					currState = nextState ;
				}
			}
		}

		/* End - EA generated code for StateMachine */

	}//end Pedido

}//end namespace JPP3