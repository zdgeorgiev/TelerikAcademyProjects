using System;
using System.Threading;

namespace TeamEeyore.SpaceShip
{
    class Engine
    {
        public static int explosionDrawX;
        public static int explosionDrawY;

        private static int score = 0;
        private static int gamelevel = 1;
        private static int lives = 1;
        private static int killedEnemies = 0;
        private static int gameLevelUp = 10;
        private static int enemiesForLevel = 2;

        public static void Start()
        {
            RemoveScrollBars();

            int delay = 2;

            PlayerShip player = new PlayerShip(Console.WindowWidth / 2, Console.WindowHeight - 1, "|=0=|");
            EnemyShip enemy = new EnemyShip(Console.WindowWidth / 2, 2, "|==0==|", delay);

            Random rand = new Random();
            
            while (lives != -1)
            {
                Console.Clear();

                PrintUI(player);

                player.Draw();
                enemy.Draw();

                player.Move();
                enemy.Move();

                //Level up to unlock tripple gun.
                if (killedEnemies == enemiesForLevel)
                {
                    player.Level++;
                    killedEnemies = 0;
                    enemiesForLevel += 1;
                }

                //Collisions
                if ((player.X >= enemy.X && player.X <= enemy.X + 6) && (enemy.Y == Console.WindowHeight - 1) ||
                    (player.X <= enemy.X && player.X + 4 >= enemy.X) && (enemy.Y == Console.WindowHeight - 1))
                {
                    if (lives == 0)
                    {
                        Collisions.ShipCollision(score, player.Level);
                    }

                    lives--;
                }

                foreach (var shot in player.Shots)
                {
                    if (player.Weapon == Weapon.Tripple)
                    {
                        if ((shot.Y == enemy.Y || shot.Y == enemy.Y - 1) && ((shot.X >= enemy.X && shot.X <= enemy.X + 6) ||(shot.X < enemy.X && shot.X + 4 >= enemy.X)))
                        {
                            int randNumber = rand.Next(1, Console.WindowWidth - (enemy.ShipSymbol.Length + 1));
                            Console.Clear();
                            explosionDrawX = enemy.X;
                            explosionDrawY = enemy.Y;
                            Collisions.ShotCollision();
                            enemy = new EnemyShip(randNumber, 2, "|==0==|", delay);
                            player.Shots.Remove(shot);
                            score++;
                            killedEnemies++;
                            break;
                        }
                    }
                    else if ((shot.Y == enemy.Y || shot.Y == enemy.Y - 1) && shot.X >= enemy.X && shot.X <= enemy.X + 6)
                    {
                        int randNumber = rand.Next(1, Console.WindowWidth - (enemy.ShipSymbol.Length + 1));
                        Console.Clear();
                        explosionDrawX = enemy.X;
                        explosionDrawY = enemy.Y;
                        Collisions.ShotCollision();
                        enemy = new EnemyShip(randNumber, 2, "|==0==|", delay);
                        player.Shots.Remove(shot);
                        score++;
                        killedEnemies++;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                Thread.Sleep(50 - (score / 2));
            }
        }

        static void RemoveScrollBars()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;

            Console.SetWindowSize(Console.WindowWidth, Console.WindowHeight * 2);
        }

        static void PrintUI(PlayerShip player)
        {
            Console.Write("game level: {0}  ", gamelevel);
            Console.Write("score: {0}  ", score);
            Console.Write("player level: {0}  ", player.Level);
            Console.Write("exp: " + new string('|', killedEnemies) +"\t");
            Console.WriteLine("lives: {0}", lives);
            Console.WriteLine(new string('-', Console.WindowWidth));

            if (score == gameLevelUp)
            {
                gamelevel += 1;
                gameLevelUp += 5;
            }
        }
    }
}