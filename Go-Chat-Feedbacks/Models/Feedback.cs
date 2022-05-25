using System.ComponentModel.DataAnnotations;

namespace Go_Chat_Feedbacks.Models
{
    public class Feedback
    {
        public int ID { get; set; }

        [Required]
        public string Username { get; set; }


        [Required, Range(0, 5)]
        public int Value { get; set; }

        [MaxLength(255)]
        public string? Content { get; set; }

        public DateTime Date { get; set; }
    }
}
