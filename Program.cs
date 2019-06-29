using System;


namespace test
{

    class Program
    {
       
        static void Main(string[] args)
        {

            int Ui_pi = 20, Ui_mi = 4, Ui_oi = 2, Ui_q = 20; 
            int Act_pi = 32, Act_mi = 8, Act_oi = 4, Act_q = 60;  
            int Obj_pi = 8, Obj_mi = 3, Obj_oi = 2, Obj_q = 16; 
            int Metd_pi = 26, Metd_mi = 6, Metd_oi = 2, Metd_q = 40;

        
            //int cnt_f2 = 0;
            //MyClass c1 = new MyClass();
     
            formula_1(Ui_pi, Ui_mi, Ui_oi, 20);
            formula_1(Act_pi, Act_mi, Act_oi, 60);
            formula_1(Obj_pi, Obj_mi, Obj_oi, 16);
            formula_1(Metd_pi, Metd_mi, Metd_oi, 40);

            

            formula_2(Ui_pi, Ui_mi, Ui_oi, 20);
            formula_2(Act_pi, Act_mi, Act_oi, 60);
            formula_2(Obj_pi, Obj_mi, Obj_oi, 16);
            formula_2(Metd_pi, Metd_mi, Metd_oi, 40);

            //----------------------------------------

            formula_3();
            formula_4();
            formula_5();
            formula_6();
            formula_7();
            formula_8();
            formula_9();
            formula_10();
        }



      static float []sum_E = new float[4]; 
      static float []sum_SCO = new float[4]; 
      static int cnt_f1 = 0, cnt_f2 = 0, cnt_f5 = 0; 
      static float CKO_k = 0, summa_E = 0, E_95 = 0, E_all = 0, N = 0, T = 0 ;

      static  void formula_1(int pi, int mi, int oi, int q){

        float E = (float)(pi + 4*mi+ oi)/6;

        if( sum_E.Length < 5){

        sum_E[cnt_f1++] = E*q;

        }else cnt_f1 = 0;

        Console.WriteLine("Оценка средней трудоемкости  E =  " + E.ToString("0.00"));

      }




      static  void formula_2(int pi, int mi, int oi, int q){

        float CKO = (float)(pi - oi)/6;

        if(sum_SCO.Length < 5){

        sum_SCO[cnt_f2++] = CKO *q;

        }else cnt_f2 = 0;

        Console.WriteLine("Среднеквадратичное отклонение СКО=  " + CKO.ToString("0.00"));

      }


         static  void formula_3(){


       
        
        for(int i = 0; i< 4; i++){
          
          summa_E  += sum_E[i];

          //Console.WriteLine("= " + sum_E[i].ToString("0.00") );

        }
        
       

        Console.WriteLine("Суммарная трудоемкость кодирования E =  " + summa_E.ToString("0.00") );

      }






static  void formula_4(){


        float sCKO = 0; 
        
        for(int i = 0; i< 4; i++){
          
          sCKO += (float)Math.Pow(sum_SCO[i], 2);

          //Console.WriteLine("= " + sum_E[i].ToString("0.00") );

        }
        
            CKO_k = (float)Math.Pow(sCKO, 0.5);
       

        Console.WriteLine("Среднеквадратичное отклонение для оценки суммарной трудоемкости кодирования CKO_k =  " + CKO_k.ToString("0.00") );

      }



static  void formula_5(){


        E_95 = summa_E  + 2*CKO_k;


        Console.WriteLine("Оценка суммарной трудоемкости кодирования summa E_95 =  " + E_95.ToString("0.00") );

      }


static  void formula_6(){

     
          float delta = (CKO_k /summa_E)*100;
       
           Console.WriteLine("Относительная погрешность в оценке суммарной трудоемкости кодирования delta =  " + delta.ToString("0.00") + "%" );

        }


static  void formula_7(){

     
           E_all = E_95*4;
       
           Console.WriteLine("Общая трудоемкость проекта delta =  " + E_all.ToString("0.00") );

        }


static  void formula_8(){

     
           N = E_all/132;
       
           Console.WriteLine("Пересчет в человеко-месяцы N =  " + N.ToString("0.00") );

        }


static  void formula_9(){
     
           T =  (float)Math.Pow(N*2.5, (float)(1)/3);

           Console.WriteLine("Оптимальная продолжительность проекта; T =  " + T.ToString("0.00") );

        }

static  void formula_10(){
     
           float K =  N/T;

           Console.WriteLine("Средняя численность команды; K =  " + K.ToString("0.00") );

        }




    }
}
