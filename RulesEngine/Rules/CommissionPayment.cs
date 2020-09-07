using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngine.Rules
{
    public class CommissionPayment : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "email")
            {
                return "Send Email";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
