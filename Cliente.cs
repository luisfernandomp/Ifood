namespace iFood
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string EnderecoAtual { get; set; }

        public Cliente(string _Nome, string _EnderecoAtual){
            this.Nome = _Nome;
            this.EnderecoAtual = _EnderecoAtual;
        }

        public string MostrarDados(){
            return $"Nome: {Nome}\nEndereco atual: {EnderecoAtual}";
        }
    }
}