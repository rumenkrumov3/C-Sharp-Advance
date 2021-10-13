using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClassesExercise
{
    class Threeuple
    {
        static void Mainovooo()
        {
            var personsNameAndAdress = Console.ReadLine().Split();
            var nameAndBeer = Console.ReadLine().Split();
            var integerAndDouble = Console.ReadLine().Split();

            string personsName = personsNameAndAdress[0] + " " + personsNameAndAdress[1];
            string adress = personsNameAndAdress[2];
            string town = personsNameAndAdress[3];
            if(personsNameAndAdress.Length >= 5)
            {
                town = personsNameAndAdress[3] + " " + personsNameAndAdress[4];
            }
            string name = nameAndBeer[0];
            string beer = nameAndBeer[1];
            bool drunk = false;
            if (nameAndBeer[2] == "drunk")
            {
                drunk = true;
            }                 
            string name2 = integerAndDouble[0];
            double bankAccount = double.Parse(integerAndDouble[1]);
            string bankName = integerAndDouble[2];

            var firstTuple = Tuple.Create(personsName, adress, town);
            var secondTuple = Tuple.Create(name, beer, drunk);
            var thirdTuple = Tuple.Create(name2, bankAccount, bankName);

            Threeuple<string, string, string> tuple1 = new Threeuple<string, string, string>();
            Threeuple<string, string, bool> tuple2 = new Threeuple<string, string, bool>();
            Threeuple<string, double, string> tuple3 = new Threeuple<string, double, string>();

            tuple1.Pair = firstTuple;
            tuple2.Pair = secondTuple;
            tuple3.Pair = thirdTuple;

            tuple1.ConsoleWriting();
            tuple2.ConsoleWriting();
            tuple3.ConsoleWriting();
        }
    }
    class Threeuple<T1, T2, T3>
    {
        public Threeuple()
        {

        }

        public Tuple<T1, T2, T3> Pair { get; set; }
        public void ConsoleWriting()
        {
            Console.WriteLine($"{Pair.Item1} -> {Pair.Item2} -> {Pair.Item3}");
        }
    }
}
