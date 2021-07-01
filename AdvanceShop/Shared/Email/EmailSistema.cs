using AdvanceShop.Shared.CustomMessageBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Shared.Email
{
    public static class EmailSistema 
    {
        public static string email = "naoresponda@advanceshopsistema.com.br";
        public static string senha = "n#hzU5BbWx8m";
        public static string host = " smtps.uhserver.com";
        public static int porta = 465;
        public static bool EnableSsl = true;
        public static bool UseDefaultCredentials = false;
        public async static void EnviarEmailComAnexo(string Para,string CC,string CC2,string Assunto,string Mensagem, string Anexo)
        {
            using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
            {
                smtp.Host = host;
                smtp.Port = porta;
                smtp.EnableSsl = EnableSsl;
                smtp.UseDefaultCredentials = UseDefaultCredentials;
                smtp.Credentials = new System.Net.NetworkCredential(email, senha);

                using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                {
                    mail.From = new System.Net.Mail.MailAddress(email);

                    if (!string.IsNullOrWhiteSpace(Para))
                    {
                        mail.To.Add(new System.Net.Mail.MailAddress(Para));
                    }
                    else
                    {
                        MessageBoxError.Show("Campo 'para' é obrigatório.");
                        return;
                    }
                    if (!string.IsNullOrWhiteSpace(CC))
                        mail.CC.Add(new System.Net.Mail.MailAddress(CC));
                    if (!string.IsNullOrWhiteSpace(CC2))
                        mail.Bcc.Add(new System.Net.Mail.MailAddress(CC2));
                    mail.Subject = Assunto;
                    mail.Body = Mensagem;
                    mail.Attachments.Add(new Attachment(Anexo));

                    await smtp.SendMailAsync(mail);
                }
            }
        }
    }
    
}
