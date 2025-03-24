using System;

namespace tp_01
{
	/// <summary>
	/// Description of RedBinariaLlena.
	/// </summary>
	public class RedBinariaLlena
	{

		private ArbolBinario<int> arbol;
		
		
		public RedBinariaLlena( ArbolBinario<int> arbol ){
			
			this.arbol = arbol;
			
			if( ! this.isLleno() ){
				Console.WriteLine("El arbol no es un arbol lleno" );
			}
		}
		
		private bool isLleno(){
			
			int hojas = this.arbol.contarHojas();
			
			int h = 1 + this.arbol.profundidad();
			
			double lleno = Math.Pow( 2, ( h -1 ) );
				
			return lleno == hojas;	
			
		}
		
		
		public int retardoReenvio(){
					
			return this.retardoReenvio( this.arbol, 0 );
			
		}
		
		
		private int retardoReenvio( ArbolBinario<int> arbol, int retardo ){
			
			int retardo_actual = arbol.getDatoRaiz() + retardo;
			
			if( arbol.esHoja() ){
				return retardo_actual;
			}
			
			int izq = 0; 
			int der = 0;
			
			if( arbol.getHijoIzquierdo() != null ){
				izq = this.retardoReenvio( arbol.getHijoIzquierdo(), retardo_actual );
			}
			
			if( arbol.getHijoDerecho() != null ){
				der = this.retardoReenvio( arbol.getHijoDerecho(), retardo_actual );
			}
				
			return Math.Max( izq, der );
			
		}
		
	}
}
