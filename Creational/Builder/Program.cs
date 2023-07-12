
using Builder.MailExample;

var mail = new EmailBuilder()
    .SetSubject("Builder pattern hk.")
    .SetBody("")
    .SetSender("ahmet.yardimci98@gmail.com")
    .SetRecipient("")
    .Build();

mail.Send();
