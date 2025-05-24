namespace FlappyBirdGame
{
    public class Vector2
    {
        public float x { get; set; }
        public float y { get; set; }
        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        // Addition of two Vector2 instances
        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x + b.x, a.y + b.y);
        }

        // Subtraction of two Vector2 instances
        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x - b.x, a.y - b.y);
        }

        // Multiplication of a Vector2 by a scalar
        public static Vector2 operator *(Vector2 a, float scalar)
        {
            return new Vector2(a.x * scalar, a.y * scalar);
        }

        // Multiplication of a scalar by a Vector2
        public static Vector2 operator *(float scalar, Vector2 a)
        {
            return new Vector2(a.x * scalar, a.y * scalar);
        }

        // Division of a Vector2 by a scalar
        public static Vector2 operator /(Vector2 a, float scalar)
        {
            if (scalar == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return new Vector2(a.x / scalar, a.y / scalar);
        }
    
    }
}