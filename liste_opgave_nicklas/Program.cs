using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_opgave_nicklas
{
    class Program
    {
        static void Main(string[] args)
        {
            //oprettelse af biler 
            Car c1 = new Car(1, "Rio", "Kia", 2006, 250000, "Red");
            Car c2 = new Car(2,"Rio","Kia",2007,265000,"Black");
            Car c3 = new Car(3,"Panda","Fiat",2017,265000,"Black");
            Car c4 = new Car(4,"Panda","Fiat",2017,365000,"Yellow");
            Car c5 = new Car(5,"S40","Volvo",2018,665000,"White");
            Car c6 = new Car(6,"S65","Volvo",2018,600000,"White");
            Car c7 = new Car(7,"Gorm","Ferrari",2000,4665000,"White");
            Car c8 = new Car(8,"Gorm","Ferrari",2018,4665000,"White");

            //samling af biler i en liste 
            List<Car> biler = new List<Car>() { c1, c2, c3, c4, c5, c6, c7, c8 };
            //lister hvor jeg sætter krav til hvad listen skal indholde
            List<Car> modelrio = biler.Where(Car => Car.Model == "Rio").ToList();

            List<Car> brandferrari = biler.Where(Car => Car.Brand == "Ferrari").ToList();

            List<Car> nyebilerogfrem = biler.Where(Car => Car.Year >= 2010).ToList();

            List<Car> allehvide = biler.Where(Car => Car.Color == "White").ToList();

            List<Car> idotte = biler.Where(Car => Car.Id == 8).ToList();

            //opgave A tal lister
            //opretelse af tal i en int liste
            List<int> taloversigt = new List<int>() { 4, 7, 12, 17, -3, 8, 0, -45, 101 };

            //lister med krav til vores tal
            List<int> mindreellernul = taloversigt.Where(nummer => nummer <= 0).ToList();

            List<int> ligsyv = taloversigt.Where(nummer => nummer == 7).ToList();

            List<int> overfire = taloversigt.Where(nummer => nummer > 4).ToList();

            //udskirvelse af opgave A
            Console.WriteLine("her starter opgave A svar");

            Console.WriteLine("Tal der er under eller lig med 4");
            UdskrivListe(mindreellernul);

            Console.WriteLine("Tal der er lig 7");
            UdskrivListe(ligsyv);

            Console.WriteLine("Tal der er over 4");
            UdskrivListe(overfire);

            //udskriveslse af opgave B
            Console.WriteLine("her starter opgave B svar");

            Console.WriteLine("Model Rio udtrækninger");
            UdskrivListe(modelrio);

            Console.WriteLine("Brand Ferrari udtrækninger");
            UdskrivListe(brandferrari);

            Console.WriteLine("alle fra 2010 og frem");
            UdskrivListe(nyebilerogfrem);

            Console.WriteLine("alle hvide biler");
            UdskrivListe(allehvide);

            Console.WriteLine("Car objekt med Id 8");
            UdskrivListe(idotte);

            Console.ReadKey();
            
        }


        //metode brugt til opgave A
        static void UdskrivListe(List<int> nyliste)
        {
            foreach (var item in nyliste)
            {
                Console.WriteLine(item);
            }
        }

        //metode brugt til opgave B
        private static void UdskrivListe(List<Car> nyliste)
        {
            foreach (var item in nyliste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
