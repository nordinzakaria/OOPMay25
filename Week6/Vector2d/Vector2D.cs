// PUT THIS IN A 'CLASS LIBRARY' PROJECT

namespace MathVecLib
{
    public class Vector2D
    {
        public float X {  get; set; }
        public float Y { get; set; }

        public Vector2D()
        {
            X = 0; Y = 0;
        }

        public Vector2D(float x, float y)
        {
            X = x; Y = y;
        }

        public float Magnitude()
        {
            return 0;
        }

        public Vector2D add(Vector2D other)
        {
            return new Vector2D();
        }
    }
}
