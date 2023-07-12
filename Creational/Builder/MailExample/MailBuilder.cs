namespace Builder.MailExample
{
    public interface IEmailBuilder
    {
        IEmailBuilder SetSender(string sender);
        IEmailBuilder SetRecipient(string recipient);
        IEmailBuilder SetSubject(string subject);
        IEmailBuilder SetBody(string body);
        Email Build();
    }

    public class EmailBuilder : IEmailBuilder
    {
        private readonly Dictionary<string, string> keyValuePairs = new();
        public Email Build()
        => new(keyValuePairs["Sender"],
                                   keyValuePairs["Recipient"],
                                     keyValuePairs["Subject"],
                                       keyValuePairs["Body"]);


        public IEmailBuilder SetBody(string body)
        {
            keyValuePairs["Body"] = body;
            return this;
        }
        public IEmailBuilder SetRecipient(string recipient)
        {
            keyValuePairs["Recipient"] = recipient;
            return this;
        }
        public IEmailBuilder SetSender(string sender)
        {
            keyValuePairs["Sender"] = sender;
            return this;
        }

        public IEmailBuilder SetSubject(string subject)
        {
            keyValuePairs["Subject"] = subject;
            return this;
        }
    }

    public class Email
    {
        private string Sender { get; init; }
        private string Recipients { get; init; }
        private string Subject { get; init; }
        private string Body { get; init; }
        public void Send()
        {
            Console.WriteLine($"Sender : {Sender}");
            Console.WriteLine($"Recipients : {Recipients}");
            Console.WriteLine($"Subject : {Subject}");
            Console.WriteLine($"Body : {Body}");
            Console.WriteLine("Mail Sending.");
        }

        public Email(string sender, string recipients, string subject, string body)
        {
            Sender = sender;
            Recipients = recipients;
            Subject = subject;
            Body = body;
        }
    }
}
