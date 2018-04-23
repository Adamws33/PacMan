using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
            PacMan PacMan = new PacMan(5000, 3, 0);
            while (PacMan.Lives > 0)
            {
                PacMan.Pellet(11);
                PacMan.InvincibleGhost();
                PacMan.CheckScore();
                PacMan.Melon();
                PacMan.CheckScore();
                PacMan.Galaxian();
                PacMan.CheckScore();
                PacMan.VulnerableGhost();
                PacMan.CheckScore();
                PacMan.VulnerableGhost2();
                PacMan.CheckScore();
                PacMan.Pellet(10);
                PacMan.Bell();
                PacMan.CheckScore();
                PacMan.Cherry();
                PacMan.CheckScore();
                PacMan.Strawberry();
                PacMan.CheckScore();
                PacMan.InvincibleGhost();
                PacMan.CheckScore();
                PacMan.Pellet(40);
                PacMan.Orange();
                PacMan.CheckScore();
                PacMan.Apple();
                PacMan.CheckScore();
                PacMan.InvincibleGhost();
                PacMan.CheckScore();
                PacMan.VulnerableGhost();
                PacMan.CheckScore();
                PacMan.Key();
                PacMan.CheckScore();
                PacMan.InvincibleGhost();
                PacMan.CheckScore();
                PacMan.Pellet(5);
                PacMan.VulnerableGhost();
                PacMan.CheckScore();
                PacMan.InvincibleGhost();
                PacMan.CheckScore();
                PacMan.EndGame();
                PacMan.EndGame();
            }
            Console.WriteLine("YOU ARE DEAD!");
            PacMan.EndGame();
            Console.ReadLine();
        }

    }
}
