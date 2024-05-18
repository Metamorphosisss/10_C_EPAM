using _10_C_EPAM;
using System.Globalization;
internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<Automobile> cars = new List<Automobile>();
            cars.Add(new Automobile("Toyota", 150));
            cars.Add(new Automobile("BMW", 200));
            cars.Add(new Automobile("Skoda", 400));
            foreach (Automobile car in cars) 
            {
                if (car.MaxSpeed <= 0 || car.MaxSpeed > 300)
                {
                    string s = String.Format("Недопустима швидкiсть");
                    throw new Exception(s);
                }
            }

            foreach (Automobile car in cars)
            {
                Console.WriteLine($"Машина {car.Name} має швидкiсть {car.MaxSpeed}");
            }
            static Automobile FindFastestcar(List<Automobile> array)
            {
                Automobile max = array[0];
                foreach (Automobile car in array)
                {
                    if (car.MaxSpeed >= max.MaxSpeed)
                    {
                        max = car;
                    }
                }
                return max;
            }
            Automobile a = FindFastestcar(cars);
            Console.WriteLine("Найшвидша машина " + a.Name + " зi швидкiстю " + a.MaxSpeed);
        }
        catch (Exception e) 
        {
            Console.WriteLine("Помилка: {0} ", e.Message);
        }

    }
}