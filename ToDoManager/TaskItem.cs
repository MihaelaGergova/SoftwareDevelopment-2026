using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoManager
{
    internal class TaskItem
    {

        public int Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(int Id, string title, string description, DateTime deadline)
        {
            Id = Id;
            Title = title;
            Description = description;
            Deadline = deadline;
            IsCompleted = false;
        }

    }
}
