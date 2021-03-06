using pdfforge.DataStorage.Storage;
using pdfforge.DataStorage;
using System.Collections.Generic;
using System.Text;
using System;

// ! This file is generated automatically.
// ! Do not edit it outside the sections for custom code.
// ! These changes will be deleted during the next generation run

namespace pdfforge.PDFCreator.Conversion.Settings
{
	/// <summary>
	/// Sends a mail without user interaction through SMTP
	/// </summary>
	public class EmailSmtpSettings {
		
		/// <summary>
		/// Add the PDFCreator signature to the mail
		/// </summary>
		public bool AddSignature { get; set; }
		
		/// <summary>
		/// E-mail address that is displayed as sender
		/// </summary>
		public string Address { get; set; }
		
		/// <summary>
		/// Body text of the mail
		/// </summary>
		public string Content { get; set; }
		
		/// <summary>
		/// If true, this action will be executed
		/// </summary>
		public bool Enabled { get; set; }
		
		/// <summary>
		/// Password that is used to authenticate at the server
		/// </summary>
		private string _password;
		public string Password { get { try { return Data.Decrypt(_password); } catch { return ""; } } set { _password = Data.Encrypt(value); } }
		
		/// <summary>
		/// SMTP server port
		/// </summary>
		public int Port { get; set; }
		
		/// <summary>
		/// The list of receipients of the E-mail, i.e. info@someone.com; me@mywebsite.org
		/// </summary>
		public string Recipients { get; set; }
		
		/// <summary>
		/// If true, the body of the EmailClient action will be used
		/// </summary>
		public bool SameTextAsClientMail { get; set; }
		
		/// <summary>
		/// Hostname or IP address of the SMTP server
		/// </summary>
		public string Server { get; set; }
		
		/// <summary>
		/// If true, the connection will be encrypted with SSL (must be supported by the server)
		/// </summary>
		public bool Ssl { get; set; }
		
		/// <summary>
		/// Subject line of the E-mail
		/// </summary>
		public string Subject { get; set; }
		
		/// <summary>
		/// User name that is used to authenticate at the server
		/// </summary>
		public string UserName { get; set; }
		
		
		private void Init() {
			AddSignature = true;
			Address = "";
			Content = "";
			Enabled = false;
			Password = "";
			Port = 25;
			Recipients = "";
			SameTextAsClientMail = false;
			Server = "";
			Ssl = false;
			Subject = "";
			UserName = "";
		}
		
		public EmailSmtpSettings()
		{
			Init();
		}
		
		public void ReadValues(Data data, string path)
		{
			try { AddSignature = bool.Parse(data.GetValue(@"" + path + @"AddSignature")); } catch { AddSignature = true;}
			try { Address = Data.UnescapeString(data.GetValue(@"" + path + @"Address")); } catch { Address = "";}
			try { Content = Data.UnescapeString(data.GetValue(@"" + path + @"Content")); } catch { Content = "";}
			try { Enabled = bool.Parse(data.GetValue(@"" + path + @"Enabled")); } catch { Enabled = false;}
			_password = data.GetValue(@"" + path + @"Password");
			try { Port = int.Parse(data.GetValue(@"" + path + @"Port"), System.Globalization.CultureInfo.InvariantCulture); } catch { Port = 25;}
			try { Recipients = Data.UnescapeString(data.GetValue(@"" + path + @"Recipients")); } catch { Recipients = "";}
			try { SameTextAsClientMail = bool.Parse(data.GetValue(@"" + path + @"SameTextAsClientMail")); } catch { SameTextAsClientMail = false;}
			try { Server = Data.UnescapeString(data.GetValue(@"" + path + @"Server")); } catch { Server = "";}
			try { Ssl = bool.Parse(data.GetValue(@"" + path + @"Ssl")); } catch { Ssl = false;}
			try { Subject = Data.UnescapeString(data.GetValue(@"" + path + @"Subject")); } catch { Subject = "";}
			try { UserName = Data.UnescapeString(data.GetValue(@"" + path + @"UserName")); } catch { UserName = "";}
		}
		
		public void StoreValues(Data data, string path)
		{
			data.SetValue(@"" + path + @"AddSignature", AddSignature.ToString());
			data.SetValue(@"" + path + @"Address", Data.EscapeString(Address));
			data.SetValue(@"" + path + @"Content", Data.EscapeString(Content));
			data.SetValue(@"" + path + @"Enabled", Enabled.ToString());
			data.SetValue(@"" + path + @"Password", _password);
			data.SetValue(@"" + path + @"Port", Port.ToString(System.Globalization.CultureInfo.InvariantCulture));
			data.SetValue(@"" + path + @"Recipients", Data.EscapeString(Recipients));
			data.SetValue(@"" + path + @"SameTextAsClientMail", SameTextAsClientMail.ToString());
			data.SetValue(@"" + path + @"Server", Data.EscapeString(Server));
			data.SetValue(@"" + path + @"Ssl", Ssl.ToString());
			data.SetValue(@"" + path + @"Subject", Data.EscapeString(Subject));
			data.SetValue(@"" + path + @"UserName", Data.EscapeString(UserName));
		}
		
		public EmailSmtpSettings Copy()
		{
			EmailSmtpSettings copy = new EmailSmtpSettings();
			
			copy.AddSignature = AddSignature;
			copy.Address = Address;
			copy.Content = Content;
			copy.Enabled = Enabled;
			copy.Password = Password;
			copy.Port = Port;
			copy.Recipients = Recipients;
			copy.SameTextAsClientMail = SameTextAsClientMail;
			copy.Server = Server;
			copy.Ssl = Ssl;
			copy.Subject = Subject;
			copy.UserName = UserName;
			
			return copy;
		}
		
		public override bool Equals(object o)
		{
			if (!(o is EmailSmtpSettings)) return false;
			EmailSmtpSettings v = o as EmailSmtpSettings;
			
			if (!AddSignature.Equals(v.AddSignature)) return false;
			if (!Address.Equals(v.Address)) return false;
			if (!Content.Equals(v.Content)) return false;
			if (!Enabled.Equals(v.Enabled)) return false;
			if (!Password.Equals(v.Password)) return false;
			if (!Port.Equals(v.Port)) return false;
			if (!Recipients.Equals(v.Recipients)) return false;
			if (!SameTextAsClientMail.Equals(v.SameTextAsClientMail)) return false;
			if (!Server.Equals(v.Server)) return false;
			if (!Ssl.Equals(v.Ssl)) return false;
			if (!Subject.Equals(v.Subject)) return false;
			if (!UserName.Equals(v.UserName)) return false;
			
			return true;
		}
		
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			
			sb.AppendLine("AddSignature=" + AddSignature.ToString());
			sb.AppendLine("Address=" + Address.ToString());
			sb.AppendLine("Content=" + Content.ToString());
			sb.AppendLine("Enabled=" + Enabled.ToString());
			sb.AppendLine("Password=" + Password.ToString());
			sb.AppendLine("Port=" + Port.ToString());
			sb.AppendLine("Recipients=" + Recipients.ToString());
			sb.AppendLine("SameTextAsClientMail=" + SameTextAsClientMail.ToString());
			sb.AppendLine("Server=" + Server.ToString());
			sb.AppendLine("Ssl=" + Ssl.ToString());
			sb.AppendLine("Subject=" + Subject.ToString());
			sb.AppendLine("UserName=" + UserName.ToString());
			
			return sb.ToString();
		}
		
		public override int GetHashCode()
		{
			// ReSharper disable once BaseObjectGetHashCodeCallInGetHashCode
			return base.GetHashCode();
		}
		
// Custom Code starts here
// START_CUSTOM_SECTION:GENERAL
// END_CUSTOM_SECTION:GENERAL
// Custom Code ends here. Do not edit below
		
	}
}
