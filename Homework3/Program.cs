//Task1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
void Polindrom(int n)
{
    while(n > 100000 || n < -100000 || n < 10000 && n > -10000) 
    {   
        Console.Write("Ошибка. Введите число еще раз: ");
        n = Convert.ToInt32(Console.ReadLine());
    }    
        int z = n / 10000;
        int k = (n / 1000) % 10;
        if(z == (n % 10) && k == ((n / 10) % 10)) Console.Write("Является ли число палиндромом? Да");
          
        else Console.Write("Является ли число палиндромом? Нет");          
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Polindrom(num);