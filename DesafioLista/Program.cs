using System;

namespace DesafioLista {
    class Program {
        static void Main(string[] args) {
            List<string> lista = new List<string>();
            string[] strArray;
            string texto = "caio amanda jose maria amanda jose caio";
            strArray = texto.Split(" ");
            foreach (string txt in strArray) {
                lista.Add(txt);
            }

            


            List<string> unicSortedList = lista.Distinct().OrderBy(list => list).ToList();
            foreach (string letra in unicSortedList) {
                Console.Write(letra + " ");
            }
            Console.WriteLine();
        }
    }
}