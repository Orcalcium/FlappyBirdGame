using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdGame.Utilities
{
    public class Vertex
    {
        public float x;
        public float y;
        public Vertex(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class HitBox
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
        static private bool Inside(Vertex vert, HitBox hitbox, Transform2d vertTransform, Transform2d hitBoxTransform)
        {
            float transformedVertX = vert.x * vertTransform.scale.x + vertTransform.position.x;
            float transformedVertY = vert.y * vertTransform.scale.y + vertTransform.position.y;

            float hitboxMinX = hitbox.verts[0].x * hitBoxTransform.scale.x + hitBoxTransform.position.x;
            float hitboxMaxX = hitbox.verts[2].x * hitBoxTransform.scale.x + hitBoxTransform.position.x;
            float hitboxMinY = hitbox.verts[0].y * hitBoxTransform.scale.y + hitBoxTransform.position.y;
            float hitboxMaxY = hitbox.verts[2].y * hitBoxTransform.scale.y + hitBoxTransform.position.y;

            if (transformedVertX >= hitboxMinX && transformedVertX <= hitboxMaxX &&
                transformedVertY >= hitboxMinY && transformedVertY <= hitboxMaxY)
            {
                return true;
            }
            return false;
        }
        static public bool IsCollided(HitBox hitbox1, HitBox hitbox2,Transform2d transform1, Transform2d transform2)
        {

            
            foreach(Vertex vert in hitbox1.verts)
            {
                if(Inside(vert, hitbox2,transform1,transform2))
                {
                    return true;
                }
            }
                return false;
        }

    }
}
