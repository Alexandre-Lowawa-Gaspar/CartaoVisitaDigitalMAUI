using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartaoVisitaDigitalMAUI.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Instagram { get; set; }
        public string YouTube { get; set; }
        public string WhatsApp { get; set; }
        public Pessoa()
        {
            Nome = "Alexandre Gaspar";
            Descricao = "Desenvolvedor .NET,técnico médio de gestão de sistemas informáticos e estudante de Engenharia Informática no ISPTEC.";
            Instagram = "https://www.instagram.com/alexandre_lowawa_gaspar/";
            YouTube = "";
            WhatsApp = "https://api.whatsapp.com/send?phone=244941394712&text=BomDia";


        }
    }
}
