namespace Lesson10
{
    internal class Program
    {
        class Dice
        {
            protected int point { get => new Random().Next(1, 7); }
        }

        class Game : Dice
        {
            private Dice dice;
            public Game()
            {
                dice = new();
            }
            public int rollDice()
            {
                return base.point;
            }
        }

        class Gamer
        {
            private string name;
            public Gamer(string name)
            {
                this.name = name;
            }

            public override string ToString()
            {
                return name;
            }

        }
        static void Main(string[] args)
        {
            Gamer gamer = new("First");
            Game game = new();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Points rolled {game.rollDice()} points for {gamer}");
            }
        }
    }
}