using System.ComponentModel.DataAnnotations;
namespace Blazor_App.Data

{
    public class Grocery
    {
        [Required]
        [StringLength(15,ErrorMessage = "Name should be less then 15 characters.")]

        public string Name { get; set; }
        [Required]
        [Range(1,10000,ErrorMessage = "valid price range is (1-10000")]
        public float Price { get; set; }
    }
}