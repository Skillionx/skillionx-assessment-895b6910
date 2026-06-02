using System;

namespace DataSimulator
{
    public class SensorData
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string SensorType { get; set; }
        public double Value { get; set; }
    }

    public class DataGenerator
    {
        private readonly Random _random = new Random();

        public SensorData Generate()
        {
            return new SensorData
            {
                SensorType = GetRandomSensorType(),
                Value = GetRandomValue(SensorType)
            };
        }

        private string GetRandomSensorType()
        {
            string[] sensorTypes = { "Temperature", "Humidity", "Pressure" };
            return sensorTypes[_random.Next(sensorTypes.Length)];
        }

        private double GetRandomValue(string sensorType)
        {
            switch (sensorType)
            {
                case "Temperature":
                    return _random.NextDouble() * 40.0; // 0-40 Celsius
                case "Humidity":
                    return _random.NextDouble() * 100.0; // 0-100%
                case "Pressure":
                    return _random.NextDouble() * 1000.0 + 900.0; // 900-1900 hPa
                default:
                    return 0.0;
            }
        }
    }

    // Hoofdprogramma (voor demonstratie, moet uitgebreid worden voor de pipeline)
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting data simulation...");
            var generator = new DataGenerator();

            for (int i = 0; i < 10; i++)
            {
                var data = generator.Generate();
                Console.WriteLine($"Generated: {{data.SensorType}} = {{data.Value:F2}} at {{data.Timestamp}}");
                // Hier zou de data naar een stream gestuurd moeten worden.
            }
            Console.WriteLine("Simulation finished.");
        }
    }
}