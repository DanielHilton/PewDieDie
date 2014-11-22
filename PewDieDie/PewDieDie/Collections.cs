using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PewDieDie
{
    public enum Direction
    {
        Up, Down, Left, Right
    };

    public enum GameState
    {
        MAIN_MENU, GAME, PAUSE, GAME_OVER
    };

    public class Textures
    {
        public const int PEWDIE = 0;
        public const int BACKGROUND = 1;
        public const int LOGO = 2;
        public const int STAR = 3;
        public const int PLAY_BTN = 4;
        public const int PLAY_BTN_HOVER = 5;
    };

    public class Sounds
    {
        public const int INTRO = 0;
    }
}
