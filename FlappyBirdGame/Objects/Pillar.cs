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
        public Button button { get; private set; }


        public Pillar(float x, float y, float width, float height, bool isTop)
        {
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
            button = new Button();

            button.Location = new Point((int)transform.position.x, (int)transform.position.y);
            button.Size = new Size((int)width, (int)height);

        }
        public void Update()
        {
            this.button.Location = new Point((int)transform.position.x, (int)transform.position.y);
        }
    }
}
