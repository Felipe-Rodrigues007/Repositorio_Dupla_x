using System;
using System.Collections.Generic;

namespace Lista_de_produtos.classes
{
    public class Login
    {
        List<Marca> listaMarca = new List<Marca>();
        List<Produto> listaProduto = new List<Produto>();
        Marca marca = new Marca();
        Usuario usuario = new Usuario();
        Usuario UDeslog = new Usuario();
        Usuario usuarioC = new Usuario();
        

        Produto item = new Produto();
        Produto P= new Produto();

        public bool logado = false;
        public bool MenuMarca = true;
        public bool MenuProduto = true;


        public Login()
        {
            //   ------Cadastro------//
            Console.WriteLine("Digite o codigo:");
            usuarioC.codigo =int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome:");
            usuarioC.nome = Console.ReadLine();
            Console.WriteLine("Digite um e-mail:");
            usuarioC.email = Console.ReadLine();
            Console.WriteLine("Digite uma senha:");
            usuarioC.senha = int.Parse(Console.ReadLine());
            usuarioC.DataCadastro = DateTime.Now;
            usuario.Cadastrar(usuarioC);
            // usuario.Usuario(usuario.email,usuario.senha);


            //   ------Logar------//
            Logar(usuarioC);
            // menu entre//
            Console.WriteLine("Deseja continuar logado?(s/n)");
            string Rlog = Console.ReadLine();
            if (Rlog == "s")
            {
                Deslogar(UDeslog);
            }
            else
            {

            }


            /// Menu de Marca/Produto///
            Console.WriteLine($@"
Escolha o que eseja cadastrar
M - Marca
P - Produto
            ");
            string Rc = Console.ReadLine().ToUpper();
            switch (Rc)
            {
                case "M":
                    do
                    {
                        Console.WriteLine($@"
                        Escolha o que deseja fazer
                        1 - Cadastrar
                        2 - listar 
                        3- Deletar 
                        4- Sair
                        ");
                        string Rm = Console.ReadLine();
                        switch (Rm)
                        {
                            case "1":
                                Console.WriteLine("Digite o codigo da Marca:");
                                string codigoM = Console.ReadLine();
                                Console.WriteLine("Digite o Nome da Marca:");
                                string nomeM = Console.ReadLine();
                                marca.Cadastrar(new Marca(codigoM, nomeM, DateTime.Now));

                                break;
                            case "2":

                               listaMarca = marca.Listar();
                                foreach (Marca i in listaMarca)
                                {
                                    Console.WriteLine($@"
                                    Codigo da marca {i.codigo}
                                    Nome da Marca {i.NomeMarca}
                                    Data {DateTime.Now}
                                    ");
                                }
                                break;
                            case "3":
                                Console.WriteLine("Digite o nome da marca que vove quer deletar");
                                string Nome_marca = Console.ReadLine();
                                Marca atualizar = marca.ListaMarca.Find(item => item.NomeMarca == Nome_marca);
                                marca.Deletar(atualizar);
                                break;
                            case "4":
                                MenuMarca = false;
                                break;
                            default:
                                break;
                        }
                    } while (MenuMarca);
                    break;
                    case "P":
                      do
                      {
                        Console.WriteLine($@"
                        Escolha o que deseja fazer
                        1 - Cadastrar
                        2 - listar 
                        3- Deletar 
                        4- Sair
                        ");  
                        string Rp = Console.ReadLine();
                        switch (Rp)
                        {
                            case "1":
                            Console.WriteLine("Digite o nome do produto:");
                            item.NomeProduto= Console.ReadLine();
                            Console.WriteLine("Digite o preco do produto:");
                            item.Preco = float.Parse(Console.ReadLine());
                            P.Cadastrar(item);
                                break;
                            case "2":
                            listaProduto = P.Listar();
                                foreach (Produto i in listaProduto)
                                {
                                    Console.WriteLine($@"
                                    Nome do produto {i.NomeProduto}
                                    Preço do produto {i.Preco}
                                    Data {DateTime.Now}
                                    ");
                                }
                                break;
                            case "3":
                                Console.WriteLine("Digite o nome do produto");
                                string Nome_produto = Console.ReadLine();
                                Produto atualizar = P.ListaDeProdutos.Find(item => item.NomeProduto == Nome_produto);
                                P.Deletar(atualizar);
                                break;
                            case "4":
                                break;
                            default:
                                break;
                        }
                         
                      } while (MenuProduto);
                    break;
                default:
                    break;
            }




        }


        public string Logar(Usuario u)
        {
            // Usuario u1 = new Usuario();
            do
            {
                if (usuario.listaUsuario.Find(_usuario => _usuario.email == u.email).senha == u.senha)
                {
                    logado = true;
                    return "Login efetuado com sucesso";


                }
                else
                {
                    return "O usuario, ou a senha estão incorretos!";
                }

            } while (!logado);
        }
        public string Deslogar(Usuario Udeslog)
        {
            logado = false;
            return "Usuario deslogado com sucesso";
        }
    }
}
// Console.WriteLine("Digite a senha"); 
//            string email= Console.ReadLine();
//            Marca atualizar = marca.ListaMarca.Find(item => item.NomeMarca ==readline);
//            marca.Deletar(atualizar);