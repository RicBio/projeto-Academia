using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento
{
    public class Senha
    {
        public int Id { get; private set; }
        public DateTime DataGerac { get; private set; }
        public DateTime HoraGerac { get; private set; }
        public DateTime? DataAtend { get; private set; }
        public DateTime? HoraAtend { get; private set; }

        public Senha(int id)
        {
            Id = id;
            DataGerac = DateTime.Now.Date;
            HoraGerac = DateTime.Now;
        }

        public string DadosParciais()
        {
            return $"{Id} - {DataGerac.ToShortDateString()} - {HoraGerac.ToShortTimeString()}";
        }

        public string DadosCompletos()
        {
            string dataAtend = DataAtend.HasValue ? DataAtend.Value.ToShortDateString() : "N/A";
            string horaAtend = HoraAtend.HasValue ? HoraAtend.Value.ToShortTimeString() : "N/A";
            return $"{DadosParciais()} - {dataAtend} - {horaAtend}";
        }

        public void RegistrarAtendimento()
        {
            DataAtend = DateTime.Now.Date;
            HoraAtend = DateTime.Now;
        }
    }
}
