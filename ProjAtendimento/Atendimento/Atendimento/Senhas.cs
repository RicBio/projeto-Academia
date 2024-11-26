using Atendimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento
{
    public class Senhas
    {
        private int ProximoAtendimento { get; set; }
        public Queue<Senha> FilaSenhas { get; private set; }

        public Senhas()
        {
            ProximoAtendimento = 1;
            FilaSenhas = new Queue<Senha>();
        }

        public void Gerar()
        {
            Senha novaSenha = new Senha(ProximoAtendimento);
            FilaSenhas.Enqueue(novaSenha);
            ProximoAtendimento++;
        }
    }
}
