using Microsoft.AspNetCore.Identity;

namespace ChatRoom.Models
{
    public class User : IdentityUser
    {
        public virtual ICollection<ChatUser> Chats { get; set; }
    }
}
