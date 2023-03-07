using ConsoleAppTestSolver;

TestsPlayer player = new TestsPlayer();

bool isRun = true;

while (isRun)
{
    Console.Clear();
    Console.WriteLine("Тестировщик");
    Console.WriteLine("1. Открыть тест из файла");
    Console.WriteLine("2. Создать свой тест");
    Console.WriteLine("0. Выйти из программы");
    int menuPoint = Util.InputInt("Выберите пункт меню: ", 0, 2);

    switch (menuPoint)
    {
        case 0:
            isRun = false;
            break;
        case 1:
            string fileName;
            bool hasFile;
            do
            {
                Console.Write("Введите имя файла: ");
                fileName = Console.ReadLine();
                hasFile = File.Exists(fileName);
                if (!hasFile)
                {
                    Console.WriteLine("Твкаго файла нет:(");
                }
            } while (!hasFile);

            player.LoadFromFile(fileName);
            player.RunTests();
            break;
        case 2:
            Console.Write("Введеите в файл в который вы хотите сохранить тест: ");
            string nameFile = Console.ReadLine();

            CreateTests.MakeTest(nameFile);
            break;
    }
}