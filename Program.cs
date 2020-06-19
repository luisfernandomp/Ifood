using System;
using System.Threading;

namespace iFood
{
    class Program
    {
        static void Main(string[] args)
        {
            bool teste = true, continuar2 = true, continuar3 = true;
            string endereco = null, nome = null, resposta = "";
            Restaurante rest = new Restaurante("Popeyes", "Av. Prof. Alípio de Barros, 748");
            Pagamento pay = new Pagamento();
            while(teste == true){
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("----------------------------");
                System.Console.WriteLine("----        Ifood       ----");
                System.Console.WriteLine("----------------------------");
                Console.ResetColor();
                System.Console.Write("Informe seu nome: ");
                nome = Console.ReadLine();
                System.Console.Write("Informe seu endereço atual: ");
                endereco = Console.ReadLine();
                Cliente c = new Cliente(nome, endereco);
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Aguarde...");
                Thread.Sleep(1800);
                if(c.Nome != "" && c.EnderecoAtual != null){
                    Console.Clear();
                    Console.ResetColor();
                    while(continuar2 == true){
                        Console.Clear();
                        continuar3 = true;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Console.WriteLine("-----   CARDÁPIO   -------");
                        System.Console.WriteLine("  Faça seu pedido abaixo  ");
                        System.Console.WriteLine("--------------------------");
                        Console.ResetColor();
                        System.Console.Write("Acompanhamento: ");
                        pay.itens[0] = Console.ReadLine();
                        System.Console.Write("Bebida: ");
                        pay.itens[1] = Console.ReadLine();
                        System.Console.Write("Sobremesa: ");
                        pay.itens[2] = Console.ReadLine();
                        Thread.Sleep(2000);
                        System.Console.WriteLine("Confirmar pedido? sim - s, não - n");
                        resposta = Console.ReadLine();
                        if(resposta == "s" || resposta == "S"){
                            pay.ProcessarPagamento();
                            if(pay.PedidoPago == true){
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                System.Console.WriteLine("---- Mostrar Dados do Pedido ---");
                                System.Console.WriteLine(rest.MostrarDados());
                                System.Console.WriteLine("--------------------------------");
                                System.Console.WriteLine("Cliente\n" + c.MostrarDados());
                                System.Console.WriteLine("--------------------------------");
                                Thread.Sleep(5000);
                                Console.ResetColor();
                                Console.Clear();
                                continuar2 = false;
                                teste = false; 
                            }else{
                                System.Console.WriteLine("Pedido cancelado!");
                                Thread.Sleep(2000);
                                System.Environment.Exit(0);
                            }
                        }else{
                            if(resposta == "n" || resposta == "N"){
                                while(continuar3 == true){
                                    System.Console.WriteLine("Deseja refazer o pedido? sim - s, não - n");
                                    string r = Console.ReadLine();
                                    if(r == "s" || r == "S"){
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("Aguarde...");
                                        Thread.Sleep(2500);
                                        Console.ResetColor();
                                        continuar3  = false;
                                    }else{
                                        if(r == "n" || r == "N"){
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine("Até logo...");
                                            Thread.Sleep(1000);
                                            Console.ResetColor();
                                            System.Environment.Exit(0);
                                        }else{
                                            System.Console.WriteLine("Dados Inválidos!");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }else{
                    Console.Clear();
                    Console.ResetColor();
                    System.Console.WriteLine("Dados inválidos! Tente novamente.");
                    Thread.Sleep(2000);
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            System.Console.WriteLine("\n-------------------- Pedido");
            System.Console.WriteLine("Acompanhamento: "+pay.itens[0]);
            System.Console.WriteLine("Bebida: "+pay.itens[1]);
            System.Console.WriteLine("Sobremesa: "+pay.itens[2]);
            System.Console.WriteLine("Total: R$"+ pay.ValorTotal);
            System.Console.WriteLine("-----------------------------\n");
            string p = pay.EntregarPedido();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("Status do pedido: "+p);
            Thread.Sleep(2500);
            Console.ResetColor();
            System.Environment.Exit(0);
        }
    }
}
