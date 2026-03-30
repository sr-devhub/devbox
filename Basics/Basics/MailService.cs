using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public  class MailService
    {
        public void OnVideoEncoded(object sender,VideoEventArgs e)
        {
            Console.WriteLine("Sending an email..." + e.Video.Title);
        }
    }
}
