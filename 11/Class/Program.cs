﻿using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("Chuck");

            warrior.Introduce();
            warrior.GetStatus();

            //warrior.Name = "Peter";

            warrior.SwordStrike();
            warrior.GetStatus();
            warrior.UseWhirlwind();
            warrior.GetStatus();
            warrior.UseWhirlwind();
            warrior.GetStatus();
            warrior.UseWhirlwind();
            warrior.GetStatus();
            warrior.Rest();
            
            warrior.GetStatus();

            warrior.Health -= 200;
            //warrior.mHealth = 5000;

            warrior.GetStatus();
        }
    }
}