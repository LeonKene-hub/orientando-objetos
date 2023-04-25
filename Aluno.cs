using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orientando_Objetos
{
    public class Aluno
    {
        public string nome = "";
        public string curso = "";
        public int idade;
        public string RG = "";
        public bool bolsista;
        public float mediaFinal = 1;
        public float valorMensalidade = 2500;
        public void VerMediaFinal()
        {
            Console.WriteLine($"Sua media final e {mediaFinal}");
        }
        public float VerMensaildade()
        {
            float valor;
            if (bolsista && mediaFinal >= 8)
            {
                valor = this.valorMensalidade * 0.5f;
            }
            else if (bolsista && mediaFinal >= 6)
            {
                valor = this.valorMensalidade * 0.3f;
            }
            else
            {
                valor = this.valorMensalidade;
            }
            return valor;
        }
    }
}