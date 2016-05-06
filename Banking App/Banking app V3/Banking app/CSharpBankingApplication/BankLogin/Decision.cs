using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBankingApplication.BankLogin
{
    public class Decision
    {
  
        public void MakeDecision()
        {
            UserLogin username = new UserLogin();
            string myUsername = username.EnterUsername();
            UserAccount userAccount = new UserAccount();
            if (myUsername.ToLower().Contains("andre")|| myUsername.ToLower().StartsWith("and") || myUsername.ToLower().EndsWith("dre"))
            {
                userAccount.AndreAccount();
            }else if (myUsername.ToLower().Contains("casi") || myUsername.ToLower().StartsWith("cas") || myUsername.ToLower().EndsWith("si"))
            {
                userAccount.CasiAccount();
            }
            else if (myUsername.ToLower().Contains("samuel") || myUsername.ToLower().StartsWith("sam") || myUsername.ToLower().EndsWith("uel"))
            {
                userAccount.SamAccount();
            }
            else if (myUsername.ToLower().Contains("deji") || myUsername.ToLower().StartsWith("de") || myUsername.ToLower().EndsWith("ji"))
            {
                userAccount.DejiAccount();
            }
            else if (myUsername.ToLower().Contains("layo") || myUsername.ToLower().StartsWith("la") || myUsername.ToLower().EndsWith("yo"))
            {
                userAccount.LayoAccount();
            }
            else if (myUsername.ToLower().Contains("joy") || myUsername.ToLower().StartsWith("jo") || myUsername.ToLower().EndsWith("oy"))
            {
                userAccount.JoyAccount();
            }
            else if (myUsername.ToLower().Contains("bukky") || myUsername.ToLower().StartsWith("bu") || myUsername.ToLower().EndsWith("ky"))
            {
                userAccount.BukkyAccount();
            }
            else
            {
                throw new Exception("There is no such account on our system");
            }

        }
    }
}
