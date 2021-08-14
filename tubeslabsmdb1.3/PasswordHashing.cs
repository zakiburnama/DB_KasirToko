using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace UASLABSMDB {
	public class PasswordHashing {
		public string HashingPassword(string val) {
			SHA256 sha256 = SHA256.Create();
			
			byte[] hashData = sha256.ComputeHash(Encoding.Default.GetBytes(val));
			StringBuilder returnValue = new StringBuilder();
			
			for (int i = 0; i < hashData.Length; i++)
	        {
	            returnValue.Append(hashData[i].ToString());
	        }
			
	        return returnValue.ToString();
		}
	}
}
