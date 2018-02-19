public sealed class first{
	public static void Main(){
		System.Console.WriteLine("Hi From App");
	}
}


/*
	Compile from the command line
	csc.exe  	/out:App.exe  	/t:exe  		/r:MSCorLib.dll Program.cs
	<compiler>	<output name>	<target type>	<references which assembly>
*/