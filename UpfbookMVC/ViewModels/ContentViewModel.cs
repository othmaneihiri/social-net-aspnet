using PhonebookMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhonebookMVC.ViewModel
{
    public class ContentViewModel: BaseModel
    {
        /// <summary>
        /// Get and set title of content 
        /// </summary>
        [Required]
        public string Title { get; set; }
        /// <summary>
        /// Get and set Description for content
        /// </summary>
        [Required]
        public string Description { get; set; }
        /// <summary>
        /// Get and set Content for content
        /// </summary>
        [AllowHtml]
        [Required]
        public string Contents { get; set; }
        /// <summary>
        /// Images
        /// </summary>
        [Required]
        public byte[] Image { get; set; }
    }
}