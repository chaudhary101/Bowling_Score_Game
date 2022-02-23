using FileConverterUtility;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FileConvertMachanismUtility
{
    class Program
    {
        private static string originalFile = @"C:\FileCoversion\AddressProof1.rar";
        private static string encryptedFile = "AddressProof1.enc"; 
        //private static string decrFolder = @"C:\FileCoversion\Decrypt\";

        static void Main(string[] args)
        { 
            var hashValue = Coverter.GetMD5HashFromFile(originalFile);
            Console.WriteLine("Hash Value :" + hashValue);

            // Get the certifcate to use to encrypt the key.
            X509Certificate2 certPublic = Coverter.GetCertificateFromStore("localhost");
            if (certPublic == null)
            {
                Console.WriteLine("Certificate 'CN=CERT_SIGN_TEST_CERT' not found.");
                Console.ReadLine();
            }
             
            Console.WriteLine("Encoding Value :" + hashValue);

            var encryptedData = Coverter.EncryptData(certPublic.PublicKey.Key.ToXmlString(false), hashValue);

            Console.WriteLine("EncryptData Value :" + encryptedData); 

            X509Certificate2 certPrivteKey = Coverter.GetCertificateFromStore("localhost");
            if (certPrivteKey == null)
            {
                Console.WriteLine("Certificate 'CN=CERT_SIGN_TEST_CERT' not found.");
                Console.ReadLine();
            }

            var decryptedData = Coverter.DecryptData(certPrivteKey.PrivateKey.ToXmlString(true), encryptedData);

            Console.WriteLine("DecryptData Value :" + decryptedData);

            Console.WriteLine();


            Console.WriteLine("Started the encryption..."); 

            // Encrypt the file using the public key from the certificate.
            Coverter.EncryptFile(originalFile, (RSA)certPublic.PublicKey.Key);
             
            // Decrypt the file using the private key from the certificate.
            Coverter.DecryptFile(encryptedFile, certPrivteKey.GetRSAPrivateKey());

            Console.WriteLine("Press the Enter key to exit.");
            Console.ReadLine();
        } 
    }
}
