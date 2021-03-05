using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class MVCUsersModel
    {
        public int usr_id { get; set; }
        public string usr_nom { get; set; }
        public string email { get; set; }
        public int priv { get; set; }
        public bool activo { get; set; }
    }
}