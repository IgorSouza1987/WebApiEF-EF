using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography; 


namespace Projeto.Util
{
    public class Criptografia
    {
       
        public string EncriptarMD5(string valor)
        {
            
            MD5 md5 = new MD5CryptoServiceProvider();
            
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(valor));
           
            string result = string.Empty;
            foreach (var item in hash)
            {
                result += item.ToString("X2"); 
            }
            return result;
            
        }
    }
}