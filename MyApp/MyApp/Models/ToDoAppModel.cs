using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class ToDoAppModel
    {

        public int Id { get; set; }
        [Required]
        
        public string name { get; set; }
        

    }
}
