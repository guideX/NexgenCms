using PetaPoco;
namespace NexgenCms.Model {
    /// <summary>
    /// Field Type Model
    /// </summary>
    [PrimaryKey("FieldTypeID")]
    [TableName("FieldType")]
    public class FieldTypeModel {
        /// <summary>
        /// Field Type
        /// </summary>
        [Column("FieldTypeID")]
        public int FieldTypeID { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Column("Description")]
        public string Description { get; set; }
    }
}