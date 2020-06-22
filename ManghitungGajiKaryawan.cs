using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       Console.WriteLine("Nama\t : Umi Solihah");
       Console.WriteLine("NIM\t  : 19.11.2747");
       Console.WriteLine("Kelas\t: Informatika-03");
       
       KaryawanTetap karyawanTetap = new KaryawanTetap();
       karyawanTetap.NIK = "1111";
       karyawanTetap.Nama = "lola";
       karyawanTetap.GajiBulanan = 2000000;
       
       KaryawanHarian karyawanHarian = new KaryawanHarian();
       karyawanHarian.NIK = "2222";
       karyawanHarian.Nama = "loli";
       karyawanHarian.UpahPerJam = 150000;
       karyawanHarian.JumlahJamKerja = 8;
       
       Sales sales = new Sales();
       sales.NIK = "3333";
       sales.Nama = "lala";
       sales.JumlahPenjualan = 11;
       sales.Komisi = 110000;
       
       List<Karyawan> karyawan = new List<Karyawan>();
       
       karyawan.Add(karyawanTetap);
       karyawan.Add(karyawanHarian);
       karyawan.Add(sales);
       
       
       Console.WriteLine("========================================");
       Console.WriteLine(" NO | NIK / NAMA\t\t| Gaji\t\t |");
       Console.WriteLine("========================================");
       for ( int i = 0; i < karyawan.Count; i++) {
         
            Console.WriteLine(" {0}. | {1} {2} \t\t| {3} \t |", i+1, karyawan[i].NIK, karyawan[i].Nama, karyawan[i].Gaji());
       }
       
       Console.ReadKey();
     }
   }
   
   public abstract class Karyawan {
     public string NIK;
     public string Nama;
     public abstract double Gaji();
   }
   
   public class KaryawanTetap : Karyawan {
     public double GajiBulanan;
     public override double Gaji() {
       return this.GajiBulanan;
     }
   }
   
   public class KaryawanHarian : Karyawan {
     public double UpahPerJam;
     public double JumlahJamKerja;
     public override double Gaji() {
       return this.UpahPerJam * this.JumlahJamKerja;
     }
   }
   
   public class Sales : Karyawan {
     public double JumlahPenjualan;
     public double Komisi;
     public override double Gaji() {
       return this.JumlahPenjualan * this.Komisi;
     }
   }
 }