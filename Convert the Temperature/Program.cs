namespace Convert_the_Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double celsius = 36.50;
            double celsius = 122.11;
            double[] doubles = { celsius + 273.15, celsius * 1.80 + 32.00 };

            var result = ConvertTemperature(celsius);

            double[] ConvertTemperature(double celsius)
            {
              
                return doubles;
            }

        }

    }
}
