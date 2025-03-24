using System;

namespace tp_01
{
	/// <summary>
	/// Description of ProfundidadDeArbolBinario.
	/// </summary>
	public class ProfundidadDeArbolBinario
	{
		
		private ArbolBinario<int> arbol;
		
		
		public ProfundidadDeArbolBinario( ArbolBinario<int> arbol ){
			
			this.arbol = arbol;
			
		}
		
		public int sumaElementosProfundidad(int p){			
			
			Cola<ArbolBinario<int>> cola = new Cola<ArbolBinario<int>>();
			Cola<int> niveles = new Cola<int>();
			
			cola.encolar( this.arbol );
			niveles.encolar( 1 );
			
			int total = 0;
			
			while( !cola.esVacia() ){
			
				ArbolBinario<int> aux = cola.desencolar();
				int nivel = niveles.desencolar();
				
				if( p + 1 == nivel ){
					total += aux.getDatoRaiz();
				}
				
				
				if( aux.getHijoIzquierdo() != null ){
					cola.encolar( aux.getHijoIzquierdo() );
					niveles.encolar( nivel + 1 );
				}
				
				if( aux.getHijoDerecho() != null ){
					cola.encolar( aux.getHijoDerecho() );
					niveles.encolar( nivel + 1 );
				}
				
			}
			
			return total;
		}
		
	}
}
