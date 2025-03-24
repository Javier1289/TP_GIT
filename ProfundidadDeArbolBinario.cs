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
		
		
		public ArbolBinario<int> nuevo( ArbolBinario<int> arbol ){
			
			ArbolBinario<int> aux = arbol;
			
			if( arbol.getHijoIzquierdo() != null ) {
				aux.agregarHijoIzquierdo( this.nuevo( aux, arbol.getHijoIzquierdo() ) );
			}
				
			if( arbol.getHijoDerecho() != null ) {
				aux.agregarHijoDerecho( this.nuevo( null, arbol.getHijoDerecho() ) );
			}
			
			return aux;
		}
		
		
		private ArbolBinario<int> nuevo( ArbolBinario<int> a1, ArbolBinario<int> a2 ){
			
			int dato = a2.getDatoRaiz();
			if( a1 != null ){
				dato += a1.getDatoRaiz();
			}
			
			ArbolBinario<int> aux = new ArbolBinario<int>( dato );
			
			if( a2.getHijoIzquierdo() != null ) {				
				aux.agregarHijoIzquierdo( this.nuevo( a2, a2.getHijoIzquierdo() ) );
			}
				
			if( a2.getHijoDerecho() != null ) {
				aux.agregarHijoDerecho( this.nuevo( null, a2.getHijoDerecho() ) );
			}
			
			return aux;
						
		}
		
//		public void nuevo( ArbolBinario<int> arbol ){
//			
//			Cola<ArbolBinario<int>> cola = new Cola<ArbolBinario<int>>();
//			Cola<ArbolBinario<int>> cola2 = new Cola<ArbolBinario<int>>();			
//			
//			ArbolBinario<int> n = new ArbolBinario<int>(arbol.getDatoRaiz());
//			
//			cola.encolar( arbol );
////			cola2.encolar( n );
//						
//			while( !cola.esVacia() ){
//			
//				ArbolBinario<int> aux = cola.desencolar();
//								
//				if( aux.getHijoIzquierdo() != null ){
//					cola.encolar(aux.getHijoIzquierdo() );
//					cola2.encolar( new ArbolBinario<int>( aux.getDatoRaiz() + aux.getHijoIzquierdo().getDatoRaiz() ) );
//					n.agregarHijoIzquierdo( cola2.desencolar() );
//				}
//				
//				if( aux.getHijoDerecho() != null ){
//					cola.encolar( aux.getHijoDerecho() );
//					cola2.encolar( aux.getHijoDerecho() );
//					n.agregarHijoDerecho( cola2.desencolar() );
//				}
//				
//			}
//						
//			n.recorridoPorNiveles();
//			
//		}
		
		

		
		
	
		
	}
}
