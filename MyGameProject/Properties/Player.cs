using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    class Player
    {
        public int PlayerId { get; set; }
        public string PlayerUserName { get; set; }
        public string PlayerPassword { get; set; }
        public string PlayerName { get; set; }
        public string PlayerLastName { get; set; }
        public string PlayerBirthDate { get; set; }
        public string PlayerNationalityNumber { get; set; }
        public string PlayerMail { get; set; }
        public string PlayerPhoneNumber { get; set; }
        public double PlayerWallet { get; set; }
        public Game Games { get; set; }

    }
}
