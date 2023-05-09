using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace MedicineControls.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,MaxLength(20)]
        public string UserName { get; set; }
        [Required,MaxLength(20)]
        public string Password { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required,MaxLength(30)]
        public string Name { get; set; }
        [Required,MaxLength(30)]
        public string LastName { get; set; }

        //Navigation Property
        public IList<Medicine>? Medicines { get; set; }
    }
}
