//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Text;

//namespace ConsoleApp1
//{
//    class Program
//    {


//        static void Main(string[] args)
//        {

//            string ApiRouteUrl = "http://192.192.192.210:8075/api/Index/GetIndexs";
//            //var jsonStringGetLabel = RequestGet(ApiRouteUrl);
//            //var jsonObjGetLabel = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonStringGetLabel);
//            //Dictionary<string, IndexModel> jsonObjGetLabelRes = JsonConvert.DeserializeObject<Dictionary<string, IndexModel>>((jsonObjGetLabel["Result"]).ToString());
//            var RequestJson = JsonConvert.SerializeObject("123");
//            var jsonString = RequestPost(ApiRouteUrl, RequestJson);

//            dynamic jsonObj = JsonConvert.DeserializeObject<object>(jsonString);
//            dynamic dataList = jsonObj["Result"]["Result"];



//        }


//        public static string RequestGet(string url)
//        {
//            //创建请求
//            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
//            request.Method = "GET";
//            request.ContentType = "application/json";
//            request.Timeout = 20000;
//            //读取返回消息
//            string res = string.Empty;
//            try
//            {
//                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
//                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
//                res = reader.ReadToEnd();
//                reader.Close();
//            }
//            catch (Exception ex)
//            {
//                //Logger.Instance().LogError("接口Get读取失败：" + url, ex);
//                return null;//连接服务器失败
//            }
//            return res;
//        }

//        public static string RequestPost(string url, string postData)
//        {
//            try
//            {
//                //发送请求的数据
//                WebRequest myHttpWebRequest = WebRequest.Create(url);
//                myHttpWebRequest.Method = "POST";
//                UTF8Encoding encoding = new UTF8Encoding();
//                byte[] byte1 = encoding.GetBytes(postData);
//                myHttpWebRequest.ContentType = "application/json";
//                myHttpWebRequest.ContentLength = byte1.Length;
//                Stream newStream = myHttpWebRequest.GetRequestStream();
//                newStream.Write(byte1, 0, byte1.Length);
//                newStream.Close();

//                //发送成功后接收返回的XML信息
//                HttpWebResponse response = (HttpWebResponse)myHttpWebRequest.GetResponse();
//                string lcHtml = string.Empty;
//                Encoding enc = Encoding.GetEncoding("UTF-8");
//                Stream stream = response.GetResponseStream();
//                StreamReader streamReader = new StreamReader(stream, enc);
//                lcHtml = streamReader.ReadToEnd();
//                return lcHtml;
//            }
//            catch (Exception ex)
//            {
//                //Logger.Instance().LogError("接口Post读取失败：" + url, ex);
//                //Logger.Instance().LogInfo("接口Post读取失败Info：" + ex.Message);
//                return "";
//            }
//        }




//    }
//}
