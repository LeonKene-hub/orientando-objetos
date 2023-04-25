using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orientando_Objetos
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public int idade;
        public int RG;
        public bool bolsista;
        public float mediaFinal = 1;
        public float valorMensalidade;

        public void VerMedia()
        {
            Console.WriteLine($"Sua media e de {mediaFinal}");
        }
        public void VerMensaildade()
        {
            Console.WriteLine($"Sua mensalidade e de {valorMensalidade}");
        }
    }
}