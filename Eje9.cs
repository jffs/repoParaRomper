{	
	//Para ejecutar con parametros ir a Ejecutar - > Ejecutar con -> Parámetros personalizados. 
	public static void Main(string[] args)
	{	bool cumple;
		int i;
		Console.WriteLine ("Iniciando saludos");
		if (args.Length != 0) {
			foreach (string nombre in args) {
				i = 0;
				cumple = true;
				int j=nombre.Length-1;
				while (cumple && i < j) {
					if (nombre [i] != nombre [j]) {
						cumple = false;
					}
					i++;
					j--;
				}
				if (cumple)
					Console.WriteLine ("{0} es palíndromo", nombre);
				else
					Console.WriteLine ("{0} no es palíndromo", nombre);
			}
		} else
			Console.WriteLine ("No se recibieron parametros");
}
}