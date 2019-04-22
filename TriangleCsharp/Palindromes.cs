using System;

namespace TriangleCsharp
{
    public class Palindromes
    {

        public bool CheckForPalindromes(string text)
        {
            text = text.Replace(" ", "");
            text = text.ToLower();
            if (Reverse(text) == text) 
                return true;
            return false;
        }

		public static string Reverse (string s)
		{
			char[] charArray = s.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}
    }
}
