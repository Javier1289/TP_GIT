using System;

namespace tp_01
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			ArbolBinario<int> arbol1 = new ArbolBinario<int>(1);
			ArbolBinario<int> arbol2 = new ArbolBinario<int>(2);
			ArbolBinario<int> arbol3 = new ArbolBinario<int>(3);
			ArbolBinario<int> arbol4 = new ArbolBinario<int>(4);
			ArbolBinario<int> arbol5 = new ArbolBinario<int>(5);
			ArbolBinario<int> arbol6 = new ArbolBinario<int>(6);
			ArbolBinario<int> arbol7 = new ArbolBinario<int>(7);
			ArbolBinario<int> arbol8 = new ArbolBinario<int>(8);
			ArbolBinario<int> arbol9 = new ArbolBinario<int>(9);
			ArbolBinario<int> arbol10 = new ArbolBinario<int>(10);
			ArbolBinario<int> arbol11 = new ArbolBinario<int>(11);
			ArbolBinario<int> arbol12 = new ArbolBinario<int>(12);
			ArbolBinario<int> arbol13 = new ArbolBinario<int>(13);
			ArbolBinario<int> arbol14 = new ArbolBinario<int>(14);
			ArbolBinario<int> arbol15 = new ArbolBinario<int>(15);
			
			

			arbol1.agregarHijoIzquierdo(arbol2);
			arbol1.agregarHijoDerecho(arbol3);
			arbol2.agregarHijoIzquierdo(arbol4);
			arbol2.agregarHijoDerecho(arbol5);
			arbol3.agregarHijoIzquierdo(arbol6);
			arbol3.agregarHijoDerecho(arbol7);
			arbol4.agregarHijoIzquierdo(arbol8);
			arbol4.agregarHijoDerecho(arbol9);
			arbol5.agregarHijoIzquierdo(arbol10);
			arbol5.agregarHijoDerecho(arbol11);
			arbol6.agregarHijoIzquierdo(arbol12);
			arbol6.agregarHijoDerecho(arbol13);
			arbol7.agregarHijoIzquierdo(arbol14);
			arbol7.agregarHijoDerecho(arbol15);
			
			

			Console.WriteLine("***Inorden****");

			arbol1.inorden();
			
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			
			Console.WriteLine("***Preorden****");
			arbol1.preorden();
			
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			
			Console.WriteLine("***Postorden****");			
			arbol1.postorden();
			
	
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			
			Console.WriteLine("***Por Niveles****");						
			arbol1.recorridoPorNiveles();
			
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			
			Console.WriteLine("***Contar Hojas****");						
			Console.WriteLine( arbol1.contarHojas());
			

			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			
			Console.WriteLine("***Entre Niveles****");						
			arbol1.recorridoEntreNiveles( 4, 4 );
			

			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			
			Console.WriteLine("***Profundidad arbol1****");
			Console.WriteLine( arbol1.profundidad() );
			Console.WriteLine("***Profundidad arbol3****");
			Console.WriteLine( arbol3.profundidad() );
			Console.WriteLine("***Profundidad arbol5****");
			Console.WriteLine( arbol5.profundidad() );			
			Console.WriteLine("***Profundidad arbol9****");
			Console.WriteLine( arbol9.profundidad() );
			
			
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");

			Console.WriteLine("***Altura Nodo: 1****");			
			Console.WriteLine( arbol1.altura( arbol1 ) );
			
			Console.WriteLine("***Altura Nodo: 9****");			
			Console.WriteLine( arbol1.altura( arbol9 ) );
			
			Console.WriteLine("***Altura Nodo: 5****");			
			Console.WriteLine( arbol1.altura( arbol5 ) );
			
			Console.WriteLine("***Altura Nodo: 3****");			
			Console.WriteLine( arbol1.altura( arbol3 ) );
			
			
			
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			
			Console.WriteLine("***Red Binaria****");			

			RedBinariaLlena redBinaria = new RedBinariaLlena( arbol1 );
			
			Console.WriteLine("***Maximo retardo****");
			
			Console.WriteLine(redBinaria.retardoReenvio());


			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			
			Console.WriteLine("***Profundidad De Arbol Binario****");
			ProfundidadDeArbolBinario pab = new ProfundidadDeArbolBinario( arbol1 );
			
			Console.WriteLine("");
			
			Console.WriteLine("***sumaElementosProfundidad****");
			
			Console.WriteLine( pab.sumaElementosProfundidad( 2 ) );
			
			
			
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("***Nuevo Arbol****");
			ArbolBinario<int> n = pab.nuevo( arbol1 );
			
			n.recorridoPorNiveles();



			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}