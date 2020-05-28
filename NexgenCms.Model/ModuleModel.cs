using PetaPoco;
namespace NexgenCms.Model {
    /// <summary>
    /// Module Model
    /// </summary>
    [PrimaryKey("ModuleID")]
    [TableName("Module")]
    public class ModuleModel {
        /// <summary>
        /// ModuleID
        /// </summary>
        public int ModuleID { get; set; }
    }
}