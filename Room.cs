namespace Homework_Template
{
    class Room
    {
        private int length;
        private int width;
        private int height;
        private int area;
        private int gallons;

        public Room(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;

            ComputeArea();
            ComputeGallons();
        }

        private void ComputeArea()
        {
            area = 2 * (length * height) + 2 * (width * height);
        }

        private void ComputeGallons()
        {
            gallons = area / 350;

            if (area % 350 != 0)
            {
                gallons++;
            }
        }

        public int Length
        {
            get { return length; }
        }

        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return height; }
        }

        public int Area
        {
            get { return area; }
        }

        public int Gallons
        {
            get { return gallons; }
        }
    }
}