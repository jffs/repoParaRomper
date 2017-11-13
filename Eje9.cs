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
		} else
}
}