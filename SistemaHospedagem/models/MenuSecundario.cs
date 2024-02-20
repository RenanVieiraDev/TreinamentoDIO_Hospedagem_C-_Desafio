using System;

namespace SistemaHospedagem.models
{
    public class MenuSecundario
    {

        private List<Pessoa> pessoas = new List<Pessoa>();
        private List<Suite> suites = new List<Suite>();
        private List<Reserva> reservas = new List<Reserva>();

        public void MostraMenuDoHospide()
        {
            bool exitMenu = false;
            while (exitMenu == false) 
            {
                Console.Clear();
                Console.WriteLine("####### Sistema de Hospedagem Master > Hospede #######");

                Console.WriteLine("Menu:");
                Console.WriteLine("[1] Cadastrar Hospede");
                Console.WriteLine("[2] Remover Hospede");
                Console.WriteLine("[3] Listar Hospedes");
                Console.WriteLine("[4] Sair do menu de Hospedes");


                string opcaoMenu = Console.ReadLine();

                switch (opcaoMenu)
                {
                   case "1": //mostra o menu do  cadastramento de um hospede
                        Console.Clear();
                        Console.WriteLine("####### Sistema de Hospedagem Master > Hospede ####### \n");
                        Console.WriteLine("Cadastro de hospede: \n");
                        Console.Write("Insira o nome:");
                        string nome = Console.ReadLine();
                        Console.Write("Insira o sobrenome:");
                        string sobrenome = Console.ReadLine();
                        this.pessoas.Add(new Pessoa(nome, sobrenome, this.pessoas.Count+1)); //adiciona o obj hospide na variavel lista de hospede
                        break;
                   case "2": //Mostra o menu de exclusão de hospede
                        Console.Clear();
                        if (this.pessoas.Count <= 0)
                        {
                            Console.WriteLine("Nenhum hospede cadastrado!");
                            Console.ReadLine();
                            break;
                        }
                        Console.Write("Insira o id do hospede que voce deseja remover ou precione qualquer letra para sair:");
                        string comandoOuIdHospede = Console.ReadLine();
                        //if (comandoOuIdHospede == "E") break;
                        foreach (var pessoa in this.pessoas)
                        {
                            if (comandoOuIdHospede == pessoa.PegaId().ToString())
                            {
                                Console.WriteLine($"Hospede {pessoa.PegaNomecompleto()} excluido!");
                                this.pessoas.Remove(pessoa);
                                Console.ReadLine();
                                break;
                            }
              
                        }
                        break;
                   case "3": //Mostra a listagem de todos os hospedes
                        Console.Clear();
                        if (this.pessoas.Count <= 0)
                        { 
                            Console.WriteLine("Nenhum hospede cadastrado!");
                            Console.ReadLine();
                            break;
                        }
                        Console.WriteLine("Lista de Hospede:");
                        for (var i = 0; i < this.pessoas.Count; i++ ) Console.WriteLine($"Id:{this.pessoas[i].PegaId()} - Hospode:{this.pessoas[i].PegaNomecompleto()}");
                        Console.ReadLine();
                        break;
                   case "4": //Sai do menu de hospede
                        Console.Clear();
                        exitMenu = true;
                        break;
                   default:
                        Console.Clear();
                        Console.WriteLine("Opção invalida, Por Favor escolha uma opção listada!");
                        break;

                }
            }
        }

        public void MostraMenuDeSuite()
        {
            bool exitMenu = false;
            while (exitMenu == false)
            {
                Console.Clear();
                Console.WriteLine("####### Sistema de Hospedagem Master > Suite #######");

                Console.WriteLine("Menu:");
                Console.WriteLine("[1] Cadastrar Suite");
                Console.WriteLine("[2] Remover Suite");
                Console.WriteLine("[3] Listar Suites");
                Console.WriteLine("[4] Sair do menu de Suites");


                string opcaoMenu = Console.ReadLine();

                switch (opcaoMenu)
                {
                    case "1": //mostra o menu do  cadastramento de um hospede
                        Console.Clear();
                        Console.WriteLine("####### Sistema de Hospedagem Master > Suite ####### \n");
                        Console.WriteLine("Cadastro de Suite: \n");

                        Console.Write("Digite o tipo de suite:");
                        string tipoSuite = Console.ReadLine();

                        Console.Write("Digite a capacidade da suite:");
                        int capacidade;
                        int.TryParse(Console.ReadLine(), out capacidade);
                        
                        Console.Write("Digite o valor da diaria em R$ da suite:");
                        decimal valorDiaria;
                        decimal.TryParse(Console.ReadLine(), out valorDiaria);

                        this.suites.Add(new Suite(this.suites.Count+1, tipoSuite, capacidade, valorDiaria));

                        break;
                    case "2": //Mostra o menu de exclusão de suites
                        Console.Clear();
                        if (this.suites.Count <= 0)
                        {
                            Console.WriteLine("Nenhuma suite cadastrada!");
                            Console.ReadLine();
                            break;
                        }
                        Console.Write("Insira o id da suite que voce deseja remover ou precione qualquer letra para sair:");
                        string comandoOuIdSuite = Console.ReadLine();
                       
                        foreach (var suite in this.suites)
                        {
                            if (comandoOuIdSuite == suite.PegaId().ToString())
                            {
                                Console.WriteLine($"Suite do tipo {suite.PegaTipo()} excluido!");
                                this.suites.Remove(suite);
                                Console.ReadLine();
                                break;
                            }

                        }
                        break;
                    case "3": //Mostra a listagem de todos os hospedes
                        Console.Clear();
                        if (this.suites.Count <= 0)
                        {
                            Console.WriteLine("Nenhuma suite cadastrada!");
                            Console.ReadLine();
                            break;
                        }
                        Console.WriteLine("Lista de suites:");
                        for (var i = 0; i < this.suites.Count; i++)
                        {
                            Console.WriteLine($"Id:{this.suites[i].PegaId()} - Suite:{this.suites[i].PegaTipo()} - Cap.: {this.suites[i].PegaCapacidade()} - Val.Diaria: R$ {this.suites[i].PegaValorDiaria()}");
                        } 
                        Console.ReadLine();
                        break;
                    case "4": //Sai do menu de hospede
                        Console.Clear();
                        exitMenu = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção invalida, Por Favor escolha uma opção listada!");
                        break;

                }
            }
        }

        public void MostraMenuReserva()
        {
            bool exitMenu = false;
            while (exitMenu == false)
            {
                Console.Clear();
                Console.WriteLine("####### Sistema de Hospedagem Master > Reservas #######");

                Console.WriteLine("Menu:");
                Console.WriteLine("[1] Realizar reserva");
                Console.WriteLine("[2] Sair do menu de reservas");

                string opcaoMenu = Console.ReadLine();

                switch (opcaoMenu)
                {
                    case "1":
                        Suite suiteSelecionada = new Suite(0,"Padrão",2,15);
                        List<Pessoa> pessoasSelecionadas = new List<Pessoa>();
                        int qtdDias = 0;
                        Console.Clear();
                        Console.WriteLine("####### Sistema de Hospedagem Master > Reservas ####### \n");
                        Console.WriteLine("Cadastro de Reserva: \n");


                        Console.WriteLine("Suites:");
                        foreach (var suite in this.suites) Console.WriteLine($"id:[{suite.PegaId()}] - Suite {suite.PegaTipo()} - CAP. {suite.PegaCapacidade()} - Val. dia {suite.PegaValorDiaria()}");
                        Console.Write("Selecione a Suite pelo id:");
                        int suiteId; 
                        int.TryParse(Console.ReadLine(), out suiteId);    
                        foreach (var suite in this.suites) if (suite.PegaId() == suiteId) { suiteSelecionada = suite; break; }

                        Console.WriteLine("hospedes:");
                        foreach (var pessoa in this.pessoas) Console.WriteLine($"id:[{pessoa.PegaId()}] - Hospede {pessoa.PegaNomecompleto()}");
                        Console.Write("Digite os ids dos hospedes que ira se hospedar. EX: 1,2,3,4 ..:");
                        string idshospedesEmStrings = Console.ReadLine();
                        string[] idshospedes = idshospedesEmStrings.Split(",");
                        foreach (var id in idshospedes)
                        {
                            int idAtual;
                            int.TryParse(id, out idAtual);
                            foreach (var pessoa in this.pessoas)
                            {
                                if(pessoa.PegaId() == idAtual) pessoasSelecionadas.Add(pessoa);
                            } 
                        }
                        Console.WriteLine("Digite a quantidade de dias:");
                        int.TryParse(Console.ReadLine(),out qtdDias);
                        Reserva reservaAgora = new Reserva(pessoasSelecionadas, suiteSelecionada, qtdDias);
                        
                        Console.WriteLine(reservaAgora.reservarAgora());

                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        exitMenu = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção invalida, Por Favor escolha uma opção listada!");
                        break;

                }
            }
        }
    }
}
