﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    internal class Task
    {
      public string Name { get;  set ; }
      public string Description { get; set; }
      public string Date { get; set; }  

    
    
       public Task (string name, string description, string date)
        {
            Name = name;
            Description = description;
            Date = date;
        }
            
    
    
    
    
    
    
    
    
    
    }
}