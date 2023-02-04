using System.Collections;
using System.Net.Mail;

internal class Program
{
    static void Main(string[] args)
    {
        ArrayList cadastros = new ArrayList();
        bool preCadastro = true;
        bool usuarioLogado = false;
        Console.WriteLine("Bem vindo!");
        Console.WriteLine();

        while(preCadastro)
        {
            Console.WriteLine("Digite o nome do usuario:");
            cadastros.Add(Console.ReadLine());
            Console.WriteLine("Agora digite sua senha: ");
            cadastros.Add(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Voce deseja cadastrar mais um usuario?");
            Console.WriteLine("Aperte S se quiser e qualquer outra tecla em caso contrario: ");
            if (Console.ReadKey().Key != ConsoleKey.S) preCadastro = false;
            Console.WriteLine();
        }

        Console.WriteLine();
        while (!usuarioLogado)
        {
            Console.WriteLine("Digite o nome do usuario: ");
            var usuario = Console.ReadLine();
            for(int i = 0; i < cadastros.Count; i++)
            {
                if ((string)cadastros[i] == usuario)
                {
                    usuarioLogado = true;
                    bool senhaCerta = false;
                    int tentativas = 0;
                    while (!senhaCerta)
                    {
                        Console.WriteLine("Digite a senha: ");
                        var senha = Console.ReadLine();
                        if ((string)cadastros[i + 1] == senha) senhaCerta = true;
                        else
                        {
                            Console.WriteLine("Senha incorreta!");
                            if(tentativas < 3)
                            {
                                Console.WriteLine("Tente novamente!");
                                tentativas++;
                            }
                            else
                            {
                                Console.WriteLine("Muitas tentativas erradas. Acesso negado!");
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}