using FlappyBirdGame.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdGame.Objects
{
    public class Character
    {
        public string name { get; set; }
        public Transform2d transform { get; set; } = new Transform2d();
        public HitBox hitbox { get; set; }
        public bool isTop { get; set; }
        public Button button { get; private set; }

        public float width;
        public float height;

        public Character(float x, float y, float width, float height,string name)
        {
            this.width = width;
            this.height = height;
            this.transform.position.x = x;
            this.transform.position.y = y;
            this.name = name;
            hitbox = new HitBox(
                new Vertex(-width / 2, -height / 2),
                new Vertex(-width / 2, height / 2),
                new Vertex(width / 2, height / 2),
                new Vertex(width / 2, -height / 2)
            );

            // Initialize the button
            button = new Button();
            button.BackgroundImage = AppGlobals.characterImage;
            button.BackgroundImageLayout = ImageLayout.Stretch;

            button.Location = new Point((int)transform.position.x-(int)width/2, (int)transform.position.y-(int)height/2);
            button.Size = new Size((int)width, (int)height);

        }
        public void Update()
        {
            this.button.Location = new Point((int)transform.position.x - (int)width/ 2, (int)transform.position.y - (int)height / 2);
            this.button.Size = new Size((int)width, (int)height);
            this.hitbox = new HitBox(
                new Vertex(-width / 2, -height / 2),
                new Vertex(-width / 2, height / 2),
                new Vertex(width / 2, height / 2),
                new Vertex(width / 2, -height / 2)
            );

        }
        //public Image CharacterImage { get; set; }
    }
}
