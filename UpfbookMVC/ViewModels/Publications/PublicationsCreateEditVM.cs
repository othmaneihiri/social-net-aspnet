using PhonebookMVC.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhonebookMVC.ViewModels.Publications
{
    public class PublicationsCreateEditVM : BaseVM
    {
        [Required]
        public string Titre { get; set; }
        public string Context { get; set; }

        public int UserID { get; set; }

        public User User { get; set; }

        public List<Publication> Publications { get; set; }
    }
}