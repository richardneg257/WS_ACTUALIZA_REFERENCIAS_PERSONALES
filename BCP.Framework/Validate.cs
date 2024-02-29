using System;
using System.Net.Mail;

namespace BCP.Framework
{
    public class Validate
    {
        public static bool ToEmail(string email)
        {
            try
            {
                var mailCollect = new MailAddressCollection();
                foreach (var item in email.Split(';'))
                {
                    if (!string.IsNullOrEmpty(item))
                        mailCollect.Add(item);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
