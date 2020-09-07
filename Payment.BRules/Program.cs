using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Payment.BRules
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static string ReadInputRequest()
        {
            string paymentType = "";
            XmlDocument model = new XmlDocument();
            string directory = @"Input\PaymentInfo.xml";
            model.Load(directory);
            foreach (XmlNode node in model.DocumentElement.ChildNodes)
            {
                if (node.Name == "PaymentType")
                {
                    paymentType = node.InnerText;
                }
            }
            return paymentType;
        }
    }
}
