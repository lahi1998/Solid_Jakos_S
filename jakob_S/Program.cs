using jakob_S;
public enum MessageCarrier { Smtp, VMessage }

public class Message
{

    string to, from, body, subject, cc;

    public Message(string to, string from, string body, string subject, string cc)
    {
        this.to = to;
        this.from = from;
        this.body = body;
        this.subject = subject;
        this.cc = cc;
    }

    public string To { get => to; set => to = value; }
    public string From { get => from; set => from = value; }
    public string Body { get => body; set => body = value; }
    public string Subject { get => subject; set => subject = value; }
    public string Cc { get => cc; set => cc = value; }

    public class HTMLConverter : IConverter
    {
        public string ConvertBodyToHTML(string text)
        {
            //konverter text til HTML
            return "<html><body>" + text + "</body></html>";
        }
    }

    public class SmtpMessageHandler : IMessage
    {
        HTMLConverter c = new HTMLConverter();
        public void sendMessage(MessageCarrier type, Message m, bool isHTML)
        {
            // Verificer MessageCarrier type
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = c.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }
        }

        public void sendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            // Verificer MessageCarrier type
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = c.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }
        }
    }

    public class VMessageHandler : IMessage
    {
        HTMLConverter c = new HTMLConverter();
        public void sendMessage(MessageCarrier type, Message m, bool isHTML)
        {
            // Verificer MessageCarrier type
            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = c.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }

        public void sendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            // Verificer MessageCarrier type
            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = c.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }
    }
}