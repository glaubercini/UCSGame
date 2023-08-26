using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Base;

namespace UCSGame.Scenarios
{
    internal class Castle : Scene
    {
        public Castle()
        {
            Add("Você está dentro do castelo...");
            Add("É mais quente aqui.");
            Add("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Add("█░░╦─╦╔╗╦─╔╗╔╗╔╦╗╔╗░░█");
            Add("█░░║║║╠─║─║─║║║║║╠─░░█");
            Add("█░░╚╩╝╚╝╚╝╚╝╚╝╩─╩╚╝░░█");
            Add("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Add("1) Exibir lista de atividades:");
        }

        public override Scene Options(string option)
        {
            if (option == "1")
            {
                string[] items = new string[]
                {
                    "VARRER",
                    "LIMPAR",
                    "TIRAR PÓ",
                    "MATAR DRAGÃO"
                };

                List castleLst = new List(items);

                return castleLst;
            }

            Environment.Exit(0);

            return null;
        }
    }
}
