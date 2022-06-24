﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaExcepcion1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continua;
            do
            {
                try
                {
                    continua = false;
                    Console.Write("Ingrese un valor:");
                    string linea = Console.ReadLine();
                    int num = int.Parse(linea);
                    int cuadrado = num * num;
                    Console.WriteLine($"El cuadrado de {num} es {cuadrado}");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Debe ingresar obligatoriamente un número entero.");
                    continua = true;
                }
            } while (continua);
            Console.ReadKey();
        }

    }
}

