using Newtonsoft.Json;

class MathHandbook
{
    static List<UserFormula> userFormulas = new List<UserFormula>();
    static string lastMenu = "mainMenu";

    static void Main(string[] args)
    {
        LoadFormulas();
        DisplayMenu();
    }

    static void LoadFormulas()
    {
        if (File.Exists("UserFormulas.json"))
        {
            string jsonData = File.ReadAllText("UserFormulas.json");
            userFormulas = JsonConvert.DeserializeObject<List<UserFormula>>(jsonData) ?? new List<UserFormula>();
        }
    }

    static void DisplayMenu()
{
    Console.WriteLine("Математичний довiдник 6 класу\r\n\r\n 1. Формули знаходження площ та об'ємiв фiгур\r\n 2. Формули кратностi\r\n 3. Формули для пiднесення числа до степеня\r\n 4. Формули рiшення з дробами\r\n 5. Формули переводу в процентiв й навпаки\r\n 6. Таблиця множення\r\n 7. Вашi формули\r\n 8. Вихiд\r\n");

    Console.WriteLine("Виберiть опцiю: ");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Формула знаходження площ та об'ємiв фiгур");
            Figures();
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Формули кратностi");
            Multiplicity();
            break;
        case "3":
            Console.Clear();
            Console.WriteLine("Формули для пiднесення числа до степеня");
            Degree();
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("Формули рiшення з дробами");
            Fraction();
            break;
        case "5":
            Console.Clear();
            Console.WriteLine("Формули переводу в процентiв й навпаки");
            Percents();
            break;
        case "6":
            Console.Clear();
            MultiplicationTable();
            break;
        case "7":
            Console.Clear();
            YourFormula();
            break;
        case "8":
            Environment.Exit(0);
            break;
        default:
            Console.Clear();
            Console.WriteLine("Невiрний вибiр. Спробуйте ще раз.");
            break;
    }

    ClearConsoleAndAddMenu();
}

    static void ClearConsoleAndAddMenu()
    {
        Console.WriteLine("Натиснiть будь-яку клавiшу для переходу в меню");
        Console.ReadKey();
        Console.Clear();
        if (lastMenu == "mainMenu")
        {
            DisplayMenu();
        }
        else if (lastMenu == "formulaMenu")
        {
            YourFormula();
        }
    }


    static void Figures()
    {
        Console.WriteLine("\n1. Прямокутник:\n   - Площа: S = a * b, де a та b - довжини сторiн.\n\n2. Квадрат:\n   - Площа: S = a^2, де a - довжина сторони.\r\n\r\n3. Трикутник:\r\n   - Площа за формулою Герона: S = sqrt[s(s-a)(s-b)(s-c)], де s - пiвпериметр, a, b, c - довжини сторiн.\r\n   - Площа за базою i висотою: S = (1/2) * b * h, де b - довжина бази, h - висота, проведена до цiєi бази.\r\n\r\n4. Коло:\r\n   - Площа: S = п * r^2, де r - радiус.\r\n\r\n5. Трикутник прямокутний:\r\n   - Площа: S = (1/2) * a * b, де a та b - довжини катетiв.\r\n\r\n6. Куб:\r\n   - Об'єм: V = a^3, де a - довжина ребра.\r\n\r\n7. Паралелепiпед (прямокутний паралелепiпед):\r\n   - Об'єм: V = a * b * c, де a, b, c - довжини ребер.\r\n\r\n8. Цилiндр:\r\n   - Об'єм: V = п * r^2 * h, де r - радiус основи, h - висота.\r\n\r\n9. Конус:\r\n   - Об'єм: V = (1/3) * п * r^2 * h, де r - радiус основи, h - висота.\r\n\r\n10. Сфера:\r\n    - Об'єм: V = (4/3) * п * r^3, де r - радiус.\r\n");
    }
    static void Multiplicity()
    {
        Console.WriteLine("\r\n1. Формула кратностi числа 'а' для 'n':\r\n\r\n Кратнiсть числа 'а' для 'n' обчислюється за допомогою дiлення 'а' на 'n'.\r\n Якщо результат дiлення - це цiле число, то 'а' кратне 'n'.\r\n  Формула для перевiрки цього:\r\n  Кратнiсть = a / n\r\n\r\n2. Формула для знаходження всiх кратних числа n:\r\n\r\n Всi кратнi числа 'n' можна знайти, множачи 'n' на всi цiлi числа починаючи з 1.\r\n  Формула виглядає наступним чином:\r\n  Кратне = n * k, де k = 1, 2, 3, ...\r\n\r\n3. Формула для знаходження кратностi числа 'a' в промiжку вiд 'm' до 'n': \r\n\r\n Щоб знайти кратнiсть числа 'a' в заданому промiжку, вам потрiбно обчислити кiлькiсть чисел у цьому промiжку, якi кратнi 'a'.\r\n  Формула виглядає наступним чином:\r\n  Кiлькiсть кратних = [n / a] - [(m-1) / a] \r\n   де [x] - це найбiльше цiле число, яке не перевищує 'x'. \r\n");
    }

    static void Degree()
    {
        Console.WriteLine("\r\n1. Пiднесення до невiд'ємного цiлого степеня: \r\n a^n = a * a * a * ... * a \r\n де 'a' повторюється 'n' - кiлькiсь разiв \r\n\r\n2. Пiднесення до вiд'ємного цiлого степеня: \r\n a^(-n) = 1 / (a * a * a * ... * a) \r\n де 'a' повторюється 'n' - кiлькiсь разiв \r\n\r\n3. Пiднесення до рацiонального степеня \r\n a^(m/n) = n-ий корiнь з a^m \r\n\r\n4. Пiднесення до деяких спецiальних дробових степенiв: \r\n a^0.5 = квадратний корiнь з 'a' \r\n a^0.333 = кубiчний корiнь з 'a' \r\n ");
    }

    static void Fraction()
    {
        Console.WriteLine("\r\n1. Додавання:\r\n Коли додаємо двi дробi, ми складаємо чисельники i знаменники:\r\n а / b + c / d = (ad + bc) / bd\r\n\r\n2. Вiднiмання:\r\n При вiднiманнi дробiв, вiд чисельника першого дроба вiднiмаємо чисельник другого дроба:\r\n a / b - c / d = (ad - bc) / bd\r\n\r\n3. Множення:\r\n При множеннi дробiв, множимо чисельники разом та знаменники разом:\r\n a / b * c / d = ac / bd\r\n\r\n4. Дiлення:\r\n При дiленнi одного дроба на iншу ми множимо перший дроб на обернену до другого:\r\n a / b : c / d = a / b * d / c = ad / bc\r\n");
    }


    static void Percents()
    {
        Console.WriteLine("\r\n1. Вiдсотки = (Число / Загальна_кiлькiсть) * 100\r\n Наприклад: Припустимо, у вас є 20 яблук, а загальна кiлькiсть фруктiв у вашому кошику - 50.\r\n Яка частина цього кошика становлять яблука у вiдсотках?\r\n  Рiшення прикладу: Вiдсотки = (20 / 50) * 100 = 40%\r\n2. Число = (Вiдсотки * Загальна_кiлькiсть) / 100\r\n Наприклад: Припустимо, ви хочете знати, скiльки яблук становить 30% вашого кошика з фруктами.\r\n Якщо загальна кiлькiсть фруктiв у кошику - 50, то скiльки це буде яблук?\r\n  Рiшення прикладу: Число = (30 * 50) / 100 = 15\r\n");
    }

    static void MultiplicationTable()
    {
        Console.WriteLine("Таблиця множення:");
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j}\t");
            }
            Console.WriteLine();
        }
    }




    static void YourFormula()
    {
        Console.WriteLine("Меню дiй з формулами");
        Console.WriteLine("1. Створити формулу");
        Console.WriteLine("2. Переглянути список формул");
        Console.WriteLine("3. Повернутися в меню");
        Console.Write("Виберiть опцiю: ");
        string? formulaOption = Console.ReadLine();
        switch (formulaOption)
        {
            case "1":
                CreateFormula();
                lastMenu = "formulaMenu";
                break;
            case "2":
                DisplayFormulas();
                lastMenu = "formulaMenu";
                break;
            case "3":
                lastMenu = "mainMenu";
                ClearConsoleAndAddMenu();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Невiрний вибiр. Спробуйте ще раз.");
                break;
        }

        static void CreateFormula()
        {
            Console.Clear();
            Console.Write("Введiть назву формули: ");
            string? formulaName = Console.ReadLine();
            Console.Write("Введiть саму формулу: ");
            string? formulaExpression = Console.ReadLine();
            if (formulaName != null && formulaExpression != null)
            {
                userFormulas.Add(new UserFormula { Name = formulaName, Expression = formulaExpression });
            }

            userFormulas.Add(new UserFormula { Name = formulaName, Expression = formulaExpression });
            Console.WriteLine("Формула успiшно створена!");
            SaveFormulas();
        }

        static void DisplayFormulas()
        {
            Console.Clear();
            Console.WriteLine("Список ваших формул:");

            if (userFormulas.Count == 0)
            {
                Console.WriteLine("Список порожнiй.");
            }
            else
            {
                int index = 1;
                foreach (var formula in userFormulas)
                {
                    Console.WriteLine($"{index}. {formula.Name}");
                    index++;
                }

                Console.Write("Введiть номер формули для перегляду: ");
                if (int.TryParse(Console.ReadLine(), out int displayIndex) && displayIndex > 0 && displayIndex <= userFormulas.Count)
                {
                    var selectedFormula = userFormulas[displayIndex - 1];
                    Console.Clear();
                    Console.WriteLine($"Назва: {selectedFormula.Name}");
                    Console.WriteLine($"Формула: {selectedFormula.Expression}");

                    Console.WriteLine("1. Редагувати формулу");
                    Console.WriteLine("2. Видалити формулу");
                    Console.WriteLine("3. Повернутися назад");

                    Console.Write("Виберiть опцiю: ");
                    string? formulaOption = Console.ReadLine();

                    switch (formulaOption)
                    {
                        case "1":
                            EditFormula(displayIndex - 1);
                            break;
                        case "2":
                            DeleteFormula(displayIndex - 1);
                            break;
                        case "3":
                            Console.Clear();
                            lastMenu = "formulaMenu";
                            YourFormula();
                            break;
                        default:
                            Console.WriteLine("Невiрний вибiр. Спробуйте ще раз.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Невiрний номер формули.");
                }
            }
        }

        static void EditFormula(int index)
        {
            Console.Write("Введiть нову назву формули: ");
            string? newFormulaName = Console.ReadLine();
            Console.Write("Введiть нову формулу: ");
            string? newFormulaExpression = Console.ReadLine();

            userFormulas[index] = new UserFormula { Name = newFormulaName, Expression = newFormulaExpression };
            Console.WriteLine("Формула успiшно вiдредагована!");
            SaveFormulas();
        }

        static void DeleteFormula(int index)
        {
            userFormulas.RemoveAt(index);
            Console.WriteLine("Формула успiшно видалена!");
            SaveFormulas();
        }

        static void SaveFormulas()
        {
            string jsonData = JsonConvert.SerializeObject(userFormulas);
            File.WriteAllText("UserFormulas.json", jsonData);
        }
    }

    class UserFormula
    {
        public string Name { get; set; }
        public string Expression { get; set; }
    }
}