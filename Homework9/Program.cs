using System;
using ClassLibrary;
using ClassLibrary.Interfaces;

namespace Homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car { maxSpeed = 220, nameOfCompany = "BMW", numberOfPasanger = 4 };
            var car1 = new Car { maxSpeed = 240, nameOfCompany = "Audi", numberOfPasanger = 4 };
            var car2 = new Car { maxSpeed = 180, nameOfCompany = "VW", numberOfPasanger = 8 };
            var car3 = new Car { maxSpeed = 150, nameOfCompany = "ZAZ", numberOfPasanger = 2 };

            var boat1 = new Boat { maxSpeed = 30, nameOfCompany = "Titanic", numberOfPasanger = 40000 };
            var boat2 = new Boat { maxSpeed = 60, nameOfCompany = "Byliner", numberOfPasanger = 5 };
            var boat3 = new Boat { maxSpeed = 40, nameOfCompany = "Sunrise", numberOfPasanger = 3 };

            IWorkWithContainer<Transport> catalogOfTransport = new MyCollection<Transport>();
            catalogOfTransport.GetTypeToContainer(boat1);
            catalogOfTransport.GetTypeToContainer(boat2);
            catalogOfTransport.GetTypeToContainer(boat3);
            catalogOfTransport.GetTypeToContainer(car);
            catalogOfTransport.GetTypeToContainer(car1);
            catalogOfTransport.GetTypeToContainer(car2);
            catalogOfTransport.GetTypeToContainer(car3);



            
            int amountInContainer = catalogOfTransport.elements;
            
            Console.WriteLine($" В нашей базе на текущий момент имеется: \n Количество тарнспорта - {amountInContainer}");
           
            int index;
           
                Console.Write($" Выберите один из {amountInContainer}, о каком показать информацию - ");
                index = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine(catalogOfTransport.SearchToIndex(index).ToString());

            
            


        }
    }
}
