using Azure;
using Azure.Security.KeyVault.Certificates;
using Azure.Security.KeyVault.Secrets;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Crypt
{
    internal class Program
    {

        static void Main(string[] args)
        {

            var stringjsonData = @"{'claim1': '0', 'claim2': 'test@gmail.com'}";

            X509Certificate2 cert = CToken.GetSecurityCertificate("IIS Express Development Certificate");

            var encryptResult = Encrypt(cert, stringjsonData);

            var decryptResult = Decrypt(cert, encryptResult);

                //https://mchapikeyvault.vault.azure.net/certificates/ukcert/ec4f6068f9114bb5aa6fd238b6488ef1
            var _keyVaultName = $"https://mchapikeyvault.vault.azure.net/";
            var secretName = "ukcert";
            var azureServiceTokenProvider = new AzureServiceTokenProvider();
            var _client = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(azureServiceTokenProvider.KeyVaultTokenCallback));

            var secret = _client.GetSecretAsync(_keyVaultName, secretName);
            var privateKeyBytes = Convert.FromBase64String(secret.ToString());
            var certificate = new X509Certificate2(privateKeyBytes, string.Empty);

            

        }

        private static string Encrypt(X509Certificate2 x509, string stringToEncrypt)
        {
            if (x509 == null || string.IsNullOrEmpty(stringToEncrypt))
                throw new Exception("A x509 certificate and string for encryption must be provided");

            RSACryptoServiceProvider rsa = (RSACryptoServiceProvider)x509.PublicKey.Key;
            byte[] bytestoEncrypt = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt);
            byte[] encryptedBytes = rsa.Encrypt(bytestoEncrypt, false);
            return Convert.ToBase64String(encryptedBytes);
        }

        private static string Decrypt(X509Certificate2 x509, string stringTodecrypt)
        {
            if (x509 == null || string.IsNullOrEmpty(stringTodecrypt))
                throw new Exception("A x509 certificate and string for decryption must be provided");

            if (!x509.HasPrivateKey)
                throw new Exception("x509 certicate does not contain a private key for decryption");

            RSACryptoServiceProvider rsa = (RSACryptoServiceProvider)x509.PrivateKey;
            byte[] bytestodecrypt = Convert.FromBase64String(stringTodecrypt);
            byte[] plainbytes = rsa.Decrypt(bytestodecrypt, false);
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            return enc.GetString(plainbytes);
        }

        /// <summary>
        /// Certificate to be able to encrypt token
        /// </summary>
        public class CToken
        {


            /// <summary>
            /// Look for certificate in local machine
            /// </summary>
            /// <param name="subjectName">Certificate name as parameter</param>
            /// <returns>Certificate or null if not found</returns>
            public static X509Certificate2 GetSecurityCertificate(string subjectName)
            {
                X509Certificate2 securityCert = null;
                X509Store store = new X509Store(StoreName.My,
                  StoreLocation.LocalMachine);
                store.Open(OpenFlags.ReadOnly);
                try
                {
                    securityCert = null;
                    X509Certificate2Collection certs =
                        store.Certificates.Find(X509FindType.FindBySubjectName,
                        subjectName, true);

                    foreach (X509Certificate2 x509 in store.Certificates)
                    {

                        if (x509.FriendlyName == subjectName)
                        {

                            securityCert = x509;
                        }
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    if (store != null)
                        store.Close();
                }
                return securityCert;
            }



        }
    }
}
