using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using MimeKit.Text;

namespace SweepstakesProject
{
    class MailClass
    {
        MimeMessage messageToSend = new MimeMessage
        {
            Sender = new MailboxAddress("Zach", "z.j.inkster@gmail.com"),
            Subject = "Congratulations, you won!",
        };
        public void MessageToWinner()
        {
            messageToSend.Body = new TextPart(MimeKit.Text.TextFormat.Plain){ Text = "Please visit our offices to claim your prize!" };
        }
    }
}
