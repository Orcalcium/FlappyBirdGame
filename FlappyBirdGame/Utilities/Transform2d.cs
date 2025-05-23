using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdGame.Utilities
{
    internal class Transform2d
    {
        Vector2 position { get; set; }
        Vector2 scale { get; set; }
        //no rotation since not needed
        public Transform2d()
        {
            this.position = new Vector2(0,0);
            this.scale = new Vector2(1,1);
        }
        public void Translate(Vector2 vec)
        {
            position .X += vec.X;
            position .Y += vec.Y;
        }
    }
}
