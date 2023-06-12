
namespace FestasInfantis.Dominio.ModuloTema
{
    public class Tema : EntidadeBase<Tema>
    {
        public string Nome { get; set; }
        public List<ItemTema> Itens { get; set; }
        public decimal Total { get; set; }

        public Tema(string tema)
        {
            this.Nome = tema;
            this.Itens = new List<ItemTema>();
            this.Total = 0;
        }
        public Tema()
        {
        }
        public override void Editar(Tema temaAtualizado)
        {
            this.Nome = temaAtualizado.Nome;
            this.Itens = temaAtualizado.Itens;
            this.Total = temaAtualizado.Total;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (Nome.Trim() == string.Empty)
            {
                erros.Add("Por gentileza, informe o nome do tema!");
            }

            foreach (ItemTema item in  Itens)
            {
                if(item.nome.Trim() == string.Empty)
                {
                    erros.Add("Por gentileza, informe o nome do item!");
                }
                if(item.valor < 0)
                {
                    erros.Add("Por gentileza, informe um valor positivo!");
                }
            }

            return erros.ToArray();


        }
        public override string ToString()
        {
            return $"{Nome}";
        }

        public void AdicionarItemNoTema(ItemTema item)
        {
            Itens.Add(item);
        }

        public void CalcularValorTotal()
        {
            this.Total = 0;

            foreach (ItemTema item in Itens)
            {
                this.Total += item.valor;
            } 
        }
    }
}
