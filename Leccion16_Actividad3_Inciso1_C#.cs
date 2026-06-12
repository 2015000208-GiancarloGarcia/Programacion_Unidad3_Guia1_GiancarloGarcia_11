using System;

class Program
{
    static void Main()
    {
        
        int[] numerosEnteros = new int[8];

        
        int numeroMayor = 0;
        int posicionMayor = 0;

        
        for (int indice = 0; indice < 8; indice++)
        {
            
            Console.Write($"Ingrese el número {indice + 1}: ");
            
            
            numerosEnteros[indice] = Convert.ToInt32(Console.ReadLine());

            
            if (indice == 0)
            {
                numeroMayor = numerosEnteros[indice];
                posicionMayor = indice + 1; // Guardamos "indice + 1" para mantener la lógica humana (1 a 8)
            }
            else // SiNo
            {
                
                if (numerosEnteros[indice] > numeroMayor)
                {
                    numeroMayor = numerosEnteros[indice];
                    posicionMayor = indice + 1;
                }
                
            }
            
        }
        

        
        Console.WriteLine($"El número mayor es: {numeroMayor}");
        
        
        Console.WriteLine($"Se encuentra en la posición: {posicionMayor}");
    }
}
