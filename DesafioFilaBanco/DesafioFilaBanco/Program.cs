using System;

namespace DesafioFilaBanco {
    class Program {
        static void Main(string[] args) {
            
            //int numVezes = int.Parse(Console.ReadLine());
            int numVezes = 1;
            string num;
            for(int i = 0; i < numVezes; i++) {
                //int numClientes = 3; //int.Parse(Console.ReadLine());
                num = "100 120 30 50";//Console.ReadLine();
                int aux = 0, qtdNaoMudou = 0;
                List<int> x = new List<int>();
                foreach (String s in num.Split(' ')) {
                    x.Add(Int32.Parse(s));
                    aux++;
                }

                List<int> xOrder = x.OrderBy(x => x).ToList();
                
                for(int w = 0; w < x.Count; w++) {
                    if(x[w] == xOrder[w]) {
                        qtdNaoMudou++;
                    }
                }

                Console.WriteLine(qtdNaoMudou);
                
                    
            }
        }
    }
}