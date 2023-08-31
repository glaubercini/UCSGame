using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Components.Characters;
using UCSGame.Components.FightingMoves;
using UCSGame.Scenarios;

namespace UCSGame.Base
{
    internal class Battle : Scene
    {
        public Enemy Enemy;

        public Character Who;

        public Scene Previous;

        public Battle(Enemy enemy, Scene previous)
        {
            Enemy = enemy;

            Previous = previous;

            Who = WhoStarts();

            Add("A batalha vai começar");
            Add("O sorteado para golpear primeiro foi:");
            Add($"---> {Who.Name} <---");
            Add("Pressione Enter para continuar...");
        }

        public Character WhoStarts()
        {
            Random random = new Random();

            if (random.Next(0, 2) == 0)
            {
                return State.GetPlayer();
            }
            else
            {
                return Enemy;
            }
        }

        public Character NextTurn()
        {
            if (Who == Enemy)
            {
                return State.GetPlayer();
            }
            else
            {
                return Enemy;
            }
        }

        public override Scene Options(string option)
        {
            do
            {
                FightingMove fightingMove = Who.NextFighntingMove();
                Console.WriteLine($"O jogador {Who.Name} escolheu {fightingMove.GetName()}");
                
                Character Next = NextTurn();
                Who.Fight(Next, fightingMove);

                Console.WriteLine($"Jodador {State.GetPlayer().Name} tem {State.GetPlayer().Life} de vida.");
                Console.WriteLine($"Jodador {Enemy.Name} tem {Enemy.Life} de vida.");
                Console.WriteLine("-----------------------------");

                Who = Next;

            } while (State.GetPlayer().Life > 0 && Enemy.Life > 0);

            if (State.GetPlayer().Life <= 0)
            {
                return new Death();
            }

            return Previous;
        }
    }
}
