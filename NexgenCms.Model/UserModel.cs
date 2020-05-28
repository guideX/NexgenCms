using PetaPoco;
namespace NexgenCms.Model {
    /// <summary>
    /// User Model
    /// </summary>
    [PrimaryKey("UserID")]
    [TableName("User")]
    public class UserModel {
        /// <summary>
        /// UserID
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// Username
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Email Address
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Login Guid
        /// </summary>
        public string LoginGuid { get; set; }
    }
}