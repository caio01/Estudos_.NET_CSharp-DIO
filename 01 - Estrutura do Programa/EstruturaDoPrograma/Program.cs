using System;

namespace EstruturaDoPrograma {
    class Program {
        static void Main(string[] args) {
            double opcaoUsuario = 0;
            int aux = 0;
            double nota1 = 0, nota2 = 0, media = 0;
            while(media == 0) {
                double nota = double.Parse(Console.ReadLine());
                if((nota < 0) || (nota > 10)) {
                    Console.WriteLine("nota invalida");
                    media = 0;
                } else {
                    if(aux == 0) {
                        aux++;
                        nota1 = nota;
                    } else {
                        aux = 0;
                        nota2 = nota;
                        media = (nota1+nota2)/2;
                        Console.WriteLine("media = " + media.ToString("N2"));
                    }
                }
            }
            Console.WriteLine("novo calculo (1-sim 2-nao)");
            media = 0;
            while(opcaoUsuario != 2) {
                opcaoUsuario = double.Parse(Console.ReadLine());
                if(opcaoUsuario == 1){    
                    while(media == 0) {
                        double nota = double.Parse(Console.ReadLine());
                        if ((nota < 0) || (nota > 10)) {
                            Console.WriteLine("nota invalida");
                            media = 0;
                        } else {
                            if(aux == 0) {
                                aux++;
                                nota1 = nota;
                            } else {
                                aux = 0;
                                nota2 = nota;
                                media = (nota1+nota2)/2;
                                Console.WriteLine("media = " + media.ToString("N2"));
                            }
                        }
                    }
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                } else if (opcaoUsuario == 2) {
                    break;
                } else {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                }
            }
        }
        
    }       
}