using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    interface IVerificationService
    {
        void VerificateWithEmail();
        void VerificateWithSms();
        void VerificateWithEdevlet();
    }
}
