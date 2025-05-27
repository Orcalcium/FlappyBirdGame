using FlappyBirdGame.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdGame.Objects
{
    internal class Pillar
    {
        public Transform2d transform { get; set; } = new Transform2d();
        public HitBox hitbox { get; set; }
        public bool isTop { get; set; }
        public Panel panel { get; private set; }

        public float width;
        public float height;
        public Pillar(float x, float y, float width, float height, bool isTop)
        {
            this.width = width;
            this.height = height;
            this.transform.position.x = x;
            this.transform.position.y = y;
            hitbox = new HitBox(
                new Vertex(-width / 2, -height / 2),
                new Vertex(-width / 2, height / 2),
                new Vertex(width / 2, height / 2),
                new Vertex(width / 2, -height / 2)
            );

            this.isTop = isTop;

            // Initialize the button
            panel = new Panel {
                Location = new Point((int)transform.position.x - (int)width / 2, (int)transform.position.y - (int)height / 2),
                Size = new Size((int)width, (int)height),
                BackColor = Color.White
            };
        }
        public void Update()
        {
            this.panel.Location = new Point((int)transform.position.x - (int)width / 2, (int)transform.position.y - (int)height / 2);
        }
    }
}

