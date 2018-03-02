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

#4 StrongNameUtility

Create a public-Private key pair with your company name
> SN -k zzcompany.snk

Extract the public key from the .snk file
> SN -p zzcompany.snk zzcopmany.PublicKey sha256

using -tp switch to extract the public key from the binary format 
> SN -tp zzcopmany.PublicKey

------