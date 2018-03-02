using System;
using light;
namespace dark{
	 class first{
		public static void Main(){
			//System.Console.WriteLine("Hi From App");
			System.Console.WriteLine(zztype.getMsg());
		}
	}
}

/*
	Compile from the command line
	csc.exe  	/out:App.exe  	/t:exe  		/r:MSCorLib.dll Program.cs
	<compiler>	<output name>	<target type>	<references which assembly>
*/