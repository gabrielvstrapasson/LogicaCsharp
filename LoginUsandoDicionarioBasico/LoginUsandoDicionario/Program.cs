using System.ComponentModel.Design;
using System.Diagnostics;

Dictionary<string, string> usuarios = new Dictionary<string, string>();

Menu();

void Menu()
{
    Console.Clear();
    Console.WriteLine("1 - Login");
    Console.WriteLine("2 - Cadastre-se");
    Console.WriteLine("0 - Sair");

    int opcaoUsuario = int.Parse(Console.ReadLine());
    switch (opcaoUsuario)
    {
        case 1: LoginUsuario(); break;
        case 2: RegistroUsuario(); break;
        case 0: Console.WriteLine("Saindo..."); Thread.Sleep(1000); break;
    }
}

void RegistroUsuario()
{
    Console.WriteLine("Cadastro Usuario");
    // Pedir nome
    Console.Write("Usuário: ");
    string usuario = Console.ReadLine()!;
    usuarios[usuario] = "";
    Console.Write("Senha: ");
    string senha = Console.ReadLine()!;
    usuarios[usuario] += senha;

    Console.WriteLine("Usuário cadastrado com sucesso.");
    Thread.Sleep(2000);
    Menu();

}
void LoginUsuario()
{
    Console.WriteLine("Login");
    Console.Write("Usuário: ");
    string usuarioLogin = Console.ReadLine()!;
    Console.Write("Senha: ");
    string usuarioSenha = Console.ReadLine()!;

        if (usuarios.ContainsKey(usuarioLogin))
        {
            if (usuarios[usuarioLogin] == usuarioSenha)
            {
                Console.WriteLine($"Login Bem Sucedido. Seja Bem-Vindo");
            } else 
            {
                Console.WriteLine("Senha Inválida!");
                Thread.Sleep(2000);
                Menu();
            }
        } else
        {
            Console.WriteLine("Usuário Inválido");
            Thread.Sleep(2000);
            Menu();
        }
}    


