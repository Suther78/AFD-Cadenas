﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FSM_Simple
{
    internal class Program{
        
      public static void Main(string[] args){
            //Application.EnableVisualStyles();
            //Application.Run(new Dibujo());
            int contador = 0;
            int contador2 = 0;
            int contador3 = 0;
            Console.Write("Ingrese la cantidad de estados: ");
            contador=int.Parse(Console.ReadLine());
            if (contador >= 10)
            {
                Console.Write("Numero de estados muy alto");
            }
            else
            {
                var Q = new List<string>();
                for (int i = 0; i < contador; i++)
                {
                    Console.Write("Ingresa el estado: ");
                    string estado = Console.ReadLine();
                    Q.Add(estado);
                }

                var Sigma = new List<char>();
                Console.Write("Ingrese la cantidad de letras de alfabeto: ");
                contador3 = int.Parse(Console.ReadLine());
                for (int i = 0; i < contador3; i++)
                {
                    Console.Write("Ingresa la letra del alfabeto: ");
                    char letras = char.Parse(Console.ReadLine());
                    Sigma.Add(letras);
                    
                }
                Console.Write("Ingrese la cantidad de transiciones: ");
                contador2 = int.Parse(Console.ReadLine());
                var Delta = new List<Transition>();
                for (int i = 0; i < contador2; i++)
                {
                    Console.Write("Ingresa tu origen: ");
                    string origen = Console.ReadLine();
                    Console.Write("Ingresa con que te moveras: ");
                    char tok = char.Parse(Console.ReadLine());
                    Console.Write("Ingresa el destino: ");
                    string Destino = Console.ReadLine();
                    Delta.Add(new Transition(origen, tok, Destino));
                    
                }
                //    var Delta = new List<Transition>{
                //new Transition("q0", 'a', "q1"),
                //new Transition("q0",'b',"q0"),
                //new Transition("q1",'b',"q1"),
                //new Transition("q1", 'a', "q2"),
                //new Transition("q2", 'a', "q2"),
                //new Transition("q2",'b',"q3"),
                //new Transition("q3",'a',"q4"),
                //new Transition("q3",'b',"q2"),
                //new Transition("q4",'b',"q4")
                var Q0 = "q0";
                Console.Write("Ingrese el final(q+numero): ");
                string estado_fin = Console.ReadLine();
                var F = new List<string> { estado_fin };
                Console.Write("ingrese la cantidad de cadenas a evaluar: ");
                int cadenas = int.Parse(Console.ReadLine());
                var dFSM = new DeterministicFSM(Q, Sigma, Delta, Q0, F);
                for (int i = 0; i < cadenas; i++)
                {
                    Console.Write("ingresa la cadena a evaluar: ");
                    string palabra = Console.ReadLine();
                    dFSM.Accepts(palabra);
                }

                Console.ReadKey();
            }

      }

      
   }
}