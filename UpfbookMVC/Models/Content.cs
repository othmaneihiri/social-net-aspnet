using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhonebookMVC.Models
{
    /// <summary>
    /// regroupe tous les utilisateurs : table independant
    /// </summary>
    public class Content : BaseModel
    {
       
        public string Title { get; set; }
        public string Description { get; set; }
        public string Contents { get; set; }
        public byte[] Image { get; set; }
    }
}