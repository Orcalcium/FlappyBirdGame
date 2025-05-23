using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdGame
{
    public class Character
    {
        public string Name { get; set; }
        //public Image CharacterImage { get; set; }

        public Character(string name)
        {
            Name = name;
            //CharacterImage = characterImage;
        }
    }
}
