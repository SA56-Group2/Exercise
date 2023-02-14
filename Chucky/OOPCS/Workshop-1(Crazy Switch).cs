using System;

namespace Class
{
    class Program
    {
        public static void Main()
        {
            lamp lamp1 = new lamp(false, 0);

            int input;
            do
            {
                Console.Write("Please make sure your input (0 for turning off, 1 for turning on. 2 for exit): ");
                input = int.Parse(Console.ReadLine());
                if(input == 0) lamp1.turnOff();
                else if(input ==1) lamp1.turnOn();
            } while (input !=2);
            Console.WriteLine("The switch of your lamp is broken. Please buy a new one.");
            
        }
    }

    class lamp
    {
        public bool Lampswitch;
        public string[] Color = { "red", "green", "blue" };
        public int Count;

        public lamp(bool lampswitch, int count)
        {
            this.Lampswitch = lampswitch;
            this.Count = count;
        }
        
        public void turnOn()
        {
            if (Lampswitch)
            {
                Console.WriteLine("Your lamp is open.");
            }
            else
            {
                Console.Write("The Lamp is Turned on.");
                Lampswitch = true;
                string color = Color[Count % 3];
                Count++;
                showCurrentColor(color);
            }
            
        }
        
        public void turnOff()
        {
            if (Lampswitch == false)
            {
                Console.WriteLine("You lamp is closed, Please open the lamp.");
            }
            else
            {
                Console.WriteLine("The Lamp is Turned off.");
                Lampswitch = false;
            }
        }

        public void showCurrentColor(string color)
        {
            Console.WriteLine("The color of the lamp is: {0}",color);
        }
    }

    
}



    