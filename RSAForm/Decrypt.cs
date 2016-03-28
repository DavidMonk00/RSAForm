using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

namespace RSA
{
    class Decrypt
    {
        string key_file;
        PrivateKey privatekey;
        string filepath;
        string decrypt_filepath;
        string[] m;
        private void GetKey()
        {
            string[] lines = File.ReadAllLines(this.key_file);
            this.privatekey = new PrivateKey(BigInteger.Parse(lines[0]), BigInteger.Parse(lines[2]));
        }
        public Decrypt(string filepath)
        {
            this.filepath = filepath;
            using (StreamReader reader = new StreamReader(filepath))
            {
                this.decrypt_filepath = reader.ReadLine();
                this.key_file = reader.ReadLine();
            }
            GetKey();
        }
        private string DecryptLine(string line)
        {
            string[] c_int_array = line.Split(' ');
            string[] m_int_array = new string[c_int_array.Length];
            for (int i = 0; i < c_int_array.Length; i++)
            {
                m_int_array[i] = string.Concat(BigInteger.ModPow(BigInteger.Parse(c_int_array[i]), this.privatekey.d, this.privatekey.n)).Substring(1);
            }
            string m_int = string.Concat(m_int_array);
            char[] m_char_array = new char[m_int.Length / 4];
            for (int i = 0; i < m_int.Length; i = i + 4)
            {
                if (i < m_int.Length - 4)
                {
                    m_char_array[i / 4] = (char)int.Parse(m_int.Substring(i, 4));
                }
                else
                {
                    //m_char_array[i / 4] = (char)int.Parse(m_int.Substring(i));
                }
                
            }
            return new string(m_char_array);
        }
        public void DecryptFile()
        {
            StreamWriter objWriter = new StreamWriter(decrypt_filepath);
            StreamReader objReader = new StreamReader(this.filepath);
            objReader.ReadLine();
            objReader.ReadLine();
            do
            {
                string c_line = DecryptLine(objReader.ReadLine());
                objWriter.WriteLine(c_line);
            } while (objReader.Peek() != -1);
            objReader.Close();
            objWriter.Close();
            File.Delete(this.filepath);
        }
    }
}
