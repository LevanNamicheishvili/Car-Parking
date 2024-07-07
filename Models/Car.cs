using System;

namespace CarParkingSystem.Models
{
    public class Car
    {
        private string licensePlate;
        private string model;
        private string color;
        private string size;

        public string LicensePlate
        {
            get { return licensePlate; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("License plate cannot be empty.");
                }
                licensePlate = value;
            }
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be empty.");
                }
                model = value;
            }
        }

        public string Color
        {
            get { return color; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Color cannot be empty.");
                }
                color = value;
            }
        }

        public string Size
        {
            get { return size; }
            set
            {
                if (value == "large" || value == "medium" || value == "small")
                {
                    size = value;
                }
                else
                {
                    throw new ArgumentException("Size must be 'large', 'medium', or 'small'.");
                }
            }
        }

        public Car(string licensePlate, string model, string color, string size)
        {
            LicensePlate = licensePlate ?? throw new ArgumentNullException(nameof(licensePlate));
            Model = model ?? throw new ArgumentNullException(nameof(model));
            Color = color ?? throw new ArgumentNullException(nameof(color));
            Size = size ?? throw new ArgumentNullException(nameof(size));
        }

        public override string ToString()
        {
            return $"Car [License Plate: {LicensePlate}, Model: {Model}, Color: {Color}, Size: {Size}]";
        }
    }
}
