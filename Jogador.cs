using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaLinq
{
    public class Jogador
    {
        public string Nome { get; set; }
        public Tipo Posicao { get; set; }

        public Jogador(string nome, Tipo posicao)
        {
            Nome = nome;
            Posicao = posicao;   
        }
    }
}