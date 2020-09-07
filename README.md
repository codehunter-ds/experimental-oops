1) Step Of Execution:

- Change the PaymentType in PaymentInfo.xml file under Input folder of Payment.BRules csproj
Example: 
<?xml version="1.0" encoding="utf-8" ?>
<PaymentProcessing>
  <PaymentType>PhysicalProduct</PaymentType>
</PaymentProcessing>

- It must contains any one of the following values
 "PhysicalProduct","ProductBook","Membership","UpgradeMembership","Video"
                    