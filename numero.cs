using System;
using System.Collections.Generic;

class Numero
{
    public int longitud { get; set; }
    public int[] numeros = new int[1];
    public int numero { get; set; }

    public int[] getNumeros()
    {
        return numeros;
    }

    public void calcularLongitud()
    {
        this.longitud = numeros.Length;
    }
    public void agregarNumero(int numero)
    {
        Array.Resize<int>(ref numeros, longitud + 1);
        numeros[longitud] = numero;
        calcularLongitud();
    }

}