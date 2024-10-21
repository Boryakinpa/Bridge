using Bridge;

class Program
{
    static void Main(string[] args)
    {
        INotificationSender emailSender = new EmailSender();
        INotificationSender smsSender = new SmsSender();

        Notification textEmailNotification = new TextNotification(emailSender);
        Notification textSmsNotification = new TextNotification(smsSender);
        Notification htmlEmailNotification = new HtmlNotification(emailSender);
        Notification htmlSmsNotification = new HtmlNotification(smsSender);

        textEmailNotification.Notify("Текст в емейле");
        textSmsNotification.Notify("Текст в смске");
        htmlEmailNotification.Notify("хтмл страница в емейле");
        htmlSmsNotification.Notify("хтмл страница в смске");
    }
}
