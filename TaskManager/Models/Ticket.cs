using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Ticket Name")]
        [Required(ErrorMessage = "Ticket Name is required.")]
        [StringLength(TaskManagerConstants.MAX_TICKET_NAME_LENGTH, ErrorMessage = "Ticket Name must be less than 50 characters")]
        public string Name { get; set; }

        [Display(Name = "Ticket Description")]
        [Required(ErrorMessage = "Ticket Description is required.")]
        [StringLength(TaskManagerConstants.MAX_TICKET_DESCRIPTION_LENGTH, ErrorMessage = "Ticket Description must be less than 500 characters")]
        public string? Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        //Navigation Properties

        [Display(Name = "User")]
        [Required(ErrorMessage = "User is required")]
        [ForeignKey("ApplicationUserId")]
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [Display(Name = "Project")]
        [Required(ErrorMessage = "Project is required")]
        [ForeignKey("ProjectId")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        [Display(Name = "Ticket Type")]
        public int TicketTypeId { get; set; }

        [Display(Name = "Status")]
        public int TicketStatusId { get; set; }

        [Display(Name = "Priority")]
        public int TicketPriorityId { get; set; }


        public List<Comment> Comments { get; set; }

        public bool IsActive { get; set; }

    }
}
