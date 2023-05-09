using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicineControls.Models
{
    public class Medicine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public bool IsExist { get; set; }
      
        [Required]
        [Column(TypeName = "date")]
        public DateTime ExpirationDate { get; set; }
        public int PiecesInBox { get; set; }
        public int UsedPieces { get; set; }
        public int RemainingPieces { get; set; }
        public string? Description { get; set; }

        //Navigation Property
        public int UserId { get; set; }
        public User User { get; set; }
       
        public int UsageId { get; set; }
        public Usage Usage { get; set; }

        public IList<HoursOfUse>? HoursOfUse { get; set; }

   
    }
}
