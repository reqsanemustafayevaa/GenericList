using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ListGenericType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.1  Bir string list yaradın və onu 5 fərqli ad ilə doldurun. Bu listin elementlərini konsola çap
            //    edin və listə yeni bir ad əlavə edin və sonra yenidən konsolda çap edin.
            //List<string> names = new List<string>();
            //names.Add("Ragsana");
            //names.Add("Ramzes");
            //names.Add("Sabina");
            //names.Add("ElvinPanel");
            //names.Add("Tanzila");
            //for (int i = 0; i < names.Count; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            //names.Add("Joseph");
            //Console.WriteLine(names[names.Count - 1]);

            //3.2.Bir integer List yaradın və onu 10 fərqli dəyərlə doldurun.Bu List-in elementlərini konsola
            //    çap edin, müəyyən bir elementi silin və yenidən çap edin.
            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.Add(4);
            //numbers.Add(5);
            //numbers.Add(6);
            //numbers.Add(7);
            //numbers.Add(8);
            //numbers.Add(9);
            //numbers.Add(10);
            //Console.WriteLine("List");
            //for (int i = 0;i < numbers.Count;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //numbers.Remove(4);
            //Console.WriteLine("New List");
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //3.3.Bir ArrayList yaradın və onu fərqli tipli 5 element ilə doldurun.Bu ArrayList-in
            //    elementlərini konsola çap edin.

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(8);
            //arrayList.Add("Ragsana");
            //arrayList.Add(3.2F);
            //arrayList.Add('s');
            //arrayList.Add(8000M) ;
            //for(int i = 0;i<arrayList.Count ; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}

            //3.4.Bir ArrayList yaradın və onu integer dəyərlərlə doldurun.ArrayList -in 
            //    elementlərini konsola çap edin, sonra yeni elementlər əlavə edin və yenidən çap edin.
            //ArrayList arrayList = new ArrayList()
            //{
            //    2,7,33,42,21
            //};

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //arrayList.Add(2);
            //arrayList.Add("Salam");
            //Console.WriteLine("new arraylist");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //3.5.Bir Dictionary yaradın və onu 5 fərqli tələbə adı və onların yaşları ilə doldurun.
            //    Bu Dictionary-nin elementlərini konsola çap edin.
            //Dictionary<byte,string> student = new Dictionary<byte,string>();
            //student.Add(19, "Ragsana");
            //student.Add(26, "Maya");
            //student.Add(22,"Tanzila");
            //student.Add(20, "Tanzila");
            //student.Add(15, "Nicat");
            //foreach (var item in student)
            //{
            //    Console.WriteLine(item);
            //}

            //3.6.Bir Dictionary yaradın və onu 5 fərqli tələbə adı və onların yaşları ilə doldurun.
            //    Dictionary - dən müəyyən bir tələbəni silin və yenilənmiş Dictionary - ni konsola çap edin.
            //Dictionary<byte, string> human = new Dictionary<byte, string>();
            //human.Add(19, "Ragsana");
            //human.Add(26, "Maya");
            //human.Add(22, "Tanzila");
            //human.Add(20, "Tanzila");
            //human.Add(15, "Nicat");
            //human.Remove(19);
            //foreach (var item in human)
            //{
            //    Console.WriteLine(item);
            //}

            //3.7.Bir SortedList yaradın və onu 3 fərqli kitab adı və onların müəllifləri ilə doldurun.
            //    SortedList - ə yeni bir kitab əlavə edin və yenilənmiş SortedList-i konsola çap edin.
            SortedList<string, string> items = new SortedList<string, string>();
            items.Add("macakizi", "Dilara Pamuk");
            items.Add("Atespare", "Ceren Melek");
            items.Add("Sokak nobetculeri", "Asli Arslan");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            items.Add("Yaralasar", "Maral Atmaca");
            Console.WriteLine("new list");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }








        }
    }
}
