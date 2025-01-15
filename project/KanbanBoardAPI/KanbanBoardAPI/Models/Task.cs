using Swashbuckle.AspNetCore.Annotations;

namespace KanbanBoardAPI.Models
{
    public class Task
    {
        [SwaggerSchema(ReadOnly = true)]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = "To Do"; // To Do, In Progress, Done
        public DateTime DueDate { get; set; }
    }
}
