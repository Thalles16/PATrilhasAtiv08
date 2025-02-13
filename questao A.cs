using System;

class Program
{
	static int quadrado (int numero){
	
		
		
		return numero * numero;
		
		
	}
     public static void Main()
    {
        Console.WriteLine("insira um numero");
        int num = int.Parse(Console.ReadLine());
		
        int resultado = quadrado(num);
        
        Console.WriteLine("o quadrado do numero é : {0}", resultado);
        Console.ReadLine();
}
}
