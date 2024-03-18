using System.ComponentModel.DataAnnotations;

namespace AgGrid.Models
{
    public class Product
    {
        [Key]
        public int pId { get; set; }
        public string pName { get; set; }
        public int pQuantity { get; set; }
        public string pCategory { get; set; }
    }
}
