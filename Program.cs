using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PR_17
{
    internal class Program
    {
        public class ComputerGame
        {
            private string _title;
            private string _icon;
            private double _size;
            public string Title
            {
                get { return _title; }
                set { _title = value; }
            }
            public string Icon
            {
                get { return _icon; }
                set { _icon = value; }
            }
            public double Size
            {
                get { return _size; }
                set
                {
                    if (value > 0)
                        _size = value;
                }
            }
            public ComputerGame(string title, string icon, double size)
            {
                Title = title;
                Icon = icon;
                Size = size;
            }
            public static string GetInfo(ComputerGame computerGame)
            {
                return $"Название игры: {computerGame.Title}, Иконка: {computerGame.Icon}, Размер: {computerGame.Size} МБ.";
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "PR_17";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tЗдравствуйте!");
            Console.WriteLine();
            while (true)
            {
                try
                {
                    Console.Write("Введите название игры: ");
                    string title = Console.ReadLine();
                    Console.Write("Введите путь до иконки: ");
                    string icon = Console.ReadLine();
                    Console.Write("Введите размер игры в МБ: ");
                    string size1 = Console.ReadLine();
                    double size = 0;
                    if (!double.TryParse(size1, out size))
                    {
                        throw new FormatException("Размер должен быть числом!");
                    }
                    ComputerGame computerGame = new ComputerGame(title, icon, size);
                    Console.WriteLine(computerGame);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.ResetColor();
                    Console.WriteLine("Попробуйте снова.");
                }
            }
        }
    }
}