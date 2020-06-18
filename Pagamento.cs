using System;
using System.Threading;
namespace iFood
{
    public class Pagamento : Pedido
    {
        private string FormaDePGTO;
        public string Forma
        {
            get { return FormaDePGTO; }
            set { if(value == "1"){
                    FormaDePGTO = "Dinheiro";
                }else{
                    if(value == "2"){
                        FormaDePGTO = "Cartão";
                    }
                }
            }
        }
        public bool PedidoPago { get; set; }
        public float ValorTotal { get; set; }

        public void ProcessarPagamento(){
            bool teste1 = true, teste2 = true;
            Random numAleatorio = new Random();
            float pagamento = numAleatorio.Next(20,100);
            ValorTotal = pagamento + 0.5f;
            while(teste1 == true){
                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("--- FORMA DE PAGAMENTO -----");
                Console.WriteLine("- 1 - Dinheiro             -");
                Console.WriteLine("- 2 - Cartão               -");
                Console.WriteLine("----------------------------");
                Console.ResetColor();
                string aux = Console.ReadLine();
                switch(aux){
                    case "1":
                        Forma = aux;
                        System.Console.WriteLine("Pedido confirmado!");
                        System.Console.WriteLine("Total: R$"+ ValorTotal); 
                        while(teste2 == true){
                            System.Console.WriteLine("Deseja confirmar o pagamento? s - sim, n - não");
                            string resp = Console.ReadLine();
                            if(resp == "s" || resp == "S"){
                                Console.ForegroundColor = ConsoleColor.Blue;
                                System.Console.WriteLine("Pagamento efetuado!");
                                PedidoPago = true;
                                teste2 = false;
                                teste1 = false;
                            }else{
                                if(resp == "n" || resp == "N"){ 
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    System.Console.WriteLine("Pagamento cancelado!");
                                    PedidoPago = false;
                                    teste2 = false;
                                    teste1 = false;
                                }else{
                                    System.Console.WriteLine("Dados inválidos!");
                                }
                            } 
                        }
                        ;break;
                    case "2":
                        Forma = aux;
                        System.Console.WriteLine("Pedido confirmado!");
                        System.Console.WriteLine("Total: R$"+ ValorTotal); 
                        while(teste2 == true){
                            System.Console.WriteLine("Deseja confirmar o pagamento? s - sim, n - não");
                            string resp = Console.ReadLine();
                            if(resp == "s" || resp == "S"){
                                Console.ForegroundColor = ConsoleColor.Blue;
                                System.Console.WriteLine("Pagamento efetuado!");
                                PedidoPago = true;
                                teste2 = false;
                                teste1 = false;
                            }else{
                                if(resp == "n" || resp == "N"){ 
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    System.Console.WriteLine("Pagamento cancelado!");
                                    PedidoPago = false;
                                    teste2 = false;
                                    teste1 = false;
                                }else{
                                    System.Console.WriteLine("Dados inválidos!");
                                }
                            } 
                        }    
                        ;break;
                    default: 
                        System.Console.WriteLine("Dados inválidos!");
                        ;break;
                }    
            }
        }
    }
}