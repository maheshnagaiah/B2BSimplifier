using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2BSimplifier.Common
{
    class UserCollection
    {
        public List<UserInfo> Users { get; set; }

        public int DelayedRedemption { get; set; }

        public bool SupressInvite { get; set; }




    }
    class UserInfo
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public bool IsExternal { get; set; }
    }
}
