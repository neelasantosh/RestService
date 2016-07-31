using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace RestServicesDemo
{
    [ServiceContract]
    interface iservice
    {
        [OperationContract]
        //we also have to specify metadata
        //1. Method can be GET os POST
        //2. Body style i.e. only data not function name or other things. Bare is commoly used. It is used only carrying for data. Supported by android , ios, wp
        //4. This is for client. UriTemplate is by which user will call it
        //example getOrders/101 and when requst comes this function will invoke
        //if we have multiple parameters than we can seperate them by {args1}/{args2}/{args3}
        [WebInvoke(Method="GET", BodyStyle=WebMessageBodyStyle.Bare, ResponseFormat=WebMessageFormat.Json, UriTemplate="getOrders/{custId}")]
        List<Order> getOrders(string custId);
        
        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, UriTemplate = "getOrder/{orderId}")]
        string getOrder(string orderId);
        
        [OperationContract]
        [WebInvoke(Method="GET", BodyStyle=WebMessageBodyStyle.Bare, ResponseFormat=WebMessageFormat.Json, UriTemplate="login/{userId}/{password}")]
        int login(string userId, string password);

    }
}
