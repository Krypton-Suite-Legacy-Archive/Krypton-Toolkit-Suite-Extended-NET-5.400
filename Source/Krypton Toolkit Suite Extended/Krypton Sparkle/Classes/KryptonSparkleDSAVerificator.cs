﻿using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;

namespace KryptonSparkle.Classes
{
    /// <summary>
    /// Class to verify a DSA signature
    /// </summary>
    public class NetSparkleDSAVerificator
    {
        private readonly DSACryptoServiceProvider _provider;

        /// <summary>
        /// Determines if a public key exists in this 
        /// </summary>
        /// <param name="publicKey"></param>
        /// <returns></returns>
        public static Boolean ExistsPublicKey(String publicKey)
        {
            // 1. try to load this from resource
            Stream data = TryGetResourceStream(publicKey) ?? TryGetFileResource(publicKey);

            // 2. check the resource
            return data != null;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="publicKey">the public key</param>
        public NetSparkleDSAVerificator(String publicKey)
        {
            // 1. try to load this from resource
            Stream data = TryGetResourceStream(publicKey) ?? TryGetFileResource(publicKey);

            // 2. check the resource
            if (data == null)
                throw new Exception("Couldn't find public key for verification");

            // 3. read out the key value
            using (StreamReader reader = new StreamReader(data))
            {
                String key = reader.ReadToEnd();
                _provider = new DSACryptoServiceProvider();
                _provider.FromXmlString(key);
            }
        }

        /// <summary>
        /// Verifies the DSA signature
        /// </summary>
        /// <param name="signature">expected signature</param>
        /// <param name="binaryPath">the path to the binary</param>
        /// <returns><c>true</c> if the signature matches the expected signature.</returns>
        public Boolean VerifyDSASignature(String signature, String binaryPath)
        {
            if (_provider == null)
                return false;

            // convert signature
            Byte[] bHash = Convert.FromBase64String(signature);

            // read the data
            byte[] bData;
            using (Stream inputStream = File.OpenRead(binaryPath))
            {
                bData = new Byte[inputStream.Length];
                inputStream.Read(bData, 0, bData.Length);
            }

            // verify
            return _provider.VerifyData(bData, bHash);
        }

        /// <summary>
        /// Gets a file resource
        /// </summary>
        /// <param name="publicKey">the public key</param>
        /// <returns>the data stream</returns>
        private static Stream TryGetFileResource(String publicKey)
        {
            Stream data = null;
            if (File.Exists(publicKey))
            {
                data = File.OpenRead(publicKey);
            }
            return data;
        }

        /// <summary>
        /// Get a resource stream
        /// </summary>
        /// <param name="publicKey">the public key</param>
        /// <returns>a stream</returns>
        private static Stream TryGetResourceStream(String publicKey)
        {
            Stream data = null;
            foreach (Assembly asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                var resourceName = asm.GetManifestResourceNames().FirstOrDefault(s => s.IndexOf(publicKey, StringComparison.OrdinalIgnoreCase) > -1);
                if (string.IsNullOrEmpty(resourceName))
                {
                    continue;
                }
                data = asm.GetManifestResourceStream(resourceName);
                if (data != null)
                    break;
            }
            return data;
        }
    }
}