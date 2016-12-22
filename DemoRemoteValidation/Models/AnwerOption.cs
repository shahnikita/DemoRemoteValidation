using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoRemoteValidation.Models
{
    public class AnwerOption
    {
        [Required(ErrorMessage="required")]
        [Remote("IsAnwerText", "Home")]
        public string Answer { get; set; }
    }

    public class AnwerOptionList {

        public List<AnwerOption> AnswerList { get; set; }
    }
}