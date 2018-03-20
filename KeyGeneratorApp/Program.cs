using Microsoft.IdentityModel.Tokens;
using Microsoft.Owin.Security.DataHandler.Encoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KeyGeneratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\r\n"); 
                       
            //var clientId = Guid.NewGuid().ToString("N");
            //Console.WriteLine("New GUID for Clients is: " + clientId);

            //Console.WriteLine("\r\n");
            //Console.WriteLine("-----------------------------------------------------");
            //Console.ReadLine();


            //var key1 = new byte[64];
            //var rngObj = new RNGCryptoServiceProvider();
            //rngObj.GetBytes(key1);
            //Console.WriteLine("RNGCryptoServiceProvider Generated - Base64 Encoded Secret key is: " + TextEncodings.Base64Url.Encode(key1));

            //Console.WriteLine("\r\n");
            //Console.WriteLine("-----------------------------------------------------");
            //Console.ReadLine();


            //var key2 = new byte[64];
            //RandomNumberGenerator.Create().GetBytes(key2);
            //var base64Secret = TextEncodings.Base64Url.Encode(key2);            
            //Console.WriteLine("RandomNumberGenerator Generated - Base64 Encoded Secret key is: " + base64Secret );
            
            //Console.WriteLine("\r\n");
            //Console.WriteLine("-----------------------------------------------------");
            //Console.ReadLine();


            //for using as a secret key
            var key4 =  new byte[64];
            var rngObj2 = new RNGCryptoServiceProvider();
            rngObj2.GetBytes(key4);
            var encoded = TextEncodings.Base64Url.Encode(key4);



            //var decoded = TextEncodings.Base64Url.Decode(encoded);

            //using (var hmacsha256 = new HMACSHA256(key4))
            //{
            //    byte[] hashmessage = hmacsha256.ComputeHash(key4);               

            //    var base64Hashed = Convert.ToBase64String(hashmessage);

            //    // TextEncodings.Base64Url.Encode()

            //   var base64decoded = TextEncodings.Base64Url.Decode(base64Hashed);


            //    Console.WriteLine("HMACSHA256 hashed  - Base64 Encoded Secret key is: " + base64Hashed);
            //    Console.WriteLine("HMACSHA256 hashed  - Base64 Encoded Secret key is: " + base64decoded);
                


            //}

           


            Console.WriteLine("\r\n");
            Console.WriteLine("-----------------------------------------------------");
            Console.ReadLine();

            //string secret = Guid.NewGuid().ToString("N");
            //string message = "some secret message";
            //string key3 = "";
            //var encoding = new System.Text.ASCIIEncoding();


            //byte[] keyByte = encoding.GetBytes(secret);

            //byte[] messageBytes = encoding.GetBytes(message);

            //using (var hmacsha256 = new HMACSHA256(keyByte))
            //{
            //    byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
            //    key3 =  Convert.ToBase64String(hashmessage);
            //}

            //Console.WriteLine("HMAC - Base64 Encoded Secret key with message is: " + key3);

            //Console.WriteLine("\r\n");
            //Console.WriteLine("-----------------------------------------------------");
            //Console.ReadLine();


            //Console.ReadLine();

        }
    }
}
