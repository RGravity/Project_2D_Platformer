using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GXPEngine
{
    class Player2 : Sprite
    {
        private AnimSprite animSpritePlayer;

        public Player2()
            : base("colors.png")
        {
            /*Animation here*/

            //animSpritePlayer = new AnimSprite("barryBackup.png", 7, 1);
            //AddChild(animSpritePlayer);
        }
    }
}
