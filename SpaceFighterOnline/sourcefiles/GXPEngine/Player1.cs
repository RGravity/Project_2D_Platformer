using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GXPEngine
{
    class Player1 : Sprite
    {
        private AnimSprite animSpritePlayer;

		float speedX;
		float gravity;


        public Player1()
            : base("colors.png")
        {
            /*Animation here*/

            //animSpritePlayer = new AnimSprite("barryBackup.png", 7, 1);
            //AddChild(animSpritePlayer);
        }


    }
}
