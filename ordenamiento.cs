using System;
using System.Collections.Generic;
using static System.Console;
class Ordenamiento
{
    static Numero nmr=new Numero();
    public void pedirNumeros()
    {
      for (int i = 0; i < 10 ; i++)
      {
          try
          {
              WriteLine($"ingrese el numero {i+1}");
              nmr.numero= Convert.ToInt32(ReadLine());
              nmr.agregarNumero(nmr.numero);
          }
          catch (Exception ex)
          {
             WriteLine("Solo se acepta numeros");        
          }
      }
    }
    public void burbuja()
    {
      int[] numeros=nmr.getNumeros();
      foreach (var numero in numeros)
      {
          for (int i = 0; i < numeros.Length - 1 ; i++)
          {
              if (numeros[i] > numeros[i+1]) 
              {
                  int aux= numeros[i];
                  numeros[i] = numeros[i+1];
                  numeros[i+1] = aux;   
              }
          }
      }
      numeros=nmr.numeros;
    }

}