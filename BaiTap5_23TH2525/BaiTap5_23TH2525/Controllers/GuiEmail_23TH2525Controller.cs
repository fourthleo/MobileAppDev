using BaiTap5_23TH2525.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace BaiTap5_23TH2525.Controllers
{
    public class GuiEmail_23TH2525Controller : Controller
    {
        // GET: GuiEmail_23TH2525
        public ActionResult SendMail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendMail(MailInfo model)
        {
            try
            {
                // Khởi tạo đối tượng MailMessage
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(model.From); // Địa chỉ người gửi
                mail.To.Add(model.To);                   // Địa chỉ người nhận
                mail.Subject = model.Subject;            // Tiêu đề email
                mail.Body = model.Body;                  // Nội dung email
                mail.IsBodyHtml = true;                  // Nếu muốn gửi email dưới dạng HTML

                // Cấu hình SMTP client
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential(model.From, model.Password);
                smtp.EnableSsl = true;

                // Gửi email
                smtp.Send(mail);

                // Sau khi gửi email thành công, điều hướng lại về trang Index
                ViewBag.Message = "Email đã gửi thành công!";
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Lỗi: " + ex.Message;
            }

            return View();
        }
    }
}
