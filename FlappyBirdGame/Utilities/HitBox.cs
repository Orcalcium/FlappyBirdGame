using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdGame.Utilities
{
    internal class Vertex
    {
        public float x;
        public float y;
        public Vertex(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
    internal class HitBox
    {
        private Vertex[] verts = new Vertex[4]
        {
            new Vertex(-1f, -1f),
            new Vertex(-1f, 1f),
            new Vertex(1f, 1f),
            new Vertex(1f, 1f)
        };
        public HitBox(Vertex vert1, Vertex vert2, Vertex vert3, Vertex vert4)
        {
            this.verts[0] = vert1;
            this.verts[1] = vert2;
            this.verts[2] = vert3;
            this.verts[3] = vert4;
        }
        private bool Inside(Vertex vert, HitBox hitbox)
        {
            if (vert.x >= hitbox.verts[0].x && vert.x <= hitbox.verts[2].x && vert.y >= hitbox.verts[0].y && vert.y <= hitbox.verts[2].y)
            {
                return true;
            }
            return false;
        }
        public bool isCollided(HitBox hitbox1, HitBox hitbox2)
        {
            bool overlap = false;
            foreach(Vertex vert in hitbox1.verts)
            {
                if(Inside(vert, hitbox2))
                {
                    overlap = true;
                    break;
                }
            }
                return false;
        }

    }
}
