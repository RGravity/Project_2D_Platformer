using System;
using System.Drawing;
using GXPEngine;

namespace GXPEngine
{
    class Level : GameObject
    {
        public Player1 _player1;
        public Player2 _player2;

        public Level()
        {
            _player1 = new Player1();
            _player1.SetXY(500, 500);
            AddChild(_player1);

            _player2 = new Player2();
            _player2.SetXY(300, 300);
            AddChild(_player2);
        }
    }
}
