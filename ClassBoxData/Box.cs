using System;


namespace _1
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return this.Length; }
           private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value; 
            }
        }

        public double Width
        {
            get { return this.Width; }
            private set {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value; 
            }
        }

        public double Height
        {
            get { return this.Height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value; 
            }
        }

        public string CalculateVolume()
        {
            double result =  this.length * this.width * this.height;
            return $"Volume - {result:f2}";
        }

        public string CalculateLateralSurfaceArea()
        {
            double result = (2 * this.length * this.height) + (2 * this.width * this.height);
            return $"Lateral Surface Area - {result:f2}";
        }

        public string CalculateSurfaceArea()
        {
            double result = (2 * this.length * this.width) + (2 * this.length * this.height) + (2 * this.width * this.height);
            return $"Surface Area - {result:f2}";
        }
    }
}
