using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class TicketPriority
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Priority Name")]
        [Required(ErrorMessage = "Priority Name is required.")]
        [StringLength(TaskManagerConstants.MAX_PRIORITY_NAME_LENGTH, ErrorMessage = "Priority Name must be less than 50 characters")]
        public string Name { get; set; }

        [Display(Name = "Priority Description")]
        [Required(ErrorMessage = "Priority Description is required.")]
        [StringLength(TaskManagerConstants.MAX_PRIORITY_DESCRIPTION_LENGTH, ErrorMessage = "Priority Description must be less than 500 characters")]
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
