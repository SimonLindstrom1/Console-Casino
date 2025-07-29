using Casino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Core
{
    public class GameManager
    {
        private User _currentUser;
        private bool _isRunning = true;

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("🎰 Välkommen till Console Casino!");
            Console.Write("Ange ditt användarnamn: ");
            string username = Console.ReadLine();

            _currentUser = new User(username);

            MainLoop();
        }

        private void MainLoop()
        {
            while (_isRunning)
            {
                Console.Clear();
                Console.WriteLine($"👤 {_currentUser.Username} | 💰 Saldo: {_currentUser.Balance} kr");
                Console.WriteLine("\nVälj ett spel:");
                Console.WriteLine("1. Roulette");
                Console.WriteLine("2. Blackjack");
                Console.WriteLine("3. Slot Machine");
                Console.WriteLine("0. Avsluta");

                Console.Write("\nDitt val: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PlayRoulette();
                        break;
                    case "2":
                        Console.WriteLine("Blackjack är inte tillgängligt än.");
                        Pause();
                        break;
                    case "3":
                        Console.WriteLine("Slot Machine är inte tillgängligt än.");
                        Pause();
                        break;
                    case "0":
                        _isRunning = false;
                        Console.WriteLine("Tack för att du spelade!");
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        Pause();
                        break;
                }
            }
        }

        private void PlayRoulette()
        {
            var roulette = new Roulette(_currentUser);
            roulette.Play();
            Pause();
        }

        private void Pause()
        {
            Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
        }
    }
}
