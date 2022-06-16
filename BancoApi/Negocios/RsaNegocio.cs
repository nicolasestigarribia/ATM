
using System.Security.Cryptography;
using System;
namespace BancoApi.Negocios
{

    public class RsaNegocio
    {

    }

    //public byte[] Encrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
    //{
    //    try
    //    {
    //        byte[] encryptedData;
    //        //Create a new instance of RSACryptoServiceProvider.
    //        using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
    //        {

    //            //Import the RSA Key information. This only needs
    //            //toinclude the public key information.
    //            RSA.ImportParameters(RSAKeyInfo);

    //            //Encrypt the passed byte array and specify OAEP padding.  
    //            //OAEP padding is only available on Microsoft Windows XP or
    //            //later.  
    //            encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
    //        }
    //        return encryptedData;
    //    }
    //    //Catch and display a CryptographicException  
    //    //to the console.
    //    catch (CryptographicException e)
    //    {
    //        Console.WriteLine(e.Message);

    //        return null;
    //    }
    //}

    //public static byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
    //{
    //    try
    //    {
    //        byte[] decryptedData;
    //        //Create a new instance of RSACryptoServiceProvider.
    //        using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
    //        {
    //            //Import the RSA Key information. This needs
    //            //to include the private key information.
    //            RSA.ImportParameters(RSAKeyInfo);

    //            //Decrypt the passed byte array and specify OAEP padding.  
    //            //OAEP padding is only available on Microsoft Windows XP or
    //            //later.  
    //            decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
    //        }
    //        return decryptedData;
    //    }
    //    //Catch and display a CryptographicException  
    //    //to the console.
    //    catch (CryptographicException e)
    //    {
    //        Console.WriteLine(e.ToString());
    //        Scaffold-DbContext "Data Source=ARES2016;Initial Catalog=ComunesTest;User ID=***;Password=***;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    
    //        return null;
    //    }Scaffold-dbContext "Server=(localdb)\Localhost;Database=User;User=TOLEDO\nestigarribia;Password=1234567" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

    //}
}
