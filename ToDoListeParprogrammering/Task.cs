using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListeParprogrammering
{
    internal class Task
    {
        public string _title { get; }
        public string _description { get; }
        public int _deadline { get; }

        public Task(string title, string description, int deadline)
        {
            _title = title;
            _description = description;
            _deadline = deadline;
        }
    }
}
