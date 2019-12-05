namespace DEV_6
{
    class Car
    {
        /// <summary>
        /// Brand of the car
        /// </summary>
        public string Brand { get; }

        /// <summary>
        /// Model of the car
        /// </summary>
        public string Model { get; }

        private int _price;

        /// <summary>
        /// Price of the car
        /// </summary>
        public int Price
        {
            get
            {
                return _price;
            }
            private set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="brand">Brand of the car</param>
        /// <param name="model">Model of the car</param>
        /// <param name="price">Price of the car</param>
        public Car(string brand, string model, int price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }
    }
}
