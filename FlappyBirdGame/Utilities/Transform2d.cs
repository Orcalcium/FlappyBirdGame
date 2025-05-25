using FlappyBirdGame.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdGame
{
    public class Transform2d
    {
        public Vector2 position { get; set; }
        public Vector2 scale { get; set; }
        //no rotation since not needed
        public Transform2d(Vector2 position, Vector2 scale)
        {
            this.position = position;
            this.scale = scale;
        }
        public Transform2d()
        {
            this.position = new Vector2(0, 0);
            this.scale = new Vector2(1, 1);
        }
        public void Translate(Vector2 vec)
        {
            position.x += vec.x;
            position.y += vec.y;
        }
    }
}

