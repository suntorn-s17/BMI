namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display();
            CheckBmi(calBmi());
        }

        static void Display()
        {
            Console.WriteLine(@"
██████  ███    ███ ██      ██████  █████  ██       ██████ ██    ██ ██       █████  ████████  ██████  ██████  
██   ██ ████  ████ ██     ██      ██   ██ ██      ██      ██    ██ ██      ██   ██    ██    ██    ██ ██   ██ 
██████  ██ ████ ██ ██     ██      ███████ ██      ██      ██    ██ ██      ███████    ██    ██    ██ ██████  
██   ██ ██  ██  ██ ██     ██      ██   ██ ██      ██      ██    ██ ██      ██   ██    ██    ██    ██ ██   ██ 
██████  ██      ██ ██      ██████ ██   ██ ███████  ██████  ██████  ███████ ██   ██    ██     ██████  ██   ██ 
");
        }

        static double calBmi()
        {
            double weight, height, bmi;
            while (true)
            {
                Console.Write("Enter your weight(kg) : ");
                if (!double.TryParse(Console.ReadLine(), out weight) || weight < 0)
                {
                    Console.WriteLine("Invalid number.");
                    continue;
                }

                Console.Write("Enter your height(cm) : ");
                if (!double.TryParse(Console.ReadLine(), out height) || height < 0)
                {
                    Console.WriteLine("Invalid number.");
                    continue;
                }

                if (weight > 0 && height > 0)
                {
                    break;
                }
            }

            height = height / 100;
            bmi = weight / (height * height);
            return bmi;
        }

        static void CheckBmi(double bmi)
        {
            if (bmi > 40)
            {
                Console.WriteLine($"Result\nBMI = {bmi} (Obese Class III)");
            }
            else if (bmi >= 35 && bmi <= 39.9)
            {
                Console.WriteLine($"Result\nBMI = {bmi} (Obese Class II)");
            }
            else if (bmi >= 30 && bmi <= 34.9)
            {
                Console.WriteLine($"Result\nBMI = {bmi} (Obese Class I)");
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                Console.WriteLine($"Result\nBMI = {bmi} (Overweight)");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine($"Result\nBMI = {bmi} (Normal)");
            }
            else if (bmi >= 17 && bmi <= 18.4)
            {
                Console.WriteLine($"Result\nBMI = {bmi} (Mild Thinness)");
            }
            else if (bmi >= 16 && bmi <= 16.9)
            {
                Console.WriteLine($"Result\nBMI = {bmi} (Moderate Thinnes)");
            }
            else if (bmi >= 0 && bmi <= 15.9)
            {
                Console.WriteLine($"Result\nBMI = {bmi} (Severe Thinness)");
            }
        }
    }
}
