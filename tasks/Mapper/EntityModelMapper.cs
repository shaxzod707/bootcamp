namespace tasks.Mapper
{
    public static class EntityModelMapper
    {
        public static Model.NewTask ToTaskModel(this Entity.Task task)
        {
            return new Model.NewTask(
                title: task.Title,
                description: task.Description,
                tags: task.Tags is null ? string.Empty : string.Join(",", task.Tags),
                location: task.Location.ToString(),
                atATime: task.AtATime,
                repeat: task.Repeat.ToModelTaskRepeat(),
                onADay: task.OnADay,
                status: task.Status.ToModelTaskStatus(),
                priority: task.Priority.ToModelTaskPriority(),
                url: task.Url
            );
        }
    }
}