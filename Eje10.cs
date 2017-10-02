using System;
using System.Text;

class Program
{	
	//Para ejecutar con parametros ir a Ejecutar - > Ejecutar con -> Parámetros personalizados. 
	public static void Main(string[] args)
	{	
		StringBuilder sb = new StringBuilder ();
		for (int i = 0; i < 1000; i++)
			sb.Append (i.ToString ());


		sb.Append ("holaa").Append ("como vaa");

	}
}
