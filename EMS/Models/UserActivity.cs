using System.Security;

namespace EMS.Models
{
    public class UserActivity
    {
        public String? CreatedById { get; set; }
        public DateTime CreatedOn { get; set; }
        public String? ModifiedById { get; set; }
        public DateTime ModifiedOn { get; set; }

    }
}
