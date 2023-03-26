// See https://aka.ms/new-console-template for more information
using Console_Csharp_trainee;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        int numTabuada;

        

        Console.WriteLine("Tabuada de 1 a 10, digite o número: ");
        numTabuada = Convert.ToInt32(Console.ReadLine());
        FazTabuada(numTabuada);

        Clientes newCliente;
        newCliente = new Clientes();

        Console.WriteLine("Bem-vindo!!! \nPreencha com os seus dados abaixo para prosseguir");

        Console.WriteLine("Digite o seu nome: ");
        newCliente.nomeCompleto = Console.ReadLine();

        Console.WriteLine("Qual é a sua idade: ");
        newCliente.idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o seu RG, SOMENTE NÚMEROS: ");
        newCliente.rg = Console.ReadLine();

        Console.WriteLine("E-mail: ");
        newCliente.email = Console.ReadLine();

        Console.WriteLine("Qual, ou quais, pedidos lhe interessam no momento? \n(Informe o número do produto)" + 
            "\n1 - Web Site para meus negócios. \n2 - Site de apresentação pessoal. \n3 - App sobre meu empreendimento."
            + "\n4 - Site ou App para o meu negócio/a minha empresa.");
        newCliente.pedido = Convert.ToInt32(Console.ReadLine());
        //newCliente.pedido = Console.ReadLine();

        Console.WriteLine("Informe-nos o preço que oferta para o seu produto: ");
        newCliente.preco = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine($"Olá {newCliente.nomeCompleto}, muito obrigado por esolher os serviços da nossa comapania, \n" + 
            "iremos analisar o seu pedido e em breve lhe retornaremos" + 
            $" no email: {newCliente.email}.");

        Console.WriteLine("O seu pedido é: " + EscreverNomeDoPedido(newCliente.pedido));




        //FazTabuada(20);
    }



    public static void FazTabuada(int num)
	{
		int count = 1;
		do
		{
			Console.WriteLine($"{count} x {num} = " + count * num);
			count++;
		}while(count <= 10);
	}

    public static string EscreverNomeDoPedido(int num){
        if(num == 1)
        {
            return "Web Site para meus negócios";
        }

        else if(num == 2)
        {
            return "Site de apresentação pessoal";
        }

        else if(num == 3)
        {
            return "App sobre meu empreendimento";
        }

        else if(num == 4)
        {
            return "Site ou App para o meu negócio/a minha empresa";
        }

        else
        {
            return "Erro: Este valor não corresponde a nenhum pedido nosso, informe-nos novamente o seu pedido" + 
                " dentre as opções listadas: \n" + "1 - Web Site para meus negócios. \n2 - Site de apresentação pessoal. \n3 - App sobre meu empreendimento."
            + "\n4 - Site ou App para o meu negócio/a minha empresa." ;
        }

    }


}

