using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace tasks.Model
{
    public class NewTask
    {
        [Obsolete("Used only for NewTask binding")]
        public NewTask() { }

        [Required]
        [MaxLength(255)]
        public string ? Title { get; set; }

        [MaxLength(1024)]
        public string ? Description { get; set; }

        public List<string> ? Tags { get; set; }

        public DateTimeOffset OnADay { get; set; }

        public DateTimeOffset AtATime { get; set; }


        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ETaskStatus? Status { get; set; }


        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ETaskRepeat? Repeat { get; set; }
        

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ETaskPriority? Priority { get; set; }

        public TaskLocation ? Location { get; set; }

        public string ? Url { get; set; }

        public NewTask(string title = "", string description = "", List<string> tags = default(List<string>), DateTimeOffset onADay = default(DateTimeOffset), DateTimeOffset atATime = default(DateTimeOffset), ETaskStatus status = ETaskStatus.None, ETaskRepeat repeat = ETaskRepeat.Never, ETaskPriority priority = ETaskPriority.None, TaskLocation location = null, string url = "")
        {
            Title = title;
            Description = description;
            Tags = tags;
            OnADay = onADay;
            AtATime = atATime;
            Status = status;
            Repeat = repeat;
            Priority = priority;
            Location = location;
            Url = url;
        }
    }
}