using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraceletManagement
{
    static class StatusTypes 
    {
        public enum BraceletStatus
        {
            AVAILABLE,
            IN_USE,
            DEACTIVATED,
            NOT_VALID //reserved for not found RFIDs
        }
        public enum SearchType
        {
            CODE,
            EMAIL
        }
        public enum visitStatus
        {
            IN,
            OUT
        }
    }
}
