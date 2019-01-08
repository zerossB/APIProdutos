namespace APIProdutos.Models
{
    public class Produto
    {
        private string _codBarras;

        public string CodigoBarras
        {
            get => _codBarras;
            set => _codBarras = value?.Trim().ToUpper();
        }

        private string _nome;
        public string Nome
        {
            get => _nome;
            set => _nome = value?.Trim();
        }
    }
}