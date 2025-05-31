using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Rectangle

    {

        public float width;

        public float height;

        public float posX, posY;

        public Rectangle()

        {

            width = 1;

            height = 1;

            posX = 0;

            posY = 0;

        }
        public Rectangle(float width, float height, float posX, float posY)

        {

            this.width = width;

            this.height = height;

            this.posX = posX;

            this.posY = posY;

        }

        public float Area()

        {

            return width * height;

        }
        public float Perimeter()

        {

            return 2 * (width + height);

        }

    }

}
