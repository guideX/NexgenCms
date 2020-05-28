using PetaPoco;
namespace NexgenCms.Model {
    /// <summary>
    /// Data Type Model
    /// </summary>
    [PrimaryKey("DataTypeID")]
    [TableName("DataType")]
    public class DataTypeModel {
        /// <summary>
        /// Data Type
        /// </summary>
        [Column("DataTypeID")]
        public int DataTypeID { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Column("Description")]
        public string Description { get; set; }
    }
}