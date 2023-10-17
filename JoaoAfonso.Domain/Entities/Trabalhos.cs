using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoaoAfonso.Domain.Entities
{
    public class Trabalhos
    {
        public int ID { get; set; }
        public required string Nome { get; set; }
        public string? Descricao { get; set; }
        public required string UrlImagem { get; set; }
    }
}
