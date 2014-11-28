using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace EsatCarmen.Common
{
    public  class SendEmail
    {
        /// <summary>
        /// 功能：异步发送邮件。Task.Factory.StartNew(() =>{ SendMails()});
        /// </summary>
        /// <param name="MailTo">MailTo为收信人地址</param>
        /// <param name="Subject">Subject为标题</param>
        /// <param name="Body">Body为信件内容</param>
        public static void SendMails(string MailTo, string Subject, string Body,Action errorcallback)
        {
            SmtpClient mailclient = new SmtpClient();
            //发送方式
            mailclient.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtp服务器
            mailclient.Host = "smtp.126.com";
            //用户名凭证               
            mailclient.Credentials = new System.Net.NetworkCredential("xingfeifei2014", "password01!");
            //mailclient.Credentials = new System.Net.NetworkCredential("fnfqp1992", "789632145");
            //邮件信息
            MailMessage message = new MailMessage();
            //发件人
            message.From = new MailAddress("xingfeifei2014@126.com");
            //收件人
            message.To.Add(new MailAddress(MailTo,MailTo.ToString(),Encoding.UTF8));
            //邮件标题编码
            message.SubjectEncoding = Encoding.UTF8;
            //主题
            message.Subject = Subject;
            //内容
            message.Body = Body;
            //正文编码
            message.BodyEncoding = Encoding.UTF8;
            //设置为HTML格式
            message.IsBodyHtml = true;
            //优先级
            message.Priority = MailPriority.High;
            //事件注册
            mailclient.SendCompleted += (s1, e1) =>{ if (e1.Error != null){ errorcallback();}};
            //异步发送
            mailclient.SendAsync(message, message.To);
        }
    }
}
