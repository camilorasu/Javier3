using System;
using System.Collections.Generic;
using static System.Console;
class Ordenamiento
{
    static Numero nmr = new Numero();
    public void pedirNumeros()
    {
        for (int i = 0; i < 10; i++)
        {
            try
            {
                WriteLine($"ingrese el numero {i + 1}");
                nmr.numero = Convert.ToInt32(ReadLine());
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
        int[] numeros = nmr.getNumeros();
        foreach (var numero in numeros)
        {
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                if (numeros[i] > numeros[i + 1])
                {
                    int aux = numeros[i];
                    numeros[i] = numeros[i + 1];
                    numeros[i + 1] = aux;
                }
            }
        }
        numeros = nmr.numeros;

    }
    public void insercion()
    {
        int[] numeros = nmr.getNumeros();
        for (int i = 0; i < numeros.Length; i++)
        {
            int tempo = numeros[i];
            int j = i - 1;
            while ((j >= 0) && (numeros[j] > tempo))
            {
                numeros[j + 1] = numeros[j];
                j--;
            }
            numeros[j + 1] = tempo;
        }
        numeros = nmr.numeros;
    }
    public void seleccion()
    {
        int[] numeros = nmr.getNumeros();
        for (int i = 0; i < numeros.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < numeros.Length; j++)
            {
                if (numeros[j] < numeros[min])
                {
                    min = j;
                }
            }
            int temp = numeros[min];
            numeros[min] = numeros[i];
            numeros[i] = temp;
        }
        numeros = nmr.numeros;
    }
    public void shell()
    {
        int[] numeros = nmr.getNumeros();
        int salto = numeros.Length / 2;
        int sw;
        int aux;
        int e;
        while (salto > 0)
        {
            sw = 1;
            while (sw != 0)
            {
                sw = 0;
                e = 1;
                while (e <= (numeros.Length - salto))
                {
                    if (numeros[e - 1] > numeros[(e - 1) + salto])
                    {
                        aux = numeros[(e - 1) + salto];
                        numeros[(e - 1) + salto] = numeros[e - 1];
                        numeros[e - 1] = aux;
                        sw = 1;
                    }
                    e++;
                }
            }
            salto = salto / 2;
        }
        numeros=nmr.numeros;
    }
    public void mostrar()
    {
        foreach (var numero in nmr.getNumeros())
        {
            WriteLine(numero.ToString());
        }
    }

}