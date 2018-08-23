using System;
using System.Collections.Generic;
using System.Linq;

namespace AmountOfDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytywanie elementów nie jest takie istotne na tą chwilę, tylko bardziej algorytm
            //więc możesz je sobie deklarować w kodzie dla szybkości i ułatwienia jeśli chcesz
            //Mając to na uwadze, że robiła byś to w kodzie ćwiczenie dla Ciebie - 
            //przerób ten kod tak, żeby używać list zamiast tablic :) - dane wpisz w kodzie - to się nazywa hardcodowanie
            //nie podoba mi się nazwa arr1 - spróbuj wymyślić coś lepszego :)
            //podobnie z dict i duplicates - to ułatwi bardzo czytanie i rozumienie kodu

            var numberList = new List<int>();
            numberList.Add(2);
            numberList.Add(2);
            numberList.Add(4);
            numberList.Add(4);

            var dictList = new Dictionary<int, int>();

            //foreach (var key in arr1) //ta tablica tutaj Ci sprawiła problem, bo ona ma zawsze rozmiar 100 i pętla przechodzi przez wszystkie
            //możliwe wartości, więc przechodzi również przez te, których nie zainicjalizowałaś, a domyślnie się ustawiły na 0
            //gdy to przerobisz na listę (ma dynamiczny rozmiar - możesz dodawać i usuwać jak chcesz to problem zniknie)
            //dlatego też w wyniku odejmowałaś 1, bo te domyślnie zainicjalizowane zera były kolejnym duplikatem.
            foreach(var key in numberList)
            {
                if (dictList.ContainsKey(key))
                    dictList[key]++;
                else
                    dictList.Add(key, 1);
            }

            var numberOfDuplicates = dictList.Values.Where(value => value > 1).Count(); //zamiast pętli niżej tak bym to policzył, czyli: weź wszystkie wartości ze
            //słownika, dla których (where) liczba wystąpień jest > 1. Count() - podaje ilość takich liczb
            //To -1 wynika z tego samego błędu co wcześniej
            Console.WriteLine("Total no. of duplicates is {0}", numberOfDuplicates);
            
            Console.Read();
        }
    }
}
