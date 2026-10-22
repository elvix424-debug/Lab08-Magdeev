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


int sum = 0;
int count = 0;
int max = 0;

Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());

while (grade != -1) {
    sum += grade;
    count++;
    if(grade > max)
    {
        max = grade;
    }
    grade = int.Parse(Console.ReadLine());
}

if (count > 0)
{
    Console.WriteLine($"Средний балл: {(double)sum / count}");
    Console.WriteLine($"Наибольшая оценка: {max}");
}
else
{
    Console.WriteLine("Оценок не было введено");
}


// string correctPassword = "qwerty123";
// int count = 0;
// while (true)
// {
//     Console.Write("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine();

//     if (password == correctPassword)
//     {
//         Console.WriteLine("Доступ разрешён");
//         break;
//     }
//     count++;
//     Console.WriteLine("Неверный пароль, попробуйте снова");
// }

// Console.WriteLine($"Количество неудачных попыток: {count}");


// string answer;

// do
// {
//     Console.WriteLine("Введите дату посещения (например, 01.09): ");
//     string date = Console.ReadLine();
//     Console.WriteLine("Запись добавлена: {date}");

//     Console.WriteLine("Добавить еще одну запись?(да/нет): ");
//     answer = Console.ReadLine();
// } while (answer == "да");

// Console.WriteLine("Дневник сохранен");

//Самостоятельные задания ★
//Задачка Б
// int count = 0;

// Console.WriteLine("Вводите имена учеников (для завершения введите 'конец'):");
// string name = Console.ReadLine();

// while (name != "конец")
// {
//     count++;
//     name = Console.ReadLine();
// }

// Console.WriteLine($"Всего введено имён: {count}");

// //Задача Г
// while (true)
// {
//     Console.Write("Введите целое число: ");
//     int num = int.Parse(Console.ReadLine());
//     if (num % 7 == 0)
//     {
//         Console.WriteLine("Найдено!");
//         break;
//     }
// }

//Индивидуальный вариант ★★
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

//Задание №3
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// int i = 1;
// while (i <= num)
// {
//     Console.WriteLine($"{i} -> {i * i}");
//     i++;
// }

// //Задание №5
// int id = 5555;
// while (true)
// {
//     Console.Write("Введите код домофона: ");
//     if (int.TryParse(Console.ReadLine(), out int enter) && enter == id)
//     {
//         Console.WriteLine("Дверь открыта");
//         break;
//     }
//     Console.WriteLine("Неверный код, попробуйте снова.");
// }