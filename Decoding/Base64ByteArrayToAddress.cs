using System;
using System.Linq;
using Neo;
using Neo.IO;
using static Neo.Helper;

namespace Decoding
{
    public static class Base64ByteArrayToAddress
    {
        public static string base64ByteArrayToAddress(this string value)
        {
            byte[] result = Convert.FromBase64String(value).Reverse().ToArray();
            String hex = result.ToHexString();
            var scripthash = UInt160.Parse(hex);
            String address = Neo.Wallets.Helper.ToAddress(scripthash);
            return address;
        }
    }
}
