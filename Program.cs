using System.Xml;

namespace LAB3
{
    class Car
    {   //поля
        private string name;
        private string color;
        private double price;
        const string CompanyName = "VW";
        //методи
        public Car()
        {}
        public Car(string name, string color, float price)
        {
            this.name = name;
            this.color = color;
            this.price = price;

        }
        public void Input()
        {
            Console.WriteLine("Введіть назву:");
            name = Console.ReadLine();
            Console.WriteLine("Введіть колір:");
            color = Console.ReadLine();
            Console.WriteLine("Введіть ціну:");
            price = int.Parse(Console.ReadLine());
        }
        public  void Print() 
        { 
            Console.WriteLine($"Name: {this.name}, Color: {this.color}, Price: {this.price}");
        }
        public double ChangePrice(double x)
        {
            price = price * x/100; 
            return price;
        }
        public string PrintInfo()
        { return $"Дані про авто \n Name: {this.name}, Color: {this.color}, Price: {this.price}"; }





        static void Main(string[] args)
        {
            string newColor;

            Car car1 = new Car();
             Car car2 = new Car();
              Car car3 = new Car();

              car1.Input();
              car2.Input();
              car3.Input();

              car1.ChangePrice(10);
              car2.ChangePrice(10);
              car3.ChangePrice(10);

              car1.Print();
              car2.Print();
              car3.Print();

              Console.WriteLine("Введіть новий колір:");
              newColor = Console.ReadLine();
              if (car1.color == "white") car1.color = newColor;
              if (car2.color == "white") car2.color = newColor;
              if (car3.color == "white") car3.color = newColor;
      
              Console.WriteLine(car1.PrintInfo());
              Console.WriteLine(car2.PrintInfo());
              Console.WriteLine(car3.PrintInfo());
        }
    }
}

