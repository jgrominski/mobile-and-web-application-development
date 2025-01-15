using KanbanBoardWeb.Models;
using System.Net.Http.Json;
using Task = KanbanBoardWeb.Models.Task;

namespace KanbanBoardWeb.Services
{
    public class TaskService
    {
        private readonly HttpClient _httpClient;

        public TaskService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Task>?> GetTasksAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Task>>("http://localhost:5036/api/Task");
        }
        public async Task<Task?> GetTaskByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Task>($"http://localhost:5036/api/Task/{id}");
        }

        public async Task<Task?> CreateTaskAsync(Task task)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5036/api/Task", task);
            return await response.Content.ReadFromJsonAsync<Task>();
        }

        public async Task<Task?> UpdateTaskAsync(Task task)
        {
            var response = await _httpClient.PutAsJsonAsync($"http://localhost:5036/api/Task/{task.Id}", task);
            return await response.Content.ReadFromJsonAsync<Task>();
        }

        public async Task<Task?> DeleteTaskAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"http://localhost:5036/api/Task/{id}");
            return await response.Content.ReadFromJsonAsync<Task>();
        }
    }
}
