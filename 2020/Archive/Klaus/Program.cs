﻿using System;

namespace Klaus
{
    class Program
    {
    
    }

    public class TheOriginals
    {
        private string _Name { get; set; }
        private string _Age { get; set; }
        private string _Power { get; set; }

        public TheOriginals() {}
        
        public TheOriginals(string name, string age, string power)
        {
            this._Name = name;
            this._Age = age; 
            this._Power = power;
        }
    }

    public abstract class Vampires : TheOriginals
    {
        public string killIt { get; set; }

        public Vampires() {}
        public Vampires(string name, string age, string power) : base(name, age, power) 
        {
           public string NameType;

           Vampires NamePower;  
        }

        public extern string returnVampireName();
    }
}
