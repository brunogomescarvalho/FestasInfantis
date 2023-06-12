using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.Dominio.ModuloAluguel
{
    public class Aluguel : EntidadeBase<Aluguel>
    {
        public decimal ValorTotal { get; set; }

        public decimal ValorEntrada { get; set; }

        public decimal Debito { get; set; }

        public PorcentagemEntrada PorcentagemDeEntrada { get; set; }

        public PorcentagemDesconto Desconto { get; set; }

        public Tema Tema { get; set; }

        public Cliente Cliente { get; set; }

        public string Endereco { get; set; }

        public DateTime DataPedido { get; set; }

        public DateTime DataFesta { get; set; }

        public FormaDePagamento FormaPagamento { get; set; }

        public bool EstaEmAberto { get { return DataFesta > DateTime.Now; } }


        public Aluguel(
            Tema tema,
            Cliente cliente,
            PorcentagemEntrada porcentagem,
            PorcentagemDesconto valorDesconto,
            string endereco,
            DateTime dataFesta,
            FormaDePagamento formaPagamento)
        {

            this.Cliente = cliente;
            this.Tema = tema;
            this.Endereco = endereco;
            this.DataPedido = DateTime.Now;
            this.DataFesta = dataFesta;
            this.FormaPagamento = formaPagamento;
            this.ValorTotal = tema.Total;
            this.PorcentagemDeEntrada = porcentagem;
            this.Desconto = valorDesconto;
            this.ValorEntrada = CalcularValorEntrada(this.ValorTotal, PorcentagemDeEntrada, this.Desconto);
            this.Debito = this.ValorTotal - this.ValorEntrada;
        }

        private decimal CalcularValorEntrada(decimal valorTotal, PorcentagemEntrada porcentagemDeEntrada, PorcentagemDesconto valorDesconto)
        {
            decimal porcentagem = (int)porcentagemDeEntrada;

            decimal valorEntrada = valorTotal * (porcentagem / 100);

            decimal valorCalculado = CalcularValorEntradaComDesconto(valorDesconto, valorEntrada);

            return Math.Round(valorCalculado, 2);
        }

        private decimal CalcularValorEntradaComDesconto(PorcentagemDesconto tipo, decimal valorEntrada)
        {
            return valorEntrada - (valorEntrada * ((decimal)tipo / 100));
        }

        public override void Editar(Aluguel entidade)
        {
            this.Tema = entidade.Tema;
            this.PorcentagemDeEntrada = entidade.PorcentagemDeEntrada;
            this.Desconto = entidade.Desconto;
            this.Endereco = entidade.Endereco;
            this.DataFesta = entidade.DataFesta;
            this.FormaPagamento = entidade.FormaPagamento;
        }

        public override string[] Validar()
        {
            List<string> erros = new();

            if(Cliente == null)
            {
                erros.Add("Informe o cliente");
            }
            if(Tema == null)
            {
                erros.Add("Informe o tema");
            }
            if(Endereco.Trim().Length == 0)
            {
                erros.Add("Informe o endereço");
            }
            if(DataFesta == default)
            {
                erros.Add("Informe a data da festa");
            }
            if(ValorEntrada == 0)
            {
                erros.Add("Informe o valor de entrada");
            }

            return erros.ToArray();           
        }
    }

}
