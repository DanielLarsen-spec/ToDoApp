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
            
            
            Console.WriteLine("Skriv inn navnet ditt.");
            var nameInput = Console.ReadLine();
            Console.WriteLine("Skriv in beskrivelsen av aktiviteten din");
            var descriptionInput = Console.ReadLine();
            Console.WriteLine("Skriv inn dato og tid?");
            var dateInput = Console.ReadLine();
            task.Add(new Task( nameInput, descriptionInput, dateInput));
        
        }
        
        public void ViewActivity()
        {

        }
        
        public void DeleteActivity()
        {
                
        }
        
        
        
        
        
        public void Meny()
        {
           Console.WriteLine("1: Legg til aktivitetsplan");
           Console.WriteLine("2: Se på lagt inne planer");
           Console.WriteLine("3: Slett aktivitet");
            var userinput = Console.ReadLine();
            bool isRunning = true;
            while (isRunning)
            {
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

                default:
                        isRunning = false;
                        break;

        
        
        
            }
        

            }

        }
        public void Run() 
        {
            Meny(); 

        }     
















        
        
        
        
        
        
    
        
        
        
        
       
    
    }
}
