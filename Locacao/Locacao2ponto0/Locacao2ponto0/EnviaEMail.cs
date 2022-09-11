using Locacao2ponto0.Models;
using System;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Locacao2ponto0
{

	public class EnviaEmail
	{
		Locacao2ponto0Context db = new Locacao2ponto0Context();
			 
		public void VeririficaParaEnviarEmail()
		{
				
		}

		//Metodo para envio de E-mail 
		public static string EnviarEmailAprovados(string emailEnviarPara, string seuEmail, string suaSenha, string seuNome)
		{
			MailMessage message = new MailMessage();
			message.IsBodyHtml = true;
			message.From = new MailAddress(seuEmail, seuNome);
			message.To.Add(new MailAddress(emailEnviarPara));
			message.Subject = "Aprovação de Cadastro";
			message.Body = "Sua solicitação de aluguel de vaga de garagem foi aprovada!";
			using (var client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587))
			{
				client.Credentials = new System.Net.NetworkCredential(seuEmail, suaSenha);
				client.EnableSsl = true;

				try
				{
					client.Send(message);
					return "Email enviado!";
				}
				catch (Exception ex)
				{
					return "Erro ao enviar email: " + ex.Message;
				}

			}
		}

	}

}