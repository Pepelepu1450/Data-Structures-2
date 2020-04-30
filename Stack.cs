using System;
using System.Collections.Generic;

namespace Data_Structures_2
{
    class Stack
    {
        List<int> elements = new List<int>();

        //Push agraga elemento
        public void Push(int elementToPush){
            elements.Add(elementToPush);
        }

        //pop 
        public int Pop(){
            int lastIndex = elements.Count - 1;

            int lastElement = elements[lastIndex];

            //Destroy last element
            elements.RemoveAt(lastIndex);

            return lastIndex;
        }

        //top
        public int Top(){
            int lastIndex = elements.Count - 1;

            int lastElement = elements[lastIndex];


            return lastIndex;
        }

        //Bottom
        public int Bottom(){
            return elements[0];
        }

        
        public override string ToString() {
            string stackAsString = "";
            
            for (int i = 0; i < elements.Count; i++)
            {
                int inverseIndex = elements.Count - i - 1;

                //Asumamos que hay una lista de 5 elementos
                //elements.Count => 5
                //i = 0
                //5 - 0 - 1 => 4

                //i = 1
                //5 - 1 - 1 => 3

                stackAsString += elements[inverseIndex];
                stackAsString += "\n";
            }

            return stackAsString;
        }
    }
}
