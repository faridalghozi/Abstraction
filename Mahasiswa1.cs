using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Encapsulation
{
    public class Mahasiswa
    {
        public string Nim { get; set; }
        public string Nama { get; set; }

        public void Registrasi()
        {
            Console.WriteLine("{0} Melakukan registrasi", Nama);
        }
    }
}
