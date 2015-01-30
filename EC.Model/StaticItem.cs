using EC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace EC.Model
{
    /// <summary>
    /// creaated by saima hossain
    /// </summary>
    public class StaticItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string StaticName { get; set;  }
    }
}
