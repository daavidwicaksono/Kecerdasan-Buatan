using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApplication
{
    class Program
    {
        static void cetakPapan(int[,] papan)
        {
            console.Clear();
            for (int i = 0; i <=7 ; i++{
                for (int j =0; j<=7; j++){
                    if(papan[i, j]<10){
                    Console.Write("0" + papan[i, j] + "j");}
                    else
                    {
                        Console.Write("[" + papan[i, j] + "j");}
                    }
                }
                Console.WriteLine();
            }
        }
        static int bolehJalan(int x, int y, int i, int[] xm, int[] ym, int[,] papan)
        {
            int x_next = x + xm[i];
            int y_next = y + ym[i];
            if (x_next>=0 && x_next<8 && y_next>=0 && y_next<8 && papan[x_next, y_next] ==0){
                //diantara x0-7, y0-7, dan papan [x,y]==0
                return 1;
            }
            else
            {
                //tidak boleh jalan
                return 0;
            }
        }
        static void delay(int n){
            for (int i = 0 )
        }
        static int cariSolosi(int x, int y, int lkh, int[]xm, int[]ym, int[,]papan){
            // langkah 4
            if lkh(==65)return 1;
            else
            {
                //kuda mempunyai 8 kemungkinan langkah 
                for (int i = 0 ; i <= 7 ; i++)
                {
                    int x_next = x + xm[i];
                    int y_next = y + ym[i];

                    // cek x_next dan y_next boleh jalan?

                    if(bolehJalan(x, y, i, xm, ym, papan)==1)
                    {
                        papan[x_next, y_next] = lkh;
                        cetakPapan(papan);
                        Console.ReadKey();

                      if (cariSolosi(x_next, y_next, lkh + 1, xm, ym, papan)==1){
                          return1;
                      }
                      else
                      {
                          papan[x_next, y_next] = 0;
                      }
                    }
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int [,] papan = new int [8, 8];
            for (int i = 0; i <=7 ; i++{
                for (int j =0; j<=7; j++){
                    papan[i, j] = 0;
                }
            }
            cetakPapan(papan);


            //2.
            int [] xm = {1, 2, 2, 1, -1, -2, -2, -1};
            int [] ym = {-2, -1, 1, 2, 2, 1, -1, -2};


            //langkah pertama
            papan[0, 0] = 1;
            cetakPapan(papan);
            //langkah kedua done

            //langkah ke 3
            if (cariSolosi(0,0,2,xm,ym,papan) == 0){
                Console.Write("Solusi Tidak Ditemukan")
            }
            else
            {
                cetakPapan(papan);
            }

            Console.ReadKey();
        }
    }
}