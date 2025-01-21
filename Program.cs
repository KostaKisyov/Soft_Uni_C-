using System;

class Program
{
    static void Main()
    {
        int countOfPeople = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        string dayOfWeek = Console.ReadLine();
        double sum = 0;

        if (dayOfWeek == "Friday")
        {
            if (type == "Students")
            {
                sum = countOfPeople * 8.45;
                if (countOfPeople >= 30)
                {
                    sum -= sum * 0.15; // Намаление от 15%
                }
            }
            else if (type == "Business")
            {
                if (countOfPeople >= 100)
                {
                    countOfPeople -= 10; // Изваждаме 10 души от броя
                }
                sum = countOfPeople * 10.90;
            }
            else if (type == "Regular")
            {
                sum = countOfPeople * 15;
                if (countOfPeople >= 10 && countOfPeople <= 20)
                {
                    sum -= sum * 0.05; // Намаление от 5%
                }
            }
        }
        else if (dayOfWeek == "Saturday")
        {
            if (type == "Students")
            {
                sum = countOfPeople * 9.80;
                if (countOfPeople >= 30)
                {
                    sum -= sum * 0.15; // Намаление от 15%
                }
            }
            else if (type == "Business")
            {
                if (countOfPeople >= 100)
                {
                    countOfPeople -= 10; // Изваждаме 10 души от броя
                }
                sum = countOfPeople * 15.60;
            }
            else if (type == "Regular")
            {
                sum = countOfPeople * 20;
                if (countOfPeople >= 10 && countOfPeople <= 20)
                {
                    sum -= sum * 0.05; // Намаление от 5%
                }
            }
        }
        else if (dayOfWeek == "Sunday")
        {
            if (type == "Students")
            {
                sum = countOfPeople * 10.46;
                if (countOfPeople >= 30)
                {
                    sum -= sum * 0.15; // Намаление от 15%
                }
            }
            else if (type == "Business")
            {
                if (countOfPeople >= 100)
                {
                    countOfPeople -= 10; // Изваждаме 10 души от броя
                }
                sum = countOfPeople * 16;
            }
            else if (type == "Regular")
            {
                sum = countOfPeople * 22.50;
                if (countOfPeople >= 10 && countOfPeople <= 20)
                {
                    sum -= sum * 0.05; // Намаление от 5%
                }
            }
        }

        Console.WriteLine($"Total price: {sum:F2}");
    }
}
