	public static void Main(string[] args)
	{	StringBuilder sb = new StringBuilder ();
		string s="";

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