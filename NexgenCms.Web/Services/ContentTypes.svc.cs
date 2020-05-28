using NexgenCms.Business.Business;
using NexgenCms.Business.Interfaces.Business;
using NexgenCms.Core.Models;
using NexgenCms.Extenders;
using NexgenCms.Model;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
namespace NexgenCms.Services {
    /// <summary>
    /// Content Type
    /// </summary>
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class ContentTypes : WcfServiceExtender {
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        public AjaxResultModel Insert(ContentTypeModel obj) {
            using (IContentTypeBusiness cb = new ContentTypeBusiness(Configuration, Conn)) 
                return cb.Insert(obj);
        }
    }
}