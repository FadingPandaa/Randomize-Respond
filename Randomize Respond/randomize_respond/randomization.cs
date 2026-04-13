using System;
using System.Collections.Generic;

namespace randomize_respond
{
    //Start 
   public class randomization
    {
        public randomization()
        {
            //Storing information for randomization

            List<string> respond = new List<string>(){"num1","num2","num3","num4","num5"};//paralle arrary
            //create a instanes for random class
            Random find_index = new Random();


            //get a randomize index
            int random_index = find_index.Next(0,respond.Count);

            //Display a randomize index
            Console.WriteLine(respond[random_index]);











        }//end constructor
    }//end of class
}// end of namespace