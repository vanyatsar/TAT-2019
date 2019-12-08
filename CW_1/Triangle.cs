namespace CW_1
{
    class Triangle
    {
        Point[] points;
        double[] sides;

        public Triangle(Point[] points)
        {
            this.points = new Point[3];
            for (int i = 0; i < 3; i++)
            {
                this.points[i] = new Point(points[i]);
            }
            SidesCalculation();
            SortSides();
        }
        void SidesCalculation()
        {
            sides = new double[3];
            sides[0] = points[0].Distance(points[1]);
            sides[1] = points[1].Distance(points[2]);
            sides[2] = points[2].Distance(points[0]);
        }
        public bool Equals(Triangle triangle)
        {
            for (int i = 0; i < 3; i++)
            {
                if (this.sides[i] != triangle.sides[i])
                {
                    return false;
                }
            }
            return true;
        }
        private void SortSides()
        {
            double temp;
            for (int t = 0; t < 2; t++)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (sides[i] < sides[i + 1])
                    {
                        temp = sides[i + 1];
                        sides[i + 1] = sides[i];
                        sides[i] = temp;
                    }

                }
            }
        }
        public override string ToString()
        {
            return "A: " + this.points[0].ToString() + " B: " + this.points[1].ToString() + " C: " + this.points[2].ToString();
        }
    }
}
