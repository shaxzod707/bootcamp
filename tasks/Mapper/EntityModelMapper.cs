using System.Linq;
namespace tasks.Mapper
{
    public static class EntityModelMapper
    {
        public static Model.NewTask ToTaskModel(this Entity.Task task)
        {
            return new Model.NewTask(
                title: task.Title,
                description: task.Description,
                tags: task.Tags is null ? string.Empty : string.Join(",", task.Tags)tags,
                location: task.Location.ToString(),
                atATime: task.AtATime,
                onADay: task.OnADay,
                repeat: task.Repeat.ToModelTaskRepeat(),
                status: task.Status.ToModelTaskStatus(),
                priority: task.Priority.ToModelTaskPriority(),
                url: task.Url
            );
        }
    }
}