using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpSocialNetworkManager.Models
{
    public class User
    {
      
        public string Name { get; set; }    
        public string Email { get; set; }

        public bool IsActived { get; set; } = true;
        //fecha en que se creo usuario
        public DateTime DateCreated { get; set; }   = DateTime.Now; 

        public short Age { get; set; }

        public bool IsValid(bool validateAge)
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty (Email))
            
                return false;
           
            if ((Age < 0 || Age > 250) && validateAge)
           
                return false;
           
            return true;
        }

    }
}
