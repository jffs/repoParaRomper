
class Program
{	
	//Para ejecutar con parametros ir a Ejecutar - > Ejecutar con -> Parámetros personalizados. 
	public static void Main(string[] args)
	{	StringBuilder sb = new StringBuilder ();
		string s="";
		/*Aca es mejor usar StringBuild que String */
		DateTime anterior = DateTime.Now;
		for (int i = 0; i < 10000; i++)
			sb.Append (i.ToString ());
		DateTime posterior = DateTime.Now;
		Console.WriteLine (posterior.Ticks-anterior.Ticks);

		DateTime anteriorStr = DateTime.Now;
		for (int j = 0; j < 10000; j++)
			s = s + j.ToString();
		DateTime posteriorStr = DateTime.Now;
		Console.WriteLine (posteriorStr.Ticks-anteriorStr.Ticks);

		/* Aca es mejor usar String que StringBuild*/
		DateTime anterior2 = DateTime.Now;
		sb.Append ("holaa").Append ("como vaa");
		DateTime posterior2 = DateTime.Now;
		Console.WriteLine (posterior2.Ticks-anterior2.Ticks);


	}
}