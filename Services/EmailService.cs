public class EmailService
{
    private readonly string _smtpServer = "smtp.gmail.com"; // Serveur SMTP de Gmail
    private readonly int _port = 587; // Port pour TLS
    private readonly string _username = "moncompte@gmail.com"; // Votre adresse email
    private readonly string _password = "votre-mot-de-passe"; // Votre mot de passe

    public EmailService()
    {
        // Initialisation si nécessaire
    }

    public async Task SendEmailAsync(string to, string subject, string body)
    {
        using (var mailMessage = new MailMessage())
        {
            mailMessage.From = new MailAddress(_username);
            mailMessage.To.Add(to);
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            mailMessage.IsBodyHtml = true;

            using (var smtpClient = new SmtpClient(_smtpServer, _port))
            {
                smtpClient.Credentials = new NetworkCredential(_username, _password);
                smtpClient.EnableSsl = true; // Activez SSL pour la sécurité

                await smtpClient.SendMailAsync(mailMessage);
            }
        }
    }
}