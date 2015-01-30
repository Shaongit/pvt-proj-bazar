using EC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EC.Model
{
    public class StaticItemDet
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int StaticItemId { get; set; }
        public int ItemValue { get; set; }

        public string ItemText { get; set; }
    }
}
