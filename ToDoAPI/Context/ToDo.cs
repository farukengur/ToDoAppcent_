using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




namespace ToDoAPI.Context 
{
    public class TooDo: BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int Status { get; set; }

    }
}
