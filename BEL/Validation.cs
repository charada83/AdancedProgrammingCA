using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BAL
{
    public class Validation
    {

        public bool CheckEmail(string email)
        {
            bool IsValid = false;
            Regex r = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            if (r.IsMatch(email))
            {
                return IsValid = true;
            }
            return IsValid;
        }

    }
}
