// Программа, принимающая на вход три числа и выдающая максимальное.

Console.WriteLine("Введите три числа : ");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if ((a > b) && (a >c))
    {
        return a;
    }

    else if ((a < b) && (b > c))
    {
        return b;
    }

    else
    {
        return c;
    }
