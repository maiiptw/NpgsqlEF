using System.ComponentModel.DataAnnotations;

namespace CTMAPIER.Models
{
    public class Province
    {
        [Key]
        public string? ProvinceCode { get; set; }
        public string? Country { get; set; }
        public string? NameEng { get; set; }
        public string? NameLocal { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
