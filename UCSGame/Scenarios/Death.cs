using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Base;
using UCSGame.Components.Characters;

namespace UCSGame.Scenarios
{
    internal class Death : Scene
    {
        public Death()
        {
            Add("Você morreu...");
            Add("╔╦══╦══╦══╦══╦═╦╗╔╦╗");
            Add("║║║║║╔╗║░░║░░║═╣║║║║");
            Add("║║║║║╚╝║╔╗╣╔╗╣═╣╚╝║║");
            Add("║╚╩╩╩══╩╝╚╩╝╚╩═╩══╝║");
            Add("1) Aperte enter para finalizar o jogo!");
        }

        public override Scene Options(string option)
        {
            Environment.Exit(0);
            return null;
        }
    }
}
