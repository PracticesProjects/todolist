namespace MyNotes.Models
{
    public class Note
    {
        public int Id { get; set; }

        public String? Title { get; set; }

        public String? Description { get; set; }

        public String? Color { get; set; }

        public DateTime CreatedDate { get; set; }
        
    }
}