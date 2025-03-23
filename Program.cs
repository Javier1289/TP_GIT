/*
 * Created by SharpDevelop.
 * User: PC-Developer
 * Date: 23/3/2025
 * Time: 00:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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
			

			arbol1.agregarHijoIzquierdo(arbol2);
			arbol1.agregarHijoDerecho(arbol3);
			arbol2.agregarHijoIzquierdo(arbol4);
			arbol2.agregarHijoDerecho(arbol5);
			arbol3.agregarHijoIzquierdo(arbol6);
			arbol3.agregarHijoDerecho(arbol7);
			arbol4.agregarHijoIzquierdo(arbol8);
			arbol4.agregarHijoDerecho(arbol9);
			

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
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}