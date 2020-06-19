namespace iFood
{
    public class Restaurante
    {
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }

        public Restaurante(string _NomeFantasia, string _Endereco){
            this.NomeFantasia = _NomeFantasia;
            this.Endereco = _Endereco;
        }

        public string MostrarDados(){
            return $"Restaurante: {NomeFantasia}\nEndereço: {Endereco}";
        }
    }
}