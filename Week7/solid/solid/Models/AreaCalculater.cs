namespace solid
{

    internal class AreaCalculater
    {
        public double Radius { get; set; }

        public double CalculateArea(string shape)
        {
            if (shape == "circle")
            {
                return Math.PI * Radius * Radius;
            }

        }

    }
}