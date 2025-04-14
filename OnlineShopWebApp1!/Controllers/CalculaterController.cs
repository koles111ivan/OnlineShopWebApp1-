namespace OnlineShopWebApp1_.Controllers
{
    public class CalculaterController
    {
        public string Index(double? a, double? b, string? c)
        {
            double num1 = a ?? 0;
            double num2 = b ?? 0;
            string zn = c ?? "+";
            double sum = 0;
            if (zn=="+")
            {
                sum = num1 + num2;
                return $"{num1} + {num2} = {sum}";
            }
            else if (zn=="-")
            {
                sum = num1 - num2;
                return $"{num1} - {num2} = {sum}";
            }
            else if (zn == "*")
            {
                sum = num1 * num2;
                return $"{num1} * {num2} = {sum}";
            }
            else if (zn == "/")
            {
                sum = num1 / num2;
                return $"{num1} / {num2} = {sum}";
            }
            else
            {
                return "Ошибка введите что-то из данных операций: + - *";
            }
        }
    }
}
