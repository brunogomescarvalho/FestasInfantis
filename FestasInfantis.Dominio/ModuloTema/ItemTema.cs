using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.Dominio.ModuloTema
{
    public class ItemTema
    {
        public decimal valor { get; set; }
        public string nome { get; set; }

        public ItemTema()
        {
            
        }

        public ItemTema(decimal valor, string nome)
        {
            this.valor = valor;
            this.nome = nome;
        }

        public override string ToString()
        {
            return $"{nome}";
        }

    }
}
