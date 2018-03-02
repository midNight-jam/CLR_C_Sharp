# CLR_C_Sharp
C# Lessson and CLR notes 

Commands

///////////////////////
//// Fundamentals
///////////////////////

#1 Compile & create exe:  

> csc.exe  	/out:App.exe  	/t:exe	App.cs

------

#2 Create .netmodule:  

> csc.exe  	/t:module 	MyType.cs

------

#3 Disassembler

> ildasm	app.exe
> ildasm	mylib.dll
> ildasm	mytype..netmodule

------