namespace ToDoListeParprogrammering
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();
            data.InitTasks();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("ToDo liste!");
                data.DrawList();
                Console.WriteLine("Velg en oppgave for å se mer informasjon");
                var input = Console.ReadLine();
                if (Convert.ToInt32(input) <= data.taskList.Count && Convert.ToInt32(input) > 0)
                {
                    int intinput = Convert.ToInt32(input);
                    data.DrawTask(intinput);
                }
                Console.ReadKey();
            }
        }
    }
}
/*
*Konsollbasert ToDo liste
*Lag en todo app! Du skal kunne legge til oppgaver, slette dem
*og gå inn på en task for å se beskrivelse eller flere detaljer
*/