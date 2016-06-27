using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraceletManagement
{
    public static class StatusTypes 
    {
        public enum BraceletStatus
        {
            STAND_BY,
            ACTIVE,
            DEACTIVATED,
            NOT_VALID //reserved for not found RFIDs
        }
        public enum SearchType
        {
            SECCODE,
            EMAIL
        }
        public enum visitStatus
        {
            IN,
            OUT
        }
    }
}
