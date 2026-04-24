using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_2026_3_10_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Milos Pusic
            /* tacka a = new tacka(-1, -1);
            Console.WriteLine(a.ugao());
            Console.WriteLine(a.d());
            tacka A = new tacka(3, 1);
            tacka B = new tacka(-1, 3);
            tacka C = new tacka(3, 3);
            vektor OA = new vektor(A);
            vektor OB = new vektor(B);
            vektor AC = new vektor(A, C);
            Console.WriteLine(vektor.SP(OA, OB));
            Console.WriteLine(vektor.VP(OA, AC));
            */
            /*
            tacka A = new tacka(1, 2);
            tacka B = new tacka(3, 2);
            tacka C = new tacka(2, 3);
            tacka D = new tacka(2, 2);
            vektor AB = new vektor(A, B);
            Console.WriteLine(ravan.SIS(AB, C, D));
            Console.WriteLine("Koliko temena?");
            int n=Convert.ToInt32(Console.ReadLine());
            poligon prvi = new poligon(n);
            */
            // prvi.unos();
            // prvi.stampaj();
            // prvi.snimi();
            /* poligon jovan = new poligon(4);
            jovan.unos();
            jovan.snimi();
            jovan.stampaj();
            double obim = jovan.obim();
            Console.WriteLine("Obim="+obim.ToString());
            */
            
            // poligon jovan = poligon.ucitaj();
            
            // jovan.snimi();
            // jovan.stampaj();
            // Console.WriteLine(jovan.prost());            
            // poligon jovan = poligon.ucitaj();
            // Console.WriteLine(jovan.prost());            
            
            
            poligon prvi = new poligon(5);
            tacka a = new tacka(1, 1);
            tacka b = new tacka(3, 1);
            tacka c = new tacka(3, 3);
            tacka d = new tacka(2, 4);
            tacka e = new tacka(1, 3);
            prvi.teme[0] = a;
            prvi.teme[1] = b;
            prvi.teme[2] = c;
            prvi.teme[3] = d;
            prvi.teme[4] = e;
            Console.WriteLine(prvi.konveksan());
        }
    }
}
