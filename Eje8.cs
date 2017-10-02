using System;
class Program
{	
	//Para ejecutar con parametros ir a Ejecutar - > Ejecutar con -> Parámetros personalizados. 
	public static void Main(string[] args)
	{
		Console.WriteLine ("Iniciando saludos");
		if (args.Length != 0) {
			for (int i = 0; i < args.Length; i++)				//Usando FOR
				Console.WriteLine ("Holaaaa {0}", args [i]);
			foreach (string s in args)							//Usando Foreach
				Console.WriteLine ("Holaaaa {0}", s);
			
		} else
			Console.WriteLine ("No se recibieron parametros");
}
}