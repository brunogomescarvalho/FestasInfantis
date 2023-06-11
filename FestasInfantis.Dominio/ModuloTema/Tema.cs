
namespace FestasInfantis.Dominio.ModuloTema
{
    public class Tema : EntidadeBase<Tema>
    {
        public string nome { get; set; }
        public List<ItemTema> itens { get; set; }
        public decimal? total { get; set; }

        public Tema(string tema)
        {
            this.nome = tema;
            this.itens = new List<ItemTema>();
            this.total = 0;
        }
        public Tema()
        {
        }
        public override void Editar(Tema temaAtualizado)
        {
            this.nome = temaAtualizado.nome;
            this.itens = temaAtualizado.itens;
            this.total = temaAtualizado.total;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (nome.Trim() == string.Empty)
            {
                erros.Add("Por gentileza, informe o nome do tema!");
            }

            foreach (ItemTema item in  itens)
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
            return $"{nome}";
        }

        public void AdicionarItemNoTema(ItemTema item)
        {
            itens.Add(item);
        }

        public void CalcularValorTotal()
        {
            this.total = 0;

            foreach (ItemTema item in itens)
            {
                this.total += item.valor;
            } 
        }
    }
}
