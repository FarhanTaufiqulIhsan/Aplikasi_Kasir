using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Uas2
{
    /// <summary>
    /// Membuat namespace untuk projek
    /// </summary>
    /// <remarks> Aplikasi kasir ini berguna untuk menginput barang yang ingin dibeli oleh costumer, menampilkan harga dari masing-masing item,
    /// Menampilkan total harga dari seluruh item yang dibeli, serta mencetak nota hasil dari inputan.</remarks>
    public class Kasir
    {
        /// <summary>
        /// class untuk mengatur metode serta kelas dari program kasir cafe
        /// </summary>
        public void KasirCafe()
        {
            
            // untuk looping program jika ingin menginput lagi 
            for (; ; )
                //menampilkan menu utama program
                /// <example> Ketika di run akan menampilkan tulisan dari "selamat datang" samapai "Latte"</example>
            {
                Console.Clear();
                Console.WriteLine("   =================================================");
                Console.WriteLine("           Selamat Datang di Cafe de Jure           ");
                Console.WriteLine("                                                    ");
                Console.WriteLine("               The Best Cafe In Town                ");
                Console.WriteLine("   =================================================");
                Console.WriteLine("\n");
                Console.WriteLine("   =====================MENU========================");
                Console.WriteLine("\n");
                Console.WriteLine("   ====================MAKANAN======================");
                Console.WriteLine("");
                Console.WriteLine("Nasi Bakar           Rp 15000");
                Console.WriteLine("Nasi Goreng          Rp 15000");
                Console.WriteLine("Nasi Goreng spesial  Rp 20000");
                Console.WriteLine("Nasi Goreng Vegan    Rp 15000");
                Console.WriteLine("Mie Goreng           Rp 15000");
                Console.WriteLine("Mie Goreng Spesial   Rp 20000");
                Console.WriteLine("Mie Goreng Vegan     Rp 15000");
                Console.WriteLine("\n");
                Console.WriteLine("   ====================MINUMAN=======================");
                Console.WriteLine("Es Teh           Rp 3000");
                Console.WriteLine("Americano        Rp 15000");
                Console.WriteLine("Espresso         Rp 10000");
                Console.WriteLine("latte            Rp 15000");

                // menginput data nama kasir
                /// <example> ketika dijalankan, akan menampilkan tulisan "Masukkan nama kasir : " ketika nama sudah di input, maka nama kasir akan
                /// disimpan di variabel string namakasir.</example>
                Console.WriteLine("\n");
                Console.Write("Masukkan nama kasir : ");
                string namakasir = Console.ReadLine();
                Console.WriteLine();
                // menginput jumlah barang yang ingin dibeli
                /// <example> Jika kode dijalankan, maka akan menampilkan pesan "Masukkan jumlah barang yang ingin dibeli : "</example>
                /// <code> kode pada baris ke-68 akan menyimpan input dari jumlah barang yang ingin dibeli. Kemudian untuk baris ke-71 merupakan fungsi untuk
                /// membatasi input dari barang, input tidak boleh kurang dari sama dengan 0 dan tidak boleh lebih dari 1000, jika hal tersebut terjadi maka
                /// program akan mengulang.</code>
                int jumlahbarang;
                do
                {
                    Console.Write("Masukkan jumlah barang yang dibeli: ");
                    jumlahbarang = int.Parse(Console.ReadLine());

                } while (jumlahbarang <= 0 || jumlahbarang > 1000);

                // mendeklarasi masing masing variabel
                string[] namabarang = new string[jumlahbarang];
                int[] hargabarang = new int[jumlahbarang];
                int total = 0;
                int bayar, kembali;

                // menginput data nama pelanggan
                /// <example> ketika dijalankan, akan menampilkan pesan "Masukkan nama pelanggan: "</example>
                /// <code> kode pada string namapelanggan berfungsi untuk menyimpan nama pelanggan yang telah di input.</code>
                Console.WriteLine("\n");
                Console.WriteLine("==============================================");
                Console.Write("Masukkan nama pelanggan: ");
                string namapelanggan = Console.ReadLine();

                // menginput data nama barang serta harga barang
                /// <example> ketika kode dijalankan maka akan menampilkan pesan "masukkan barang ke -" dan pesan "Measukkan harga barnag ke- "</example>
                /// <code>Kode tersebut melakukan loop sebanyak "jumlahbarang" kali dan setiap kali loop dijalankan, program akan meminta user memasukkan nama
                /// dan harga barang. Namun, sebelum menyimpan nama dan harga tersebut, program akan memeriksa apakah panjang nama barang kurang dari atau sama dengan 0
                /// atau lebih besar dari 25 karakter. Jika panjang nama barang tidak memenuhi kriteria tersebut, program akan terus meminta user untuk memasukkan nama
                /// barang sampai memenuhi kriteria. Selain itu, program juga akan memeriksa apakah harga barang lebih kecil dari atau sama dengan 1000 atau lebih besar
                /// dari atau sama dengan 100000000. Jika harga barang tidak memenuhi kriteria tersebut, program akan terus meminta user untuk memasukkan harga barang
                /// sampai memenuhi kriteria.</code>
                for (int i = 0; i < jumlahbarang; i++)
                {
                    do
                    {
                        Console.WriteLine("==========================================");
                        Console.Write("Masukkan barang ke -" + (i + 1) + ": ");
                        namabarang[i] = Console.ReadLine();

                    } while (namabarang[i].Length <= 0 || namabarang[i].Length > 25);

                    do
                    {
                        Console.Write("Masukkan harga barang ke -" + (i + 1) + ": ");
                        hargabarang[i] = int.Parse(Console.ReadLine());

                    } while (hargabarang[i] <= 1000 || hargabarang[i] >= 100000000);

                }

                //menampilkan hasil dari barang yang telah di input serta menampilkan total harga barang
                /// <example> ketika dijalankan akan menampilkan pesan "barang yang dipilih", serta "total : RP" </example>
                /// <code> Untuk setiap barang yang telah dimasukkan sebelumnya, baris kode for digunakan untuk menampilkan nama barang dan harganya. 
                /// Setiap item barang dan harganya ditampilkan dalam satu baris menggunakan operator + untuk menggabungkan tiga nilai yaitu nomor urutan 
                /// barang, nama barang, dan harganya. Setelah itu, baris kode foreach digunakan untuk menghitung total harga dari semua barang yang telah 
                /// dipilih. Variabel total akan bertambah sesuai dengan nilai dari setiap hargabarang[i].Terakhir, baris kode 
                /// Console.WriteLine("Total : Rp" + total); digunakan untuk menampilkan jumlah total harga barang yang telah dipilih dalam format Rupiah.</code>
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("============================");
                Console.WriteLine("Barang yang dipilih");
                Console.WriteLine("============================");
                for (int i = 0; i < jumlahbarang; i++)
                {
                    Console.WriteLine((i + 1) + ". " + namabarang[i] + " " + hargabarang[i]);

                }
                foreach (int i in hargabarang)
                {
                    total += i;
                }

                Console.WriteLine("---------------------------");
                Console.WriteLine("Total : Rp" + total);

                // untuk menginput uang yang diberi oleh pelanggan untuk membayar
                /// <example> ketika dijalankan, akan menampilkan pesan "Tunai : Rp", dan jika uang yang diberikan tidak cukup akan menampilkan pesan
                /// "Ga cukup gan!", dan ketika ada kembalian akan memunculkan pesan "Kembali : Rp"</example>
                /// <code>pengguna diminta untuk memasukkan jumlah uang yang dibayarkan dengan menggunakan perulangan do-while. 
                /// Selama jumlah uang yang dibayarkan masih kurang dari total harga belanjaan (variable total), maka program akan terus meminta
                /// pengguna untuk memasukkan jumlah uang yang cukup hingga jumlah uang yang dibayarkan sudah sama atau lebih besar dari total harga
                /// belanjaan.Jika jumlah uang yang dibayarkan kurang dari total harga belanjaan, maka program akan menampilkan pesan "Ga cukup gan!". 
                /// Sedangkan jika uang yang dibayarkan cukup atau lebih dari total harga belanjaan, maka program akan menampilkan pesan "Kembali: Rp" 
                /// yang diikuti dengan jumlah kembalian yang harus diberikan kepada pengguna.
                /// (dihitung dari selisih antara uang yang dibayarkan dan total harga belanjaan).</code>
                do
                {
                    Console.Write("Tunai : Rp");
                    bayar = int.Parse(Console.ReadLine());

                    kembali = bayar - total;

                    // memberi pesan bahwa uang yang di bayar tidak cukup
                    if (bayar < total)
                    {
                        Console.WriteLine("Ga cukup gan!");

                    }

                    // memberi pesan jika ada kembalian dari uang yang telah dibayar
                    else
                    {
                        Console.WriteLine("Kembali: Rp" + kembali);

                    }
                } while (bayar < total);

                // mencetak tampilan dari hasil seluruh pembelian 
                /// <example> akan menampilkan "nama pembeli: " , "tanggal transaksi", "pukul", serta pesan "Terima kasih"</example>
                Console.WriteLine("\n");
                Console.WriteLine("Nama pembeli: {0}", namapelanggan.ToString());
                Console.WriteLine("\n");

                Console.WriteLine("Tanggal Transaksi : " + DateTime.Today.ToString("yyyy-MM-dd"));
                Console.WriteLine("Pukul : " + DateTime.Now.ToString("HH:mm:ss"));
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("                TERIMA KASIH                ");
                Console.WriteLine("--------------------------------------------");

                // mencetak nota pembelian dan menyipannya di directory yang telah ditentukan
                /// <example> akan menampilkan "tanggal transasksi", "pukul", "kasir" , "pembeli", pesan selamat datang, "item yang dibeli", "total harga",
                /// "Tunai", "kembali" , dan pesan "terima kasih" serta "nota berhasil dicetak"</example>
                using (StreamWriter sw = new StreamWriter(@"C:\Users\Farhan\Documents\Kuliah\Sem 2\PAW\Data Kasir\Nota.txt"))
                {
                    sw.WriteLine("   Tanggal Transaksi : " + DateTime.Today.ToString("yyyy-MM-dd"));
                    sw.WriteLine("   Pukul             : " + DateTime.Now.ToString("HH:mm:ss"));
                    sw.WriteLine("   Kasir             : " + namakasir);
                    sw.WriteLine("   Pembeli           : " + namapelanggan);
                    sw.WriteLine("   =================================================");
                    sw.WriteLine("           Selamat Datang di Cafe de Jure           ");
                    sw.WriteLine("                                                    ");
                    sw.WriteLine("               The Best Cafe In Town                ");
                    sw.WriteLine("   =================================================");
                    sw.WriteLine("\n");
                    sw.WriteLine("   Item yang dibeli : ");
                    for (int i = 0; i < jumlahbarang; i++)
                    {
                               sw.WriteLine((i + 1) + ". " + namabarang[i] + " " + hargabarang[i]);

                    }
                    sw.WriteLine("   ==================================================");
                    sw.WriteLine("                      Total   : Rp" + total);
                    sw.WriteLine("                      Tunai   : Rp" + bayar);
                    sw.WriteLine("                      Kembali : Rp" + kembali);
                    sw.WriteLine("\n\n");
                    sw.WriteLine("   ---------------------------------------------------");
                    sw.WriteLine("                     TERIMA KASIH                     ");
                    sw.WriteLine("   ---------------------------------------------------");
                    sw.WriteLine("\n");
                    Console.WriteLine("            Nota berhasil dicetak                ");

                }
                // menampilkan pesan pilihan untuk user apakah ingin kembali ke menu awal atau tidak
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("Apakah anda ingin kembali ke menu awal ? (Y/N)");
                string jawaban = Console.ReadLine();

                // jika jawaban user = n, maka program akan berhenti
                if (jawaban.ToLower() == "N" || jawaban.ToLower() == "n")
                {
                    break;
                }
            }
        }

        class program
        {
            /// <summary>
            /// kelas utama untuk menjalankan kelas kasir
            /// </summary>
            /// <param name="args"></param>
            static void Main(string[] args)
            {
                Kasir KasirCafe = new Kasir();
                KasirCafe.KasirCafe();
            }
        }
    }
}