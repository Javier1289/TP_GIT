using System;

namespace tp_01
{
	public class ArbolBinario<T>
	{
		
		private T dato;
		private ArbolBinario<T> hijoIzquierdo;
		private ArbolBinario<T> hijoDerecho;
	
		
		public ArbolBinario(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public ArbolBinario<T> getHijoIzquierdo() {
			return this.hijoIzquierdo;
		}
	
		public ArbolBinario<T> getHijoDerecho() {
			return this.hijoDerecho;
		}
	
		public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
			this.hijoIzquierdo=hijo;
		}
	
		public void agregarHijoDerecho(ArbolBinario<T> hijo) {
			this.hijoDerecho=hijo;
		}
	
		public void eliminarHijoIzquierdo() {
			this.hijoIzquierdo=null;
		}
	
		public void eliminarHijoDerecho() {
			this.hijoDerecho=null;
		}
	
		public bool esHoja() {
			return this.hijoIzquierdo==null && this.hijoDerecho==null;
		}
		
		public void inorden() {
			
			if( this.getHijoIzquierdo() != null ){
				this.getHijoIzquierdo().inorden();
			}
			
			Console.WriteLine( this.getDatoRaiz() );
			
			if( this.getHijoDerecho() != null ){
				this.getHijoDerecho().inorden();
			}
			
		}
		
		public void preorden() {
	
			Console.WriteLine( this.getDatoRaiz() );
			
			if( this.getHijoIzquierdo() != null ){
				this.getHijoIzquierdo().preorden();
			}
			
			
			if( this.getHijoDerecho() != null ){
				this.getHijoDerecho().preorden();
			}
			
		}
		
		public void postorden() {
			
			if( this.getHijoIzquierdo() != null ){			
				this.getHijoIzquierdo().postorden();				
			}			
			
			if( this.getHijoDerecho() != null ){
				this.getHijoDerecho().postorden();
			}
			
			Console.WriteLine( this.getDatoRaiz() );
		}
		
		public void recorridoPorNiveles() {
			
			Cola<ArbolBinario<T>> cola = new Cola<ArbolBinario<T>>();
			Cola<int> niveles = new Cola<int>();			

			cola.encolar( this );
			niveles.encolar( 1 );
			
			while( !cola.esVacia() ){
				
				ArbolBinario<T> aux = cola.desencolar();
				int nivel = niveles.desencolar();
				
				Console.Write(nivel);
				Console.Write( " ===> ");
				
				Console.WriteLine( aux.getDatoRaiz());
				
				if( aux.getHijoIzquierdo() != null ){
					cola.encolar( aux.getHijoIzquierdo() );
					niveles.encolar( nivel + 1);
				}
				
				if( aux.getHijoDerecho() != null ){
					cola.encolar( aux.getHijoDerecho() );
					niveles.encolar( nivel + 1);
				}

			}
			
		}
	
		public int contarHojas() {
			int hojas = 0;
			if( this.esHoja() ){
				return 1;	   	
			}
			
			if( this.getHijoIzquierdo() != null ){
				hojas += this.getHijoIzquierdo().contarHojas();
			}
			
			if( this.getHijoDerecho() != null ){
				hojas += this.getHijoDerecho().contarHojas();
			}
						
			return hojas;
		}
		
		public void recorridoEntreNiveles(int n,int m) {
			
						
			Cola<ArbolBinario<T>> cola = new Cola<ArbolBinario<T>>();
			Cola<int> niveles = new Cola<int>();

			cola.encolar( this );
			niveles.encolar( 1 );
			
			while( !cola.esVacia() ){
				
				ArbolBinario<T> aux = cola.desencolar();
				int nivel = niveles.desencolar();
				
				if( nivel >= n && nivel <= m ){
					Console.Write(nivel);
					Console.Write( " ===> ");				
					Console.WriteLine( aux.getDatoRaiz());					
				}
				
				if( aux.getHijoIzquierdo() != null && nivel < m){
					cola.encolar( aux.getHijoIzquierdo() );
					niveles.encolar( nivel + 1);
				}
				
				if( aux.getHijoDerecho() != null && nivel < m ){
					cola.encolar( aux.getHijoDerecho() );
					niveles.encolar( nivel + 1);
				}

			}
			
		}
		
		public int profundidad(){
			
			if( this.esHoja() ){
				return 0;
			}
			
			Cola<ArbolBinario<T>> cola = new Cola<ArbolBinario<T>>();
			Cola<int> niveles = new Cola<int>();
			
			int profundidad = 0;
			
			cola.encolar( this );
			niveles.encolar( profundidad );
			
			while( !cola.esVacia() ){
				
				ArbolBinario<T> aux = cola.desencolar();
				int nivel = niveles.desencolar();				
				if( nivel > profundidad ){
					profundidad  = nivel;
				}
				
				if( aux.getHijoIzquierdo() != null ){
					cola.encolar( aux.getHijoIzquierdo() );
					niveles.encolar( nivel + 1);
				}
				
				if( aux.getHijoDerecho() != null){
					cola.encolar( aux.getHijoDerecho() );
					niveles.encolar( nivel + 1);
				}

			}
			
			return profundidad;
			
		}
				
		public int altura( ArbolBinario<T> arbol ){
			
			if( this.getDatoRaiz().Equals( arbol.getDatoRaiz() )){
			   	return 0;
			}
			
			int profundidad = 0;			
			int altura = 0;
			
			Cola<ArbolBinario<T>> cola = new Cola<ArbolBinario<T>>();
			Cola<int> niveles = new Cola<int>();
			
	
			cola.encolar( this );
			niveles.encolar( profundidad );
			
			while( (!cola.esVacia() ) || altura == 0){
				
				ArbolBinario<T> aux = cola.desencolar();
				int nivel = niveles.desencolar();				
				
				if( nivel > profundidad ){
					profundidad  = nivel;
				}
				
			
				if( aux.getDatoRaiz().Equals( arbol.getDatoRaiz() ) ){	
					altura = profundidad;
				}
				
				
				if( aux.getHijoIzquierdo() != null ){
					cola.encolar( aux.getHijoIzquierdo() );
					niveles.encolar( nivel + 1);
				}
				
				
				if( aux.getHijoDerecho() != null){
					cola.encolar( aux.getHijoDerecho() );
					niveles.encolar( nivel + 1);
				}

			}
			
			return altura;
			
		}
		
		
	
	}
}