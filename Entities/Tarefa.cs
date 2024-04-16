using TrabalhandoComEntityFramework.Enums;

namespace TrabalhandoComEntityFramework.Entities
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public StatusEnum Status { get; set; } = 0;



    }
}
