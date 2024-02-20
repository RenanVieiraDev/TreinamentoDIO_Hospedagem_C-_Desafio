using SistemaHospedagem.models;
bool exitprogram = false;
MenuSecundario menuSecundario = new MenuSecundario();


//Menu abertura do programa de hospedagem
while (exitprogram == false) 
{
    Console.WriteLine("####### Sistema de Hospedagem Master > Home ####### \n");

    Console.WriteLine("Menu: Escolha o comando!");
    Console.WriteLine("[1] Hospedes");
    Console.WriteLine("[2] Suites");
    Console.WriteLine("[3] Reservas");
    Console.WriteLine("[4] Sair do programa");

    string opcaoMenu = Console.ReadLine();

    switch (opcaoMenu)
    {
        case "1":
            menuSecundario.MostraMenuDoHospide();
            break;
        case "2":
            menuSecundario.MostraMenuDeSuite();
            break; 
        case "3":
            menuSecundario.MostraMenuReserva();
            break; 
        case "4":
            exitprogram = true;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opção invalida, Por Favor escolha uma opção listada!");
            break;

    }


}