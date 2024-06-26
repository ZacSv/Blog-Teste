﻿using Microsoft.Data.SqlClient;
using Blog.Screens.UserScreens;
using Blog.Screens.PerfilScreens;
using Blog.Screens.PostScreens;
namespace Blog
{

    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=BLOG;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=true";
        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();
            
            Load();

            Console.ReadKey();
            Database.Connection.Close();
 
        }   

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Meu blog");
            Console.WriteLine("--------------------");
            Console.WriteLine("Selecione a opção desejada");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de usuários");
            Console.WriteLine("2 - Gestão de perfil");
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão de tags");
            Console.WriteLine("5 - Gestão de posts");
            Console.WriteLine("6 - Vincular perfil/usuário");
            Console.WriteLine("7 - Vincular post/tag");
            Console.WriteLine("8 - Relatórios");
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch(option)
            {
                case 1: 
                    MenuUserScreen.Load();
                    break;
                case 2: 
                    MenuPerfilScreen.Load();
                    break;
                case 5: 
                    MenuPostScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }

        }
    }
}

