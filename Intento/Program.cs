using System;
using System.Collections.Generic;


class ejercicio
{
    static void Main()
    {
        //SortedList<string, string> diccio = new SortedList<string, string>();
        //diccio.Add("hello", "hola");
        //diccio["see you later"] = "hasta luego";
        //diccio["bye"] = "adios";
        //diccio["sorry"] = "perdon";
        //diccio["thanks"] = "gracias";
        //diccio["car"] = "auto";
        //diccio["bike"] = "bicicleta";
        //diccio["box"] = "caja";
        //diccio["computer"] = "computadora";
        //diccio["screen"] = "pantalla";
        //diccio["display"] = "monitor";
        //diccio["street"] = "calle";
        //diccio["road"] = "camino";
        //diccio["sun"] = "sol";
        //diccio["tools"] = "herramientas";
        //diccio["son"] = "hijo";
        //diccio["brother"] = "hermano";
        //diccio["sister"] = "hermana";

        //string frase = Console.ReadLine();

        //string[] subFrase = frase.Split(' ');

        //foreach (string s in subFrase)
        //{
        //    if (diccio.ContainsKey(s))
        //    {
        //        Console.Write(diccio[s] + ' ');
        //    }
        //}
        //Console.WriteLine();



        //ejercicio78



        //Dictionary<string, string> dicc = new Dictionary<string, string>();
        //dicc.Add("hello", "hola");
        //dicc.Add("goodbye", "adios");
        //dicc.Add("how're", "como estas");
        //dicc.Add("you", "tu");
        //dicc.Add("im", "yo estoy");
        //dicc.Add("fine", "bien");
        //dicc.Add("and", "y");
        //dicc.Add("good", "bien");
        //dicc.Add("bad", "mal");
        //dicc.Add("why", "por que?");
        //dicc.Add("thanks", "gracias");
        //dicc.Add("for", "por");
        //dicc.Add("asking", "preguntar");
        //dicc.Add("had", "tuve");
        //dicc.Add("a", "un");
        //dicc.Add("day", "dia");

        //string frase = Console.ReadLine();

        //string[] subFrase = frase.Split(' ');

        //foreach (string s in subFrase)
        //{
        //    if (dicc.ContainsKey(s))
        //    {
        //        Console.Write(dicc[s] + ' ');
        //    }
        //}
        //Console.WriteLine();


        //ejercicio 79

        SortedSet<string> SetPalabras = new SortedSet<string>();
        string palabra = Console.ReadLine();

        while (palabra != "")
        {
            if (SetPalabras.Contains(palabra))
            {
                Console.WriteLine($"{palabra} ya está, ingrese otra palabra");
                palabra = Console.ReadLine();
            }
            else
            {
                SetPalabras.Add(palabra);
                palabra = Console.ReadLine();
            }
        }





    }
}
    





