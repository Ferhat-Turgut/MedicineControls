using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MedicineControls.Models
{
    public class Usage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public bool IsUsing { get; set; }
        [Required]
        public bool IsRegularUse { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime UseStartDate { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime UseQuitDate { get; set; }

        //Navigation Property
        
        public Medicine Medicine { get; set; }
    }
}
