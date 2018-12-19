using System;
using System.Threading;

namespace natal
{
    class Arvore
    {
        private const int tamLinha = 10;
        private const int tamColuna = tamLinha*2;
        private string[,] arvore = new string[tamLinha, tamColuna];

        public Arvore(){
            for(int i=0; i<tamLinha; i++){
                for(int j=0; j<tamColuna; j++){
                    arvore[i,j] = " ";
                }
            }
        }

        public void montaArvore(){
            int espacos = ((tamLinha * 2 - 1) - 1) / 2;
            int flagEspaco, flagArvore;
           
            for(int i=0; i<tamLinha; i++){
                flagEspaco = espacos - (i+1) + 1;
                flagArvore = 2 * (i+1) - 1;
                for(int j=0; j<tamColuna; j++){
                    if(flagEspaco > 0){
                        arvore[i,j] = " ";
                    }else{
                        flagEspaco = 0;
                        if(flagArvore > 0){
                            if(flagArvore % 2 != 0){
                                arvore[i,j] = "o";
                            } else {
                                arvore[i,j] = "*";
                            }
                        } 
                        flagArvore --; 
                    } 
                    flagEspaco --;
                }
            }
        }

        public void imprimeArvore(){
            Console.Clear();

            for(int i=0; i<tamLinha; i++){
                for(int j=0; j<tamColuna; j++){
                    if(arvore[i,j].Equals("*")){
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(arvore[i,j]);
                    } else{
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(arvore[i,j]);
                    }                    
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.Write("Ho Ho Ho!! Feliz Natal");

            Thread.Sleep(1000);
            Console.Clear();

            for(int i=0; i<tamLinha; i++){
                for(int j=0; j<tamColuna; j++){
                    if(arvore[i,j].Equals("*")){
                        Console.Write(" ");
                    } else{
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(arvore[i,j]);
                    }                    
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.Write("Ho Ho Ho!! Feliz Natal");

            Thread.Sleep(1000);
            Console.Clear();
        }

    }
}
