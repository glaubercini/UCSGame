using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Base;
using UCSGame.Components.Characters;

namespace UCSGame.Scenarios
{
    internal class Castle : Scene
    {
        public Castle()
        {
            Add("Você está dentro do castelo...");
            Add("É mais quente aqui.");
            Add("Porém, um inimigo feroz se aproxima.");
            Add("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Add("█░░╦─╦╔╗╦─╔╗╔╗╔╦╗╔╗░░█");
            Add("█░░║║║╠─║─║─║║║║║╠─░░█");
            Add("█░░╚╩╝╚╝╚╝╚╝╚╝╩─╩╚╝░░█");
            Add("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Add("1) Se preparar para a batalha!");
            Add("2) Fugir");
        }

        public override Scene Options(string option)
        {
            if (option == "1")
            {
                return new Battle(new Enemy("Espírito do Soldado"), this);
            }
            else
            {
                return new City();
            }
        }
    }
}
