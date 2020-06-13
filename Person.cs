using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Inheritance
{
    public class person
    {
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string Nohp { get; set; }
        public string Email { get; set; }
        public string Nik { get; set; }

        public void CetakInformasi()
        {
            Console.WriteLine("Nama:{0}", Nama);
        }
    }
}
