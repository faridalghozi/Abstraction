using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.Nim = "19.11.2824";
            mhs.Nama = "Muhammad Farid Alghozi";
            mhs.Registrasi();

            Console.ReadKey();
        }
    }
}
