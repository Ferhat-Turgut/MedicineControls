using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MedicineControls.Models
{
    public class HoursOfUse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "time")]
        public TimeSpan UseTime { get; set; }

        //Navigation Property
        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }
    }
}
