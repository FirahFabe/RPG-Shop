using System;
using System.Collections.Generic;
using System.Text;

namespace RPGStore
{
    class Player
    {
        private string name;
        private int gold;
        private int newgold;

        public Player(string playerName, int playerGold)
        {
            name = playerName;
            gold = playerGold;
        }

        public string Name { get; set; }
        public int Gold {get { return gold; }set {value = gold; }}
        public int NewGold { get { return newgold; } set { value = newgold; } }


        public void SetNewGold(int newGold)
        {
            newgold = newGold;
            gold = newgold;
        }
    }
}
