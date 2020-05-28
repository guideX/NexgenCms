function GenericAjax(description, data, url, successUrl, failureUrl, action, contentType, type, dataType) {
    if (contentType == undefined || contentType === "") { contentType = "application/json; charset=utf-8"; }
    if (type == undefined || type === "") { type = "POST"; }
    if (dataType == undefined || dataType === "") { dataType = "json"; }
    if (failureUrl == undefined) failureUrl = "";
    if (successUrl == undefined) successUrl = "";
    $ajaxRequest = $.ajax({
        type: type,
        url: url,
        data: JSON.stringify(data),
        contentType: contentType,
        dataType: dataType,
        success: function (result) {
            if (result.Success) {
                switch (action) {
                    case -1: // Insert Content Type
                        alert("SUCCESS");
                        break;
                    default:
                        break;
                }
            } else {
                alert("Failure (" + description + "): " + result.Message);
            }
            return false;
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            $(".spnAjaxLoader").hide();
            ShowPopup("ERROR: " + errorThrown, 2, "Services Exception", "");
        }
    });
    return false;
}
/* Insert Content Types */
function InsertContentType(userName, emailAddress, loginGuid) {
    var data = {
        UserName: userName,
        EmailAddress: emailAddress,
        LoginGuid: loginGuid
    };
    GenericAjax("Create Content Type", data, "/Services/ContentTypes.svc/Create", undefined, undefined, -1);
    return false;
}
