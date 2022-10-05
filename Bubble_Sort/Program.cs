using System;


namespace Bubble_Sort
{
    class Program
    {
        // Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];

        // Deklarasi variabel int umtuk menyimpan banyaknya data pada array
        private int n;

        // Fungsi / Method untuk menerima masukan
        public void read()
        {
            // Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
        }
        
    }
}
