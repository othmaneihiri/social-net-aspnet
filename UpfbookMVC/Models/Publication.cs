using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhonebookMVC.Models
{
    public class Publication : BaseModel
    {
        public string Titre { get; set; }
        public string Context { get; set; }
        public int UserID { get; set; }

        public virtual User User { get; set; }
    }
}