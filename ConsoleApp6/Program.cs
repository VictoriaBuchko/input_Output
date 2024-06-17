namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Пользователь вводит с клавиатуры показания температуры. Перевести температуру из Цельсия в Фаренгейты.
            Console.WriteLine("Task 1");
            Console.Write("Enter temperature in Celsius: ");
            float celsius = float.Parse(Console.ReadLine());
            float fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);


            //2) Напишите программу, которая вычисляет объём шара.
            Console.WriteLine("\nTask 2");
            float radius;
            Console.Write("Enter the radius of the ball: ");
            radius = float.Parse(Console.ReadLine());
            double volume = (4.0 / 3.0) * Math.PI * radius * radius * radius;
            Console.WriteLine("Ball volume: " + volume);


            //3) Пользователь вводит с клавиатуры стоимость одного ноутбука, их количество и процент скидки. Посчитать общую сумму заказа.
            Console.WriteLine("\nTask 3");
            double priceOneLaptop;
            int numberOfLaptops;
            double discountPercent;

            Console.Write("Enter price one laptop: ");
            priceOneLaptop = double.Parse(Console.ReadLine());

            Console.Write("Enter number of laptops: ");
            numberOfLaptops = int.Parse(Console.ReadLine());

            Console.Write("Enter discount percentage: ");
            discountPercent = double.Parse(Console.ReadLine());

            double discountAmount = priceOneLaptop * numberOfLaptops * (discountPercent / 100.0);
            double totalAmount = priceOneLaptop * numberOfLaptops - discountAmount;

            Console.WriteLine("Total order amount: " + totalAmount);


            //4) По заданной длине окружности найти площадь круга по формуле S = pi*R*R, радиус вычислить из формулы длины окружности: L=2*pi*R. Примечание: pi = 3.14.
            Console.WriteLine("\nTask 4");
            const float pi = 3.14f;
            float circumference;

            Console.Write("Enter circumference: ");
            circumference = float.Parse(Console.ReadLine());

            float circleRadius = circumference / (2.0f * pi);
            float area = pi * circleRadius * circleRadius;

            Console.WriteLine("Area of a circle: " + area);


            //5) Пользователь вводит 4-значное число.
            //Поменять в нём местами первую и последнюю цифры и вывести результат на экран.
            Console.WriteLine("\nTask 5");
            int number;
            Console.Write("Enter a 4-digit number: ");
            number = int.Parse(Console.ReadLine());

            int firstDigit = number / 1000; //первая цифра
            int lastDigit = number % 10; //последняя цифра
                                         // Получаем средние цифры
            int middleDigits = (number / 10) % 100;
            int newNumber = lastDigit * 1000 + middleDigits * 10 + firstDigit;

            Console.WriteLine("New number: " + newNumber);


            //6) Написать программу, которая преобразует введенное пользователем количество дней
            //в количество полных недель и оставшихся дней.
            //Например, пользователь ввел 17 дней, программа должна вывести на экран 2 недели и 3 дня.

            Console.WriteLine("\nTask 6");
            Console.Write("Enter numbet of days: ");
            int days = int.Parse(Console.ReadLine());

            int weeks = days / 7;
            int remainingDays = days % 7; 

            Console.WriteLine($"{weeks} weeks and {remainingDays} days");


            //7) N школьников делят K яблок поровну, неделящейся остаток остается в корзине.
            //Сколько яблок достанется каждому школьнику? Сколько яблок останется в корзинке?
            Console.WriteLine("\nTask 7");
            Console.Write("Enter number of student: ");
            int students = int.Parse(Console.ReadLine());
            Console.Write("Enter number of apples: ");
            int apples = int.Parse(Console.ReadLine());

            int applesPerStudent = apples / students;
            int remainingApples = apples % students;

            Console.WriteLine($"{applesPerStudent} apples for every schoolchild");
            Console.WriteLine($"{remainingApples} apples will remain in the basket");
        }
    }
}
