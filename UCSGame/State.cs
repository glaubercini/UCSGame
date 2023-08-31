using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Components.Characters;

namespace UCSGame
{
    internal class State
    {
        private static Player playerInstance;

        public static Player GetPlayer()
        {
            if (playerInstance == null)
            {
                playerInstance = new Player();
            }

            return playerInstance;
        }
    }
}
