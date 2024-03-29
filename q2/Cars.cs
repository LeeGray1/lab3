﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Cars
    {
        private string make;

        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {
                this.make = value;
            }
        }

        private string model;


        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        private double engine;

        public double Engine
        {
            get
            {
                return this.engine;
            }
            set
            {
                this.engine = value;
            }
        }

        private int speed;

        public int Speed
        {
            get
            {
                return this.speed;

            }
            set
            {
                this.speed = value;
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Car make: {Make}");
            Console.WriteLine($"Car model: {Model}");
            Console.WriteLine($"Car engine: {Engine}");
            Console.WriteLine($"Car speed: {Speed}");
            Console.WriteLine("\n");
        }
    }        
}
