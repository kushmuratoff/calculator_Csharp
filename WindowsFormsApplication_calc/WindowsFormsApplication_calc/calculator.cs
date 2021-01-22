using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_calc
{
    class calculator
    {
        private string sonn = "",labelekaranga="";
        private string amal = "", amal1 = "", kup_a = "", bul_a = "", qush_a = "", amal2 = "";
        private double a = 0, b = 0,son1=0,son2=0,son3=0,son4=0,son5=0;
        private string vaqtincha = "";
       public void sonlar(string belgi)
        {
           switch(amal)
           {
               case "+": qushish(); break;
               case "-": ayrish(); break;
               case "*": kupaytirtish(); break;
               case "/": bulish(); break;

           }
           switch(belgi)
           {
               case "1": sonn += 1; labelekaranga += "1"; break;
               case "2": sonn += 2; labelekaranga += "2"; break;
               case "3": sonn += 3; labelekaranga += "3"; break;
               case "4": sonn += 4; labelekaranga += "4"; break;
               case "5": sonn += 5; labelekaranga += "5"; break;
               case "6": sonn += 6; labelekaranga += "6"; break;
               case "7": sonn += 7; labelekaranga += "7"; break;
               case "8": sonn += 8; labelekaranga += "8"; break;
               case "9": sonn += 9; labelekaranga += "9"; break;
               case "0": sonn += "0"; labelekaranga += "0"; break;
               case ",": sonn += ","; labelekaranga += ","; break;
           }

          // MessageBox.Show(sonn);
        }
        public void text_b(TextBox tb,TextBox tb1)
       {
           tb.Text = sonn;
           tb1.Text = labelekaranga;
       }
        public void natija_teng()
        {
           // sonlar(amal1);
           // MessageBox.Show(amal2);
           // amal = amal1;
            switch (amal2)
            {
                case "+": { qushish(); labelekaranga = son1.ToString(); sonn = son1.ToString(); } break;
                case "-": { ayrish(); labelekaranga = son1.ToString();  sonn = son1.ToString(); } break;
                case "*": { kupaytirtish(); labelekaranga = son2.ToString(); sonn = son2.ToString(); } break;

                case "/": { bulish(); labelekaranga = son4.ToString();  sonn = son4.ToString(); } break;


            }
           // MessageBox.Show(a.ToString());
          // labelekaranga = a.ToString();
            amal2 = "";
           // amal = "";
           // sonn = a.ToString();

        }
        public void amal_q()
        {
            amal = "+";
            kup_marta_bosish();
           
           labelekaranga += "+";
            
        }
        public void amal_a()
        {

            amal = "-";
            kup_marta_bosish();

            labelekaranga += "-";

        }
        public void amal_k()
        {
            amal = "*";
            kup_marta_bosish();

            labelekaranga += "*";
        }
        public void amal_b()
        {
           
            amal = "/";
            kup_marta_bosish();

            labelekaranga += "/";
        }
        public void kup_marta_bosish()
        {
            string amalga = labelekaranga.Substring(labelekaranga.Length - 1, 1);
            //MessageBox.Show(amalga);
            if (amalga == "+" || amalga == "-" || amalga == "*" || amalga == "/")
            {
                string almash = labelekaranga.Substring(0, labelekaranga.Length - 1);
                labelekaranga = almash;

            }
        }
        public void ortga()
        {
            string amalga = labelekaranga.Substring(labelekaranga.Length - 1, 1);
            //MessageBox.Show(amalga);
            if ((amalga == "+" || amalga == "-" || amalga == "*" || amalga == "/"))
            {

            }
            else
            {
                labelekaranga = labelekaranga.Substring(0, labelekaranga.Length - 1);
                sonn = sonn.Substring(0, sonn.Length - 1);


            }
        }
        public void ce_btn()
        {
            for (int i = 0; i < labelekaranga.Length; i++)
            {
                if (labelekaranga.Substring(i, 1) == "+" || labelekaranga.Substring(i, 1) == "-" || labelekaranga.Substring(i, 1) == "*" || labelekaranga.Substring(i, 1) == "/")
                {
                  //  MessageBox.Show(labelekaranga.Substring(i, 1),"jhg");
                    string almash = labelekaranga.Substring(0,i+1);
                    labelekaranga = almash;
                   amal1 = labelekaranga.Substring(i, 1); 
                    amal = "";
                   // amal1 = "1";
                    sonn = "";
                    break;

                }
            }
        }
        public void c_btn()
        {
            amal1 = "";
            amal = "";
            sonn = "";
            labelekaranga = "";
            a = 0; b = 0;
              sonn = "";labelekaranga="";
        amal = ""; amal1 = "";kup_a= "";bul_a= "";qush_a= "";amal2="";
        a = 0; b = 0; son1 = 0; son2 = 0; son3 = 0; son4 = 0; son5 = 0;
         vaqtincha = "";
        }
        public void ishora_btn()
        {
            bool kirgan = false;
            double q = Convert.ToDouble(sonn);

            for (int i = 1; i < labelekaranga.Length; i++)
            {
                if (labelekaranga.Substring(i, 1) == "+" || labelekaranga.Substring(i, 1) == "-" || labelekaranga.Substring(i, 1) == "*" || labelekaranga.Substring(i, 1) == "/")
                {
                    //  MessageBox.Show(labelekaranga.Substring(i, 1),"jhg");
                    labelekaranga = labelekaranga.Substring(0, i + 1);
                    if (q > 0)
                    {
                        labelekaranga += "(-" + q.ToString() + ")";
                        q = q * (-1);

                    }
                    else
                    {
                        q = q * (-1);
                        labelekaranga += q.ToString();
                    }
                    kirgan = true;
                    sonn = q.ToString();
                    break;

                }
            }
            if(!kirgan)
            {
                q = q * (-1);
                labelekaranga = q.ToString();
                sonn = q.ToString();
            }

        }
        public void butun_btn()
        {
            bool kirgan = false;
            double q = Convert.ToDouble(sonn);

            for (int i = 1; i < labelekaranga.Length; i++)
            {
                if (labelekaranga.Substring(i, 1) == "+" || labelekaranga.Substring(i, 1) == "-" || labelekaranga.Substring(i, 1) == "*" || labelekaranga.Substring(i, 1) == "/")
                {
                    //  MessageBox.Show(labelekaranga.Substring(i, 1),"jhg");
                    labelekaranga = labelekaranga.Substring(0, i + 1);
                    
                        q = 1/q;
                        labelekaranga += q.ToString();
                   
                    kirgan = true;
                    sonn = q.ToString();
                    break;

                }
            }
            if (!kirgan)
            {
                q = 1/q;
                labelekaranga = q.ToString();
                sonn = q.ToString();
            }

        }
        public void ildiz_btn()
        {
            bool kirgan = false;
            double q = Convert.ToDouble(sonn);

            for (int i = 1; i < labelekaranga.Length; i++)
            {
                if (labelekaranga.Substring(i, 1) == "+" || labelekaranga.Substring(i, 1) == "-" || labelekaranga.Substring(i, 1) == "*" || labelekaranga.Substring(i, 1) == "/")
                {
                    //  MessageBox.Show(labelekaranga.Substring(i, 1),"jhg");
                    labelekaranga = labelekaranga.Substring(0, i + 1);
                   
                        q = Math.Sqrt(q);
                        labelekaranga += q.ToString();
                   
                    kirgan = true;
                    sonn = q.ToString();
                    break;

                }
            }
            if (!kirgan)
            {
                q = Math.Sqrt(q);
                labelekaranga = q.ToString();
                sonn = q.ToString();
            }

        }
        public void fak_btn()
        {
            bool kirgan = false;
            double q = Convert.ToDouble(sonn);

            for (int i = 1; i < labelekaranga.Length; i++)
            {
                if (labelekaranga.Substring(i, 1) == "+" || labelekaranga.Substring(i, 1) == "-" || labelekaranga.Substring(i, 1) == "*" || labelekaranga.Substring(i, 1) == "/")
                {
                    //  MessageBox.Show(labelekaranga.Substring(i, 1),"jhg");
                    labelekaranga = labelekaranga.Substring(0, i + 1);
                    double fakk = 1;
                    for (int f = 1; f <= q;f++ )
                    {
                        fakk *= f;
                    }
                    q = fakk;
                    labelekaranga += q.ToString();

                    kirgan = true;
                    sonn = q.ToString();
                    break;

                }
            }
            if (!kirgan)
            {
                double fakk = 1;
                for (int f = 1; f <= q; f++)
                {
                    fakk *= f;
                }
                q = fakk;
                labelekaranga = q.ToString();
                sonn = q.ToString();
            }

        }
        public void sin_btn()
        {
            bool kirgan = false;
            double q = Convert.ToDouble(sonn);

            for (int i = 1; i < labelekaranga.Length; i++)
            {
                if (labelekaranga.Substring(i, 1) == "+" || labelekaranga.Substring(i, 1) == "-" || labelekaranga.Substring(i, 1) == "*" || labelekaranga.Substring(i, 1) == "/")
                {
                    //  MessageBox.Show(labelekaranga.Substring(i, 1),"jhg");
                    labelekaranga = labelekaranga.Substring(0, i + 1);

                    q = Math.Sin(q);
                    labelekaranga += q.ToString();

                    kirgan = true;
                    sonn = q.ToString();
                    break;

                }
            }
            if (!kirgan)
            {
                q = Math.Sin(q);
                labelekaranga = q.ToString();
                sonn = q.ToString();
            }

        }
        public void cos_btn()
        {
            bool kirgan = false;
            double q = Convert.ToDouble(sonn);

            for (int i = 1; i < labelekaranga.Length; i++)
            {
                if (labelekaranga.Substring(i, 1) == "+" || labelekaranga.Substring(i, 1) == "-" || labelekaranga.Substring(i, 1) == "*" || labelekaranga.Substring(i, 1) == "/")
                {
                    //  MessageBox.Show(labelekaranga.Substring(i, 1),"jhg");
                    labelekaranga = labelekaranga.Substring(0, i + 1);

                    q = Math.Cos(q);
                    labelekaranga += q.ToString();

                    kirgan = true;
                    sonn = q.ToString();
                    break;

                }
            }
            if (!kirgan)
            {
                q = Math.Cos(q);
                labelekaranga = q.ToString();
                sonn = q.ToString();
            }

        }
        public void tan_btn()
        {
            bool kirgan = false;
            double q = Convert.ToDouble(sonn);

            for (int i = 1; i < labelekaranga.Length; i++)
            {
                if (labelekaranga.Substring(i, 1) == "+" || labelekaranga.Substring(i, 1) == "-" || labelekaranga.Substring(i, 1) == "*" || labelekaranga.Substring(i, 1) == "/")
                {
                    //  MessageBox.Show(labelekaranga.Substring(i, 1),"jhg");
                    labelekaranga = labelekaranga.Substring(0, i + 1);

                    q = Math.Tan(q);
                    labelekaranga += q.ToString();

                    kirgan = true;
                    sonn = q.ToString();
                    break;

                }
            }
            if (!kirgan)
            {
                q = Math.Tan(q);
                labelekaranga = q.ToString();
                sonn = q.ToString();
            }

        }
        public void ten_btn()
        {

            bool kirgan = false;
            double q = Convert.ToDouble(sonn);

            for (int i = 1; i < labelekaranga.Length; i++)
            {
                if (labelekaranga.Substring(i, 1) == "+" || labelekaranga.Substring(i, 1) == "-" || labelekaranga.Substring(i, 1) == "*" || labelekaranga.Substring(i, 1) == "/")
                {
                    //  MessageBox.Show(labelekaranga.Substring(i, 1),"jhg");
                    labelekaranga = labelekaranga.Substring(0, i + 1);

                    q = Math.Pow(10,q);
                    labelekaranga += q.ToString();

                    kirgan = true;
                    sonn = q.ToString();
                    break;

                }
            }
            if (!kirgan)
            {
                q = Math.Pow(10, q);
                labelekaranga = q.ToString();
                sonn = q.ToString();
            }

        }
   public void qushish()
        {

    b = Convert.ToDouble(sonn);

    if (qush_a == "") {
        if (kup_a == "*") {
            son2 *= b;
            son1 = son2-son1;

        }
        else if (bul_a == "/") {
            son4 /= b;
            son1 = son4-son1;

        }
        else {
            son1 = b;
        }
       
    }
    if (amal2 == "*") {
        son3 = b;
        son2 *= son3;
        if (qush_a == "+")
        { son1 += son2; }
        else if (qush_a == "-") {
            son1 -= son2;
        }
        kup_a = "";
    }
    else if (amal2 == "/") {
        son5 = b;
        son4 /= son5;
        if (qush_a == "+")
        { son1 += son4; }
        else if (qush_a == "-") {
            son1 -= son4;
        }
        bul_a = "";
    }
    else if (amal2 == "+") {
        son1 += b;
    }
    else if (amal2 == "-") {
        son1 -= b;
    }
    amal2 = "+";
    qush_a = "+";
    
    amal = "";
    sonn = "";
    vaqtincha = son1.ToString() + amal2;
    labelekaranga = vaqtincha;
        }
   public void ayrish()

{

    b= Convert.ToDouble(sonn);
    if (qush_a == "") {
        if (kup_a == "*") {
            son2 *= b;
            son1 = son2-son1;

        }
        else if (bul_a == "/") {
            son4 /= b;
            son1 = son4-son1;
        }
        else {
            son1 = b;
        }
       
    }
    if (amal2 =="*" ) {
        son3 = b;
        son2 *= son3;
        if (qush_a == "+")
        { son1 += son2; }
        else if (qush_a=="-") {
            son1 -= son2;
        }
        kup_a = "";
    }
    else if (bul_a == "/") {
        son5 = b;
        son4 /= son5;
        if (qush_a == "+")
        { son1 += son4; }
        else if (qush_a == "-") {
            son1 -= son4;
        }
        bul_a = "";
    }
    else if (amal2 == "+") {
        son1 += b;
    }
    else if (qush_a == "-") {
        son1 -= b;
    }
    
    qush_a = "-";
    amal2 = "-";
    amal = "";
    sonn = "";
    vaqtincha = son1.ToString() + amal2;
    labelekaranga = vaqtincha;

}
   public void kupaytirtish()
   {
       b = Convert.ToDouble(sonn);

           if (kup_a == "")
           {
               if (bul_a == "/")
               {
                   son4 /= b;
                   son2 = son4;
                   bul_a = "";
               }
               else
               {
                   son2 = b;
               }
           }
           else
           {
               son3 = b;
           }
           kup_a = "*";
           if (amal2 == "*")
           {
               son2 = son3 * son2;
           
           }
           amal2 = "*";
           amal = "";
           sonn = "";
           vaqtincha = son2.ToString() + kup_a;
           bool kirgan = false;
           for (int i = 1; i < labelekaranga.Length;i++ )
           {
               if (labelekaranga.Substring(i, 1) == "+" || labelekaranga.Substring(i, 1) == "-")
               {
                   labelekaranga = labelekaranga.Substring(0, i + 1); kirgan = true; break;
               }
           }
           if (kirgan)
           {
               labelekaranga += vaqtincha;
           }
           else { labelekaranga = vaqtincha; }
         
   }
   public void bulish()
   {
       b = Convert.ToDouble(sonn);
           if (bul_a == "")
           {

               if (kup_a == "*")
               {
                   son2 *= b;
                   son4 = son2;
                   kup_a = "";
               }
               else
               {
                   son4 = b;
               }
           }
           else
           {
               son5 = b;
           }
           bul_a = "/";
           if (amal2 == "/")
           {
               son4 = son4 / son5;
           }
           amal2 = "/";
           amal = "";
           sonn = "";
           vaqtincha = son4.ToString() + bul_a;
           bool kirgan = false;
           for (int i = 1; i < labelekaranga.Length; i++)
           {
               if (labelekaranga.Substring(i, 1) == "+" || labelekaranga.Substring(i, 1) == "-")
               {
                   labelekaranga = labelekaranga.Substring(0, i + 1); kirgan = true; break;
               }
           }
           if (kirgan)
           {
               labelekaranga += vaqtincha;
           }
           else { labelekaranga = vaqtincha; }
      }
               
    }
}
