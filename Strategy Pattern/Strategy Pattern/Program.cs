using System;

namespace GameWeaponSystem
{
    public interface IWeapon
    {
        void UseWeapon();
    }

    public class Sword : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Махнул мечом! Взмах!");
        }
    }

    public class Bow : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Выстрелил из лука! Свист!");
        }
    }

    public class Axe : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Махнул топором! Удар!");
        }
    }

    public class MagicWand : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Произнес заклинание! Пффф!");
        }
    }

    public class Player

    {
        private IWeapon _weapon;

        public Player(IWeapon initialWeapon)
        {
            _weapon = initialWeapon;
        }

        public void SetWeapon(IWeapon weapon)
        {
            _weapon = weapon;
            Console.WriteLine("Оружие было изменено.");
        }

        public void Attack()
        {
            _weapon.UseWeapon();
        }
    }

    public class Game
    {
        private Player _player;

        public Game()
        {
            _player = new Player(new Sword());
        }

        public void Start()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Атаковать");
                Console.WriteLine("2. Сменить оружие на Меч");
                Console.WriteLine("3. Сменить оружие на Лук");
                Console.WriteLine("4. Сменить оружие на Топор");
                Console.WriteLine("5. Сменить оружие на Магическая палочка");
                Console.WriteLine("6. Выйти из игры");
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        _player.Attack();
                        break;
                    case "2":
                        _player.SetWeapon(new Sword());
                        break;
                    case "3":
                        _player.SetWeapon(new Bow());
                        break;
                    case "4":
                        _player.SetWeapon(new Axe());
                        break;
                    case "5":
                        _player.SetWeapon(new MagicWand());
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("Выход из игры. До свидания!");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;
                }
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();
        }
    }
}
