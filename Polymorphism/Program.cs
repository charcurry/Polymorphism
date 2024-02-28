using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism");
            Console.WriteLine();

            //enemy manager

            // declaration

            //SmallEnemy[] smallEnemies = new SmallEnemy[100];
            //MediumEnemy[] mediumEnemies = new MediumEnemy[50];
            //LargeEnemy[] largeEnemies = new LargeEnemy[10];

            ///USING LISTS IS BETTER OBJECTIVELY
            Enemy[] enemies = new Enemy[100 + 50 + 10];

            // instantiation

            for (int i = 0; i < 100; i++) enemies[i] = new SmallEnemy();
            for (int i = 0; i < 50; i++) enemies[100 + i] = new MediumEnemy();
            for (int i = 0; i < 10; i++) enemies[100 + 50 + i] = new LargeEnemy();


            // enemy manager update

            foreach (Enemy enemy in enemies) enemy.Update();

            //foreach (var enemy in smallEnemies)
            //{
            //    enemy.Update();
            //}

            //foreach (var enemy in mediumEnemies) 
            //{ 
            //    enemy.Update(); 
            //}

            //foreach (var enemy in largeEnemies)
            //{
            //    enemy.Update();
            //}

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);

        }
    }
}
