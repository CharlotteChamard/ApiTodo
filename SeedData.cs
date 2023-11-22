public class SeedData
{
    public static void Init()
    {
        using (var context = new TodoContext())
        {
            // Look for existing content
            if (context.Todo.Any())
            {
                return;   // DB already filled
            }

            Todo vaisselle = new Todo
            {
                Task = "vaisselle",
                Completed = true,
                Deadline = DateTime.Parse("2016-09-01"),
            };
            Todo devoirs = new Todo
            {
                Task = "devoirs",
                Completed = false,
                Deadline = DateTime.Parse("2021-12-01"),
            };
            Todo sport = new Todo
            {
                Task = "sport",
                Completed = true,
                Deadline = DateTime.Parse("2023-11-01"),
            };

            context.Todo.AddRange(
                vaisselle,
                devoirs,
                sport
            );
            context.SaveChanges();
        }
    }
}