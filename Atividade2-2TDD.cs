namespace Atividade2TDD;

public class Atividade2-2TDD
{
    using System;
using System.Net;
using System.Net.Mail;

public class EmailFormatValidator
{
    public bool IsValidEmailFormat(string email)
    {
        try
        {
            MailAddress mailAddress = new MailAddress(email);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }
}

public class DomainAvailabilityChecker
{
    public bool IsDomainActive(string email)
    {
        try
        {
            string domain = email.Split('@')[1];
            IPHostEntry hostEntry = Dns.GetHostEntry(domain);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}

public class MailServerChecker
{
    public bool IsMailServerResponding(string email)
    {
        try
        {
            string domain = email.Split('@')[1];
            using (var client = new SmtpClient(domain))
            {
                client.Port = 25;
                client.Timeout = 5000;
                client.Send(new MailMessage());
                return true;
            }
        }
        catch (Exception)
        {
            return false;
        }
    }
}

public class EmailValidatorService
{
    private readonly EmailFormatValidator formatValidator;
    private readonly DomainAvailabilityChecker domainChecker;
    private readonly MailServerChecker serverChecker;

    public EmailValidatorService(EmailFormatValidator formatValidator, DomainAvailabilityChecker domainChecker, MailServerChecker serverChecker)
    {
        this.formatValidator = formatValidator;
        this.domainChecker = domainChecker;
        this.serverChecker = serverChecker;
    }

    public bool IsValidEmail(string email)
    {
        return formatValidator.IsValidEmailFormat(email) && domainChecker.IsDomainActive(email) && serverChecker.IsMailServerResponding(email);
    }
}

}
