using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Base;
using UCSGame.Components.Characters;

namespace UCSGame.Scenarios
{
    internal class PlayerCreate : Scene
    {
        public PlayerCreate()
        {
            Add("### Criação do Jogador ###");
            Add("Informe o nome:");
        }

        public override Scene Options(string option)
        {
            Console.WriteLine($"O nome informado foi: {option}");

            Player p = State.GetPlayer();
            p.Name = option;

            return new City();
        }
    }
}
