using System.ComponentModel.DataAnnotations;

namespace Revisor.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public string? Author { get; set; }
        [DataType(DataType.Date)]
        public DateTime Rate { get; set; }
    }
}
