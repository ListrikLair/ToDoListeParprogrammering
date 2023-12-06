using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListeParprogrammering
{
    internal class Data
    {
        public List<Task> taskList = new List<Task>();

        public void InitTasks()
        {
            taskList.Add(new Task("Handle middag", "Dra på butikken og handle middag", 18));
            taskList.Add(new Task("Trene", "Dunno as, lift sum weigths", 21));
            taskList.Add(new Task("Se på Skal vi Danse", "Legge seg godt til på sofaen", 20));
        }

        public void DrawList()
        {
            int index = 1;
            foreach (var task in taskList)
            {
                Console.WriteLine($"({index}){task._title}");
                index++;
            }
        }

        public void DrawTask(int input)
        {
            Console.WriteLine($"Tittel: {taskList[input - 1]._title}");
            Console.WriteLine($"Beskrivelse: {taskList[input - 1]._description}");
            Console.WriteLine($"Må være ferdig innen klokken {taskList[input - 1]._deadline}:00");
            Console.WriteLine();
            Console.WriteLine("Trykk på x for å slette denne oppgaven");
            //Console.ReadLine();
            //Legg til mulighet for å slette den aktive oppgaven
        }

        public void AddTask(Task task)
        {
            taskList.Add(task);
        }

        public void RemoveTask(Task task)
        {
            taskList.Remove(task);
        }
    }
}
