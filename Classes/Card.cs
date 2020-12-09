using System;
namespace Card_Registration.Classes
{
    public class Card
    {
        private string number;

        public string Number {    // start attribute with uppercase to use GET and SET!

            get {return number;}

            set {number = value;}

        }

        
        
        private string flag;

        public string Flag {    

            get {return flag;}

            set {flag = value;}

        }
        
        
        
        private string cardName;

        public string CardName {    

            get {return cardName;}

            set {cardName = value;}

        }
        
        
        
        protected string token = "qwertyui";

        public string Token {

            get {return token;}


        }

        
        
        private string cvv;


        public string CVV {get;set;}  // Shorter Syntax for the GET and SET used in examples above (number,flag..)


        
        
        
        protected float limit = 5000;

        
        public float Limit {get;set;}

        
        
        
        
        public string RegisterPurchase(bool validate) {

            return "";
        
        }
    
    
    }
}