using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento
{
    public class Guiche
    {
        public int Id { get; private set; }
        public Queue<Senha> Atendimentos { get; private set; }

        public Guiche(int id)
        {
            Id = id;
            Atendimentos = new Queue<Senha>();
        }

        public bool Chamar(Queue<Senha> filaSenhas)
        {
            if (filaSenhas.Count > 0)
            {
                Senha senhaAtendida = filaSenhas.Dequeue();
                senhaAtendida.RegistrarAtendimento();
                Atendimentos.Enqueue(senhaAtendida);
                return true;
            }
            return false;
        }
    }
}
