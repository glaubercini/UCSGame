using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Base;
using UCSGame.Components.Characters;

namespace UCSGame.Scenarios
{
    internal class City : Scene
    {
        public City()
        {
            Add($"A cidade é fria {State.GetPlayer().Name}...");
            Add("Você sente frio...");
            Add("─────────█▄██▄█");
            Add("█▄█▄█▄█▄█▐█┼██▌█▄█▄█▄█▄█");
            Add("███┼█████▐████▌█████┼███");
            Add("█████████▐████▌█████████");
            Add("1) Entrar no Castelo e se abrigar.");
            Add("2) Entrar na loja.");
            Add("3) Voltar para o Menu");
        }

        public override Scene Options(string option)
        {
            if (option == "1")
            {
                return new Castle();
            }

            if (option == "2")
            {
                return new Store();
            }

            return new Menu();
        }
    }
}
