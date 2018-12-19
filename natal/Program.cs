using System;

namespace natal
{
    class Program
    {
        static void Main(string[] args)
        {
            Arvore obj = new Arvore();
            obj.montaArvore();

            while(true){
               obj.imprimeArvore();
            }            
        }
    }
}
