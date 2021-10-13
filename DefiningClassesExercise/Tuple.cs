using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClassesExercise
{
    class TupleClass
    {
        static void Mainas()
        {
            var personsNameAndAdress = Console.ReadLine().Split();
            var nameAndBeer = Console.ReadLine().Split();
            var integerAndDouble = Console.ReadLine().Split();

            string personsName = personsNameAndAdress[0] + " " + personsNameAndAdress[1];
            string adress = personsNameAndAdress[2];
            string name = nameAndBeer[0];
            string beer = nameAndBeer[1];
            int integer = int.Parse(integerAndDouble[0]);
            double doubleNumber = double.Parse(integerAndDouble[1]);

            var firstTuple = Tuple.Create(personsName, adress);
            var secondTuple = Tuple.Create(name, beer);
            var thirdTuple = Tuple.Create(integer, doubleNumber);

            HandlingTuple<string, string> tuple1 = new HandlingTuple<string, string>();
            HandlingTuple<string, string> tuple2 = new HandlingTuple<string, string>();
            HandlingTuple<int, double> tuple3 = new HandlingTuple<int, double>();

            tuple1.Pair = firstTuple;
            tuple2.Pair = secondTuple;
            tuple3.Pair = thirdTuple;

            tuple1.ConsoleWriting();
            tuple2.ConsoleWriting();
            tuple3.ConsoleWriting();
        }
    }

    class HandlingTuple<T1,T2>
    {
        public HandlingTuple()
        {

        }

        public Tuple<T1,T2> Pair { get; set; }
        public void ConsoleWriting()
        {
            Console.WriteLine($"{Pair.Item1} -> {Pair.Item2}");
        }
    }   
}
