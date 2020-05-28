using NexgenCms.Enum;
using PetaPoco;
namespace NexgenCms.Model {
    /// <summary>
    /// Content Type Model
    /// </summary>
    [PrimaryKey("ContentTypeID")]
    [TableName("ContentType")]
    public class ContentTypeModel {
        /// <summary>
        /// Content Type
        /// </summary>
        [Column("ContentTypeID")]
        public int ContentTypeID { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        [Column("Title")]
        public string Title { get; set; }
        /// <summary>
        /// Preview Before Submitting
        /// </summary>
        [Column("PreviewBeforeSubmitting")]
        public PreviewBeforeSubmittingEnum PreviewBeforeSubmitting { get; set; }
        /// <summary>
        /// Submission Guidelines
        /// </summary>
        public string SubmissionGuidelines { get; set; }
        /// <summary>
        /// Label
        /// </summary>
        [Column("Label")]
        public string Label { get; set; }
        /// <summary>
        /// Promoted To Front Page
        /// </summary>
        [Column("PromotedToFrontPage")]
        public bool PromotedToFrontPage { get; set; }
        /// <summary>
        /// Published
        /// </summary>
        [Column("Published")]
        public bool Published { get; set; }
        /// <summary>
        /// Display Author and Date Information
        /// </summary>
        [Column("DisplayAuthorAndDateInformation")]
        public bool DisplayAuthorAndDateInformation { get; set; }
        /// <summary>
        /// Default Comment Setting for New Comment
        /// </summary>
        public DefaultCommentSettingForNewCommentEnum DefaultCommentSettingForNewComment { get; set; }
    }
}