using System;
using System.Collections.Generic;

namespace data_structures_2
{
    class Queue
    {
        private List<int> elements = new List<int>();

        //enqueue
        public void Enqueue(int elementsToEnqueue){
            elements.Add(elementsToEnqueue);
            Console.WriteLine($"Enqueue = {elementToEnqueue}");
            
        }

        //dequeue
        public int Dequeue(){
           int fristElement = elements[0];

           elements.RemoveAt(0);

           return fristElement;
        }   

        //front
        public int? Front(){
            int fristElement = elements[0];
            if (elements.Count == 0)
            {
                return null;
            }

            int fristElement = elements[0];

            return fristElement;
        }

        //rear
        public int? Rear(){
            if (elements.Count == 0)
            {
                return null;
            }

            int lastPosition = elements.Count - 1;

            return elements[lastPosition];
        }

        public override string ToString() {
            string queueAsString = "";
            queueAsString += "---------------------\n";
            foreach (var item in elements)
            {
                queueAsString += $"{item} | ";

            }
            queueAsString += "\n---------------------\n";

            return queueAsString;
        }
    }
}