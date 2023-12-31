﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
    public class Player
    {  
        public Player(int bankBalance, string playerName) {
            Hand = new List<Card>();  
            Balance = bankBalance; 
            Name = playerName;
            
        
        
        }

        public List<Card> Hand { get; set; } 
        public int Balance { get; set;  } 
        public  string Name { get; set; }  
        public bool IsActivePlaying { get; set; } 
        public bool stay { get; set; }
        public bool Bet(int amount) {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You dont have enough to place bet  this size...");
                return false;

            }
            else { 
           Balance -= amount; 
                return true;
            }
        
        }

        public static Game operator+ (Game game, Player player) { 

             game.Players.Add (player);
            return game;
           }
        public static Game operator -(Game game, Player player) {
        game.Players.Remove (player); 
            return game;
        
        }
    }
}
