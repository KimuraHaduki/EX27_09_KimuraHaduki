using System;

namespace EX27
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder(Input("円柱　\n半径", 1, 1000), Input("高さ", 1, 1000));
            Sphere sphere = new Sphere(Input("\n球　\n半径", 1, 1000));
            TriangularPrism triangularPrism = new TriangularPrism(Input("\n三角柱\n底辺", 1, 1000), Input("底面の高さ", 1, 1000), Input("高さ", 1, 1000));

            Console.WriteLine("\n円柱\n表面積 :" + cylinder.GetSurface() + "cm²\n体積 :" + cylinder.GetVolume() + "cm³\n" +
                "\n球\n表面積 :" + sphere.GetSurface() + "cm²\n体積 :" + sphere.GetVolume() + "cm³\n" +
                "\n三角柱\n表面積 :" + triangularPrism.GetSurface() + "cm²\n体積 :" + triangularPrism.GetVolume() + "cm³");
        }

        static float Input(string message, float min, float max)
        {
            while (true)
            {
                float number;
                Console.Write(message + "(" + min + "～" + max + ")  : ");
                try
                {
                    number = float.Parse(Console.ReadLine());


                    if (min <= number && number <= max)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("入力エラーです");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("えらー");
                }
            }
        }
    }

    class Cylinder
    {
        float radius;
        float height;
        public Cylinder(float r,float h)
        {
            this.radius = r;
            this.height = h;
        }

        public float GetSurface()
        {
            return radius * radius * (float)Math.PI * 2 + radius * 2 * height;
        }

        public float GetVolume()
        {
            return radius * radius * (float)Math.PI * height;
        }
    }

    class Sphere
    {
        float radius;
        public Sphere(float r)
        {
            this.radius = r;
        }
        public float GetSurface()
        {
            return 4 * (float)MathF.PI * radius * radius;
        }

        public float GetVolume()
        {
            return 4 / 3 * (float)Math.PI * radius * radius * radius;
        }
    }

    class TriangularPrism
    {
        float bottom;
        float height;
        float top;
        public TriangularPrism(float b,float h,float t)
        {
            this.bottom = b;
            this.height = h;
            this.top = t;
        }
        public float GetSurface()
        {
            return bottom * height / 2 * 2 +
                ((float)Math.Sqrt(bottom * bottom + height * height) + bottom + height) * top;
        }

        public float GetVolume()
        {
            return bottom * height / 2 * top;
        }
    }
}
