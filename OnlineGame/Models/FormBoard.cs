using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineGame.Models
{
    public class FormBoard
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FormID { get; set; }
        public string FormNo { get; set; }

        public string FormType { get; set; }

        public string ApplyMan { get; set; }

    }
}