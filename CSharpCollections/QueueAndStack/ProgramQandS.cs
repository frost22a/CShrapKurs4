//using System;
//using System.Collections;
//using System.Collections.Generic;

//namespace QueueAndStack
//{
//    //class ProgramQandS
//    //{
//        //static void Main(string[] args)
//        //{
//        //    #region QUEUE
//        //    Queue<Customer> queue = new Queue<Customer>();
//        //    queue.Enqueue(new Customer { Name = "Marcin" });
//        //    queue.Enqueue(new Customer { Name = "Przemek" });
//        //    queue.Enqueue(new Customer { Name = "Mariola" });
//        //    queue.Enqueue(new Customer { Name = "Leon" });
//        //    queue.Enqueue(new Customer { Name = "Iza" });
//        //    queue.Enqueue(new Customer { Name = "Piort" });

//        //    while (queue.Count > 0)
//        //    {
//        //        var customer = queue.Dequeue(); // dequeue - wyciąga pierwszy element z kolejki i jednocześnie go z niej usuwa
//        //        Console.WriteLine(customer.Name);
//        //        Console.WriteLine($"Ilość w kolejce: {queue.Count}");
//        //    }

//        //    var queue2 = new Queue<int>();
//        //    queue2.Enqueue(1);
//        //    queue2.Enqueue(2);
//        //    queue2.Enqueue(3);
//        //    queue2.Enqueue(4);
//        //    queue2.Enqueue(5);
//        //    queue2.Enqueue(6);

//        //    Console.WriteLine("peek:");
//        //    Console.WriteLine(queue2.Peek()); // peek - pozwala zajrzeć, co jest na pierwszym miejscu w kolejce

//        //    //contains:
//        //    bool zawiera = queue2.Contains(3);
//        //    Console.WriteLine("contains:");
//        //    Console.WriteLine(zawiera);

//        //    // konwersja do tablicy:

//        //    var array = queue2.ToArray();
//        //    Console.WriteLine("to array:");
//        //    for (int i = 0; i < array.Length; i++)
//        //    {
//        //        Console.WriteLine(array[i]);
//        //    }

//        //    //czyszczenie kolejki - CLEAR();
//        //    #endregion

//        //    #region STACK

//        //    Stack<Book> stack = new Stack<Book>();
//        //    stack.Push(new Book { Name = "Book 1" });
//        //    stack.Push(new Book { Name = "Book 2" });
//        //    stack.Push(new Book { Name = "Book 3" });
//        //    stack.Push(new Book { Name = "Book 4" });
//        //    stack.Push(new Book { Name = "Book 5" });
//        //    stack.Push(new Book { Name = "Book 6" });

//        //    //metoda Pop = pobiera pierwszy element stosu i usuwa go ze stosu
//        //    while (stack.Count > 0)
//        //    {
//        //        var book = stack.Pop(); 
//        //        Console.WriteLine(book.Name);
//        //        Console.WriteLine($"Ilość w kolejce: {stack.Count}");
//        //    }

//        //    // peek - działa jak w kolejce
//        //    // contains - j.w.
//        //    // toArray() - j.w.
//        //    // clear - j.w.

//        //    #endregion
//        }
//    }
//}
