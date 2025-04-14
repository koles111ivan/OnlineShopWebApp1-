namespace OnlineShopWebApp1_.Controllers
{
    public class CalculaterController
    {
        public string Index(double? num1, double? num2, string? zn)
        {
            double a = num1 ?? 0;
            double b = num2 ?? 0;
            string z = zn ?? "+";
            double sum = 0;
            if (z=="!")
            {
                sum = a + b;
                return $"{a} + {b} = {sum}";
            }
            else if (z=="-")
            {
                sum = a - b;
                return $"{a} - {b} = {sum}";
            }
            else if (z == "*")
            {
                sum = a * b;
                return $"{a} * {b} = {sum}";
            }
            else
            {
                return "Ошибка введите что-то из данных операций: + - *";
            }
        }
    }
}
