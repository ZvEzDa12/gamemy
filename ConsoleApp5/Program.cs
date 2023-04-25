using System;
internal class Prog
{
    static void Main(string[] args)
    {
        Start();
        void Start()
        {
            Console.WriteLine("Для выхода старта нажмите Enter, а для выхода любую другую клавишу.");
            var start = Console.ReadKey().Key;
            switch (start)
            {
                case ConsoleKey.Enter:
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Отлично! Погнали!");
                    StepOne();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Пока");
                    break;
            }
        }
        void StepOne()
        {
            Console.WriteLine();
            Console.WriteLine("Ты очнулся в пещере и ничего не помнишь. Перед тобой 2 прохода, тебе нужно решить куда ты пойдешь");
            Console.WriteLine();
            var nextOne = Console.ReadLine();
            Console.WriteLine("Выбери проход");
            Console.WriteLine("1 Налево");
            Console.WriteLine("2 Направо");
            var StepOneSel = Console.ReadKey().Key;
            switch (StepOneSel)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Ты пошел налево. Пока ты шел были слышны странные звуки. Через 2 минуты на тебя накинулась огромная летучая мышь-людоед");
                    Console.WriteLine("Ты стал долгожданным кормом для мышки). Ты погиб, но накормил животное");
                    End();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("Ты вышел в пустое помещение в пещере");
                    StepTwo();
                    break;
                default:
                    Console.WriteLine("Пожалуйста, выберите вариант ответа...");
                    StepOne();
                    break;
            }
        }
        void StepTwo()
        {
            Console.WriteLine();
            Console.WriteLine("Ты видишь свет в конце пещеры и темный проход. Куда ты пойдешь? ");
            Console.WriteLine();
            Console.WriteLine("1 Пойти в темный проход");
            Console.WriteLine("2 Пойти на свет");
            var StepTwoSel = Console.ReadKey().Key;
            switch (StepTwoSel)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Ты шел около часа, натыкаясь на камни. Твои ноги болят, тело ноет, но ты видишь свет и выходишь из пещеры!!!");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("Cветом оказался брошенный кем то фонарь");
                    Console.WriteLine("Вдруг на тебя бросается какой-то горбатый карлик");
                    Console.WriteLine("Он выигрывает битву между вами и съедает тебя. Ты погиб((");
                    End();
                    break;
                default:
                    Console.WriteLine("Пожалуйста, выберите вариант ответа...");
                    StepTwo();
                    break;

            }
        }
        void End()
        {
            Console.WriteLine();
            Console.WriteLine("Вы проиграли. Начать заново?");
            Console.WriteLine();
            Console.WriteLine("нажмите enter для продолжения, или любую другую клавишу для выхода.");
            var Restart = Console.ReadKey().Key;
            switch (Restart)
            {
                case ConsoleKey.Enter:
                    Console.WriteLine("Надеюсь, в этот раз тебе повезет");
                    Console.WriteLine();
                    Start();
                    break;
            }
        }



    }
}