namespace TodoApi.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public string Secret { get; set; }
    }


    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }

        public TodoItemDTO()
        {

        }

        public TodoItemDTO(TodoItem todoItem)
        {
            this.Id = todoItem.Id;
            this.Name = todoItem.Name;
            this.IsComplete = todoItem.IsComplete;
        }
    }

}
