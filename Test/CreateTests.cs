using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestSolver
{
    public static class CreateTests
    {
        public static void MakeTest(string nameFile)
        {
            StreamWriter streamWriter = new StreamWriter(nameFile);

            Console.Clear();

            int examplesCount = Util.InputInt("Введите количество заданий: ", 0, 100);
            streamWriter.WriteLine(examplesCount);

            for (int i = 0; i < examplesCount; i++)
            {
                Console.Write("Введите вопрос: ");
                streamWriter.WriteLine(Console.ReadLine());

                int countAnswers = Util.InputInt("Введите количество ответов[1, 10]: ", 1, 10);
                
                streamWriter.WriteLine(countAnswers);

                for (int j = 0; j < countAnswers; j++)
                {
                    Console.Write($"Введите {j} ответ: ");

                    streamWriter.WriteLine(Console.ReadLine());
                }

                int numberRightAnswer = Util.InputInt("Введите индекс правильного ответа[1, 10]: ", 0, 10) + 1;
                streamWriter.WriteLine(numberRightAnswer);

                Console.Clear();
            }

            streamWriter.Close();
        }
    }
}
