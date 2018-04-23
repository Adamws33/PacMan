using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    class PacMan : IPacMan, IFruit, IGhosts
    {
        public PacMan(int Score, int Lives, int LivesGained)
        {
            this.Score = Score;
            this.Lives = Lives;
            this.LivesGained = LivesGained;
        }
        public int Score { get; set; }
        public int Lives { get; set; }
        public int LivesGained { get; set; }

        public int CheckAlive()
        {
            if (this.Lives <= 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public void Apple()
        {
            this.Score = 700 + this.Score;
            Console.WriteLine("Apple");

        }

        public void Bell()
        {
            this.Score = 3000 + this.Score;
            Console.WriteLine("Bell");

        }

        public void CheckScore()
        {
            if (this.Score >= 10000 && this.LivesGained == 0)
            {
                this.Lives = this.Lives + 1;
                this.LivesGained = this.LivesGained + 1;
                Console.WriteLine("Score: " + this.Score + " Lives " + this.Lives + " Lives Gained So Far " + this.LivesGained);
            }
            else if (this.Score >= 20000 && this.LivesGained == 1)
            {
                this.Lives = this.Lives + 1;
                this.LivesGained = this.LivesGained + 1;
                Console.WriteLine("Score: " + this.Score + " Lives " + this.Lives + " Lives Gained So Far " + this.LivesGained);
            }
            else if (this.Score >= 30000 && this.LivesGained == 2)
            {
                this.Lives = this.Lives + 1;
                this.LivesGained = this.LivesGained + 1;
                Console.WriteLine("Score: " + this.Score + " Lives " + this.Lives + " Lives Gained So Far " + this.LivesGained);
            }
            else if (this.Score >= 40000 && this.LivesGained == 3)
            {
                this.Lives = this.Lives + 1;
                this.LivesGained = this.LivesGained + 1;
                Console.WriteLine("Score: " + this.Score + " Lives " + this.Lives + " Lives Gained So Far " + this.LivesGained);
            }
            else if (this.Score >= 50000 && this.LivesGained == 4)
            {
                this.Lives = this.Lives + 1;
                this.LivesGained = this.LivesGained + 1;
                Console.WriteLine("Score: " + this.Score + " Lives " + this.Lives + " Lives Gained So Far " + this.LivesGained);
            }
            else
            {
                Console.WriteLine("Score: " + this.Score + " Lives " + this.Lives + " Lives Gained So Far " + this.LivesGained);
            }

        }

        public void Cherry()
        {
            this.Score = 100 + this.Score;
            Console.WriteLine("Cherry ");
        }

        public void Galaxian()
        {
            this.Score = 2000 + this.Score;
            Console.WriteLine("Galaxian ");
        }

        public void InvincibleGhost()
        {
            this.Lives = this.Lives - 1;
            Console.WriteLine("You Lost a Life!");
        }

        public void Key()
        {
            this.Score = 5000 + this.Score;
            Console.WriteLine("Key ");
        }

        public void Melon()
        {
            this.Score = 1000 + this.Score;
            Console.WriteLine("Melon ");
        }

        public void Orange()
        {
            this.Score = 500 + this.Score;
            Console.WriteLine("PowerPellet ");
        }

        public void Pellet(int times)
        {
            while (times > 0)
            {
                this.Score = 10 + this.Score;
                Console.WriteLine("Wakka Wakka  ");
                this.CheckScore();
                times--;
            }
        }

        public void Strawberry()
        {
            this.Score = 300 + this.Score;
            Console.WriteLine("Strawberry");
        }

        public void VulnerableGhost()
        {
            this.Score = 200 + this.Score; ;
            Console.WriteLine("You ate a Ghost! ");
        }

        public void VulnerableGhost2()
        {
            this.Score = 400 + this.Score; ;
            Console.WriteLine("You ate another Ghost! ");
        }
        public void EndGame()
        {
            Console.WriteLine("YOU FINISHED!!! Here are your stats \n " +
                "Score: " + this.Score + " Lives " + this.Lives + " Lives Gained So Far " + this.LivesGained);
            Console.ReadLine();

        }

    }
}
