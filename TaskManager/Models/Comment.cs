using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Models
{
    public class Comment
    {
       
        [Key]
        public int Id { get; set; }

        [Display(Name = "Ticket ID")]
        [Required(ErrorMessage = "Ticket ID is required")]
        [ForeignKey("TicketId")]
        public int TicketId { get; set; }

        [Display(Name = "User ID")]
        [Required(ErrorMessage = "User ID is required")]
        [ForeignKey("ApplicationUserId")]
        public int ApplicationUserId { get; set; }

        [StringLength(TaskManagerConstants.MAX_MESSAGE_LENGTH)]
        public string? Message { get; set; }

        public bool IsActive { get; set; }

        //Navigation property

        public Ticket Ticket { get; }
        public ApplicationUser ApplicationUser { get; set; }
        
    }
}
