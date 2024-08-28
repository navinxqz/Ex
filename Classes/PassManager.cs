using System;

namespace AdminSystem.Classes
{
    public class PassManager
    {
        public string encryptedPass(string pass, int id)
        {
            if (string.IsNullOrEmpty(pass))
                throw new ArgumentException("Password can't be empty", nameof(pass));

            int key = id % 100;
            char[] p = pass.ToCharArray();

            for(int i = 0;i < p.Length; i++)
            {
                p[i] = (char)(p[i] + (key + i));
            }return new string(p);
        }

        public string decryptedPass(string pass, int id)
        {
            if (string.IsNullOrEmpty(pass))
                throw new ArgumentException("Password can't be empty", nameof(pass));

            int key = id%100;
            char[] p = pass.ToCharArray();

            for (int i = 0; i < p.Length; i++)
            {
                p[i] = (char)(p[i] - (key + i));
            }return new string(p);
        }
    }
}
