namespace _21
{
    internal class Program
    {
        private static string[] logo = {
            "----                 ®",
            "|  | |   | |/   ---",
            "|  |  ---| |\\  |   |",
            "----     | | \\  ---"
        };
        private static int b_score = 0, score = 0;
        static void Main(string[] args)
        {
            Console.Clear();
            ConsoleKey[] k;
            ConsoleKey c;
            drawLOGO(false);
            Console.WriteLine("justfollowyourdreams © 2024");
            Console.WriteLine("\n1 - играть\n2 - выйти");
            k = new ConsoleKey[] { ConsoleKey.D1, ConsoleKey.D2 };
            c =  make_choise(k);
            if (c == ConsoleKey.D2) return;
            Console.Clear();
            while (true)
            {
                score = 0;
                b_score = new Random().Next(16, 25);
                while (true)
                {
                    drawLOGO(true);
                    score += new Random().Next(1, 12);
                    Console.WriteLine("Счёт бота: ▓▓");
                    Console.WriteLine("Ваш счёт: " + score);
                    Console.WriteLine("\n1 - тянуть ещё\n2 - стоп");
                    if (score > 21) break;
                    c = make_choise(k);
                    Console.Clear();
                    if (c == ConsoleKey.D2) break;
                }
                Console.Clear();
                drawLOGO(true);
                Console.WriteLine("Счёт бота: " + b_score);
                Console.WriteLine("Ваш счёт: " + score);
                if ((b_score > 21 && score > 21) || b_score == score)
                    Console.WriteLine("Ничья");
                else if (score > 21 || (score < b_score && b_score <= 21))
                    Console.WriteLine("Вы проиграли");
                else
                {
                    Console.WriteLine("Вы выиграли!");
                    if (score == 21)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Идеальная победа ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }   Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("\nСыграть ещё?");
                Console.WriteLine("1 - играть\n2 - выйти");
                c = make_choise(k);
                if (c == ConsoleKey.D2) return;
                Console.Clear();
            }
            
        }

        static ConsoleKey make_choise(ConsoleKey[] allowed)
        {
            ConsoleKey input_;
            back:
            input_ = Console.ReadKey(true).Key;
            if (!allowed.Contains(input_))
                goto back;
            return input_;
        }
        static void drawLOGO(bool whitespace)
        {
            foreach (string logo in logo)
            {
                Console.WriteLine(logo);
            }
            if (whitespace) Console.Write("\n\n");
        }
    }
}
