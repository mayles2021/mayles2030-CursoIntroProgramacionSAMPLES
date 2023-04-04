using System;
using System.Collections;
using System.Linq;


class Program
{
    static void Main() {//Creating a queue collection
            
            Queue queue = new Queue();
            
            //Adding item to the queue using the Enqueue method
            queue.Enqueue(101);
            queue.Enqueue("Hello");
            queue.Enqueue(3.14f);
            queue.Enqueue(true);
            queue.Enqueue(67.8);
            

            Console.WriteLine("Numero de elementos: {0}", queue.Count);
            Console.WriteLine($"Numero de elementos: {queue.Count}");

            
            //Printing All Queue Elements using For Each Loop
            Console.WriteLine("Queue Elements:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //Copying the queue to an object array
            object[] queueCopy = new object[5];
            queue.CopyTo(queueCopy, 0);
            Console.WriteLine("\nQueue Copy Array Elements:");
            
            foreach (var item in queueCopy)
            {
                Console.WriteLine(item);
            }
            
            for (int i=0; i<5; i++){
                Console.WriteLine("Value:" + queueCopy[i]);
            }
            



            // using System.Linq;
            Queue planets = new Queue();
            planets.Enqueue("Mercury");
            planets.Enqueue("Venus");
            planets.Enqueue("Earth");
            
            foreach (var planet in planets)
            Console.WriteLine(planet);
            
            // iterate a Queue by converting it into an Array
            foreach (var planet in planets.ToArray())
            Console.WriteLine(planet);
            
            // Limpiado de Queue
            Console.WriteLine("While Count:");
            while (planets.Count > 0)
            Console.WriteLine(planets.Dequeue());
            
            Console.WriteLine("Empty:");
            foreach (var planet in planets)
            Console.WriteLine(planet);
        
    
            Console.ReadKey();

    }
}