using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Enums
{
    public enum Courses
    {
        Accountancy,
        Arts,
        Business,
        Music,
        [Description("Software Development")]
        SoftwareDevelopment        
    }
}
