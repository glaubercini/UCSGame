using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Base;

namespace UCSGame.Scenarios
{
    internal class Store : Scene
    {
        public Store()
        {
            Add("Você está na loja...");
            Add("           _            ");
            Add("      _ - '_' - _       ");
            Add("   _ - ' _____ ' - _    ");
            Add("_ - ' ___________ ' - _ ");
            Add(" | ___ ||||||||| ___ |  ");
            Add(" | ___ ||||||||| ___ |       ░░░░░░░░░░░░░░░░░");
            Add(" | ___ ||||||||| ___ |       ░░░░▄██▄░░░░░░░░░");
            Add(" | ___ ||||||||| ___ |       ░░▄██████▄░░░░░░░");
            Add(" | ___ ||||||||| ___ |       ░▀██┼██┼██▀░░░░░░");
            Add(" | ___ ||||||||| ___ |       ▄▄████████▄░░░░░░");


            Add("1) Ver a lista de itens");
            Add("2) Voltar para a cidade");
        }

        public override Scene Options(string option)
        {
            if (option == "1")
            {
                string[] items = new string[]
                {
                    "ROUPAS",
                    "COMIDA",
                    "CARRUAGENS",
                    "ARMAS",
                    "POÇÕES"
                };

                List storeList = new List(items);

                return storeList;
            }

            return new City();
        }

        public void ItemList()
        {
            Console.WriteLine("Lista de itens para venda:");
            Console.WriteLine("Item 1");
            Console.WriteLine("Item 2");
            Console.WriteLine("Item 3");
            Console.WriteLine("Item 4");
            Console.WriteLine("Item 5");

            Console.WriteLine("Qual item você deseja comprar?");

            string option = Console.ReadLine();

            Console.WriteLine($"O personagem comprou o item {option}");
        }
    }
}
