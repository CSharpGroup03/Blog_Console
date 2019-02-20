using SocialNetwork;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace InstanLike
{
    public class Program
    {
        public static IList<Post> Posts;
        public static Post _post;
        public static int Count;

        static void Main(string[] args)
        {
            int result = 1;
            while (result != 0)
            {
                string print = "Digite ";

                foreach (var valor in new SelectOption().Valores)
                {
                    print += " ( " + valor.Key + " ) Para " + valor.Value + "\n";
                }

                print += "Opção: ";

                Console.Write(print);
                result = int.Parse(Console.ReadLine());

                if (result != 1 && result != 2)
                {
                    Console.WriteLine("Opção inválida;");
                    continue;
                }

                Console.Write("Opção escolhida: " + result);
                if (Posts == null)
                    Posts = new List<Post>();

                int postEscolhido = 0;
                switch (result)
                {
                    case 0: //exit
                        break;
                    case 1:
                        _post = new Post();
                         Console.Write("Digite o Titulo do Post: ");
                        _post.Title = Console.ReadLine();

                        Console.Write("Digite o Conteudo ");
                        _post.Content = Console.ReadLine();

                        Count++;
                        _post.Codigo = Count;

                        Posts.Add(_post);
                        Console.WriteLine($"Post {_post.Title} criado com sucesso.");
                        break;

                    case 2:
                        Console.WriteLine("Escolha o post que deseja comentar: ");
                        foreach (var item in Posts)
                        {
                            Console.WriteLine($"Codigo: {item.Codigo} \nTitulo: {item.Title} ");
                        }

                        int valroLido = int.Parse(Console.ReadLine());
                        var achou = Posts.FirstOrDefault(x => x.Codigo == valroLido);

                        bool comentarNovamente = true;

                        if (achou != null)
                        {
                            while (comentarNovamente)
                            {
                                Console.WriteLine($"\n ==== Post Selecionado === \n Codigo: {achou.Codigo}  Titulo: {achou.Title} \n Comentario: ");
                                if (achou.Comments == null)
                                    achou.Comments = new List<Comment>();

                                achou.Comments.Add(new Comment(Console.ReadLine()));

                                Console.Write("\n\nDeseja comentar novamente [S][N]: ");
                                if (Console.ReadLine().ToUpper() == "S")
                                    comentarNovamente = true;
                                else
                                    comentarNovamente = false;
                            }
                            Console.WriteLine("\nComentarios \n\n ");
                            foreach (var item in achou.Comments)
                            {
                                Console.WriteLine($"{item.Text}");
                            }

                        }
                        
                        break;
                    default:
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
