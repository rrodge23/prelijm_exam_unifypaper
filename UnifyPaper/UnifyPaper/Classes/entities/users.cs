using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnifyPaper.Classes.entities
{
    class users
    {
        public users()
        {

        }

        public string username { get; set; }
        public string password { get; set; }
        public string user_level { get; set; }
        public string updated_at { get; set; }
        public string created_at { get; set; }
    }
}
