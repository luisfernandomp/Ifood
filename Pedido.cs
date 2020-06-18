namespace iFood
{
    public class Pedido
    {
        public string[] itens = new string[3];
        public string Cliente { get; set; }
        public string Restaurante { get; set; }

        public string EntregarPedido(){
            return "Pedido entregue";
        }
    }
}