﻿using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace Negocio.Services
{
    public class EmailService
    {
        private const string Senhaapp = "pghd zapz msju zhzz";
        private const string UsuarioApp = "miguel.zuqui@es.estudante.senai.br";
        private const string GmailSmtp = "smtp.gmail.com";
        private const int GmailPorta = 587;
        public string Remetente { get; private set; }
        public string Destinatario { get; private set; }
        public string Assunto { get; private set; }
        public string Menssagem { get; private set; }

        public EmailService(string remetente, string destinatario, string assunto, string menssagem)
        {
            Remetente = remetente;
            Destinatario = destinatario;
            Assunto = assunto;
            Menssagem = menssagem;

        }
        public bool EnviarEmail()
        {
            try
            {
                var menssage = new MimeMessage();
                menssage.From.Add(new MailboxAddress("", Remetente));
                menssage.To.Add(new MailboxAddress("", Destinatario));
                menssage.Subject = Assunto;
                menssage.Body = new TextPart("plain")
                {
                    Text = Menssagem
                };
                using (var client = new SmtpClient())
                {
                    client.Connect(GmailSmtp, GmailPorta, false);

                    // Note: only needed if the SMTP server requires authentication
                    client.Authenticate(UsuarioApp, Senhaapp);

                    client.Send(menssage);
                    client.Disconnect(true);
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}