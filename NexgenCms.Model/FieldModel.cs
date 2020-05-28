using PetaPoco;
namespace NexgenCms.Model {
    /// <summary>
    /// Field
    /// </summary>
    [PrimaryKey("FieldID")]
    [TableName("Field")]
    public class FieldModel {
        /// <summary>
        /// FieldID
        /// </summary>
        [Column("FieldID")]
        public int FieldID { get; set; }
    }
}