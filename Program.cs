// int lessonNumber = 5;

// while (lessonNumber >= 1) {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }

// Console.WriteLine("Пары закончились");

// Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());
// int count = 0;

// while (grade != -1) {
//     Console.WriteLine($"Оценка принята: {grade}");
//     grade = int.Parse(Console.ReadLine());
//     count++;
// }

// Console.WriteLine("Ввод завершён");
// Console.WriteLine($"Количество введенных оценок: {count}");


// int sum = 0;
// int count = 0;
// int max = 0;

// Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());

// while (grade != -1) {
//     sum += grade;
//     count++;
//     if(grade > max)
//     {
//         max = grade;
//     }
//     grade = int.Parse(Console.ReadLine());
// }

// if (count > 0)
// {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
//     Console.WriteLine($"Наибольшая оценка: {max}");
// }
// else
// {
//     Console.WriteLine("Оценок не было введено");
// }


string correctPassword = "qwerty123";
int count = 0;
while (true)
{
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();
    
    if (password == correctPassword)
    {
        Console.WriteLine("Доступ разрешён");
        break;
    }
    count++;
    Console.WriteLine("Неверный пароль, попробуйте снова");
}

Console.WriteLine($"Количество неудачных попыток: {count}");