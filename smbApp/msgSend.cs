using qcloudsms_csharp;
using qcloudsms_csharp.httpclient;
using qcloudsms_csharp.json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace smbApp
{
    public class msgSend
    {

        //public string sendMsg(string[] phoneNumbers, int templateId, string[] MsgBody)
        //{

        //    // 短信应用SDK AppID
        //    int appid = int.Parse(ConfigurationManager.AppSettings["appid"]);

        //    // 短信应用SDK AppKey
        //    string appkey = ConfigurationManager.AppSettings["appkey"];

        //    // 需要发送短信的手机号码
        //    //string[] phoneNumbers = { "13839870291", "15290319652" }; 

        //    string strRs = "";

        //    string smsSign = ""; // NOTE: 这里默认签名 
        //    for (int i = 0; i < phoneNumbers.Length; i++)
        //    {
        //        try
        //        {
        //            SmsSingleSender ssender = new SmsSingleSender(appid, appkey);
        //            var result = ssender.sendWithParam("86", phoneNumbers[i], templateId, MsgBody, smsSign, "", "");
        //            strRs += result;
        //        }
        //        catch (JSONException ex)
        //        {
        //            strRs += ";" + ex;

        //        }
        //        catch (HTTPException ex)
        //        {
        //            strRs += ";" + ex;

        //        }
        //        catch (Exception ex)
        //        {
        //            strRs += ";" + ex;

        //        }

        //    }
        //    return strRs;
        //}
    }
}
