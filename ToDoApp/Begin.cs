using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    internal class Begin
    {       
        private List<Task> task = new List<Task>();
               
        public void AddTask()
        {
            Console.Clear();
            Console.WriteLine("Skriv inn aktivitet.");
            var nameInput = Console.ReadLine();
            Console.WriteLine("Skriv in beskrivelsen av aktiviteten din");
            var descriptionInput = Console.ReadLine();
            task.Add(new Task(nameInput, descriptionInput));
            Meny();
        }

        public void ViewActivity()
        {
            Console.Clear();
            Console.WriteLine("Viser frem aktivitene dine");
            foreach (var task in task) 
            {
                Console.WriteLine($"{task.Name}\n Beskrivelse: {task.Description}");                
            }            
        }
        
        public void DeleteActivity()
        { 
            Console.Clear();
            foreach (var task in task)
            {
                Console.WriteLine($"{task.Name}");
            }
            Console.WriteLine("Hvilken aktivitet vil du fjerne?");
            var input = Convert.ToInt32(Console.ReadLine()) - 1;
            task.RemoveAt(input);        
        }
        
        public void Meny()
        {
            bool isRunning = true;
            Console.Clear();
            while (isRunning)
            {
            Console.WriteLine("1: Legg til aktivitetsplan");
            Console.WriteLine("2: Se på lagt inne planer");
            Console.WriteLine("3: Slett aktivitet");
                // stopper løkken.
            var userinput = Console.ReadLine();
                                
            switch (userinput)
            {
                case "1":
                    
                    AddTask(); 
                        break;
                        
                case "2":
                    ViewActivity();
                        break;

                case "3":
                        DeleteActivity();
                        break;
            }
               
        }

}
















        
        
        
        
        
        
    
        
        
        
        
       
    
    }
}
