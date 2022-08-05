using System.ComponentModel.DataAnnotations;

namespace EFCodeFirst.Model.Entity
{
    public class OrnekTablo
    {
        [Key]
        public int Id { get; set; }
        public string Kolon1 { get; set; }
        public string Kolon2 { get; set; }
    }
}
