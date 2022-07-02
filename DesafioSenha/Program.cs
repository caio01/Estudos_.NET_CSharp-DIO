using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace DesafioSenha {
    class Program {
        static void Main(string[] args) {
            string senha = "1Abc#$jshs";

            if((naoTemEspaco(senha)) && (temNumeros(senha)) && (temLetraMaiuscula(senha)) && 
               (temLetraMinuscula(senha)) && (verificaTamanho(senha)) && (naoTemAcentoPontuacao(senha))) {
              Console.WriteLine("Senha valida.");
            } else {
              Console.WriteLine("Senha invalida.");
            }

            //Console.WriteLine("Nao tem espaço: " + naoTemEspaco(senha));
            //Console.WriteLine("Tem numero: " + temNumeros(senha));
            //Console.WriteLine("Tem maiuscula: " + temLetraMaiuscula(senha));
            //Console.WriteLine("Tem minuscula: " + temLetraMinuscula(senha));
            //Console.WriteLine("Verifica o tamanho: " + verificaTamanho(senha));
            //Console.WriteLine("Nao tem acento e pontuacao: " + naoTemAcentoPontuacao(senha));
            foreach (String s in senha.Split(' '))
            {
                Console.WriteLine(s);
            }
            

        }
        public static bool naoTemAcentoPontuacao(string texto) {
            return !(Regex.IsMatch(texto, "[.,;:~^ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç]"));
        }

        public static bool naoTemEspaco(string texto) {
            return !(texto.IndexOf(' ') > 0);
        }

        public static bool verificaTamanho(string texto) {
            bool x = false;
            if((texto.Length >= 6) && (texto.Length <= 32)) {
                x = true;
            }
            return x;
        }

        public static bool temLetraMaiuscula(string texto) {
            bool x = false;
            char a;
            for(int i = 0; i < texto.Length; i++){
                a = texto[i];
                if (Char.IsUpper(a)){
                    x = true;
                }
            }
            return x;
        }

        public static bool temLetraMinuscula(string texto) {
            bool x = false;
            char a;
            for(int i = 0; i < texto.Length; i++){
                a = texto[i];
                if (Char.IsLower(a)){
                    x = true;
                }
            }
            return x;
        }

        public static bool temNumeros(string texto) {
            if (texto.Where(c => char.IsNumber(c)).Count() > 0)
            return true;
            else
            return false;
        }
    }
}