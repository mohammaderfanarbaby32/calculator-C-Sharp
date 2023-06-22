using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        double a = 0; //a ورودی اول کاربر   
        double b = 0; //b ورودی دوم کاربر
        double c = 0; //c جواب محاسبه 
        String Q1 = "";//Q1 برای فهمیدن اینکه کاربر بیشتر از دو عدد وارد کرده یا نه
        String Q = "";//Q برای فهمیدن علامتی که کاربر وارد میکنه 
        String F = "";//F برای دیلیت کردن آخرین حرف رشته
        int C = 0;    //C برای ریست کردن ماشین حساب
        int Z = 0;    //Z برای اینکه یک دفعه 0 پشته عدد پاک بشه
        int W = 0;    //W برای اینکه بیشتر از 1 دفعه اعشار نوشته نشود
        int G = 0;
        int S=0;  
        String Q2="";
        public Form1()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData) {
              
                case Keys.D1:
                    
                    Z++;
                    if (Z == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F;
                    }

                    if (G == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F; G = 0;
                    }

                    S = 1;
            label1.Text += S;
            a = double.Parse(label1.Text);


                    break;
                    
               case Keys.D2:

                    Z++;
                    if (Z == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F;
                    }

                    if (G == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F; G = 0;
                    }

                    S =2;
                    label1.Text += S;
                    a = double.Parse(label1.Text);

                    break;

                    case Keys.D3:
                    Z++;
                    if (Z == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F;
                    }

                    if (G == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F; G = 0;
                    }

                    S = 3;
                    label1.Text += S;
                    a = double.Parse(label1.Text);
                    break;


                case Keys.D4:

                    Z++;
                    if (Z == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F;
                    }

                    if (G == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F; G = 0;
                    }

                    S = 4;
                    label1.Text += S;
                    a = double.Parse(label1.Text);


                    break;

                case Keys.D5:

                    Z++;
                    if (Z == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F;
                    }

                    if (G == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F; G = 0;
                    }

                    S = 5;
                    label1.Text += S;
                    a = double.Parse(label1.Text);

                    break;

                case Keys.D6:
                    Z++;
                    if (Z == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F;
                    }

                    if (G == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F; G = 0;
                    }

                    S = 6;
                    label1.Text += S;
                    a = double.Parse(label1.Text);
                    break;


                case Keys.D7:

                    Z++;
                    if (Z == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F;
                    }

                    if (G == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F; G = 0;
                    }

                    S =7;
                    label1.Text += S;
                    a = double.Parse(label1.Text);


                    break;

                case Keys.D8:

                    Z++;
                    if (Z == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F;
                    }

                    if (G == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F; G = 0;
                    }

                    S = 8;
                    label1.Text += S;
                    a = double.Parse(label1.Text);

                    break;

                case Keys.D9:
                    Z++;
                    if (Z == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F;
                    }

                    if (G == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F; G = 0;
                    }

                    S = 9;
                    label1.Text += S;
                    a = double.Parse(label1.Text);
                    break;


                case Keys.D0:

                    Z++;
                    if (Z == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F;
                    }

                    if (G == 1)
                    {
                        F = label1.Text;
                        F = F.Substring(0, F.Length - 1);
                        label1.Text = F; G = 0;
                    }

                    S = 0;
                    label1.Text += S;
                    a = double.Parse(label1.Text);


                    break;


                case Keys.Subtract:
                    G = 0;
                    W = 0;

                    mohammad();

                    Z = 0;
                    if (Q1 == "")
                    {
                        b = a; a = 0;
                        Q1 = "14";
                        if (Q == "*" | Q == "+" | Q == "/")
                        {
                            a = double.Parse(label1.Text);
                            Q = "";
                        }
                        Q += "-";

                        label2.Text = label1.Text + " - ";

                        label1.Text = "0";
                    }
                    else if (Q1 == "14" && label1.Text == "")
                    {

                        Q1 = "14";
                        if (Q == "-" | Q == "+" | Q == "/")
                        {
                            a = double.Parse(label1.Text);
                            Q = ""; label1.Text = "";
                        }
                    }

                    else if (Q1 == "14" && b != 0 && a != 0)
                    {


                        c = a * b; label1.Text = c + "";
                        label2.Text = b + " * " + a + " = " + c;
                        Q = "";
                        label1.Text = c + "";
                        Q1 = "";
                        b = c;
                        a = 0;


                        Q1 = "14";
                        if (Q == "*" | Q == "+" | Q == "/")
                        {
                            a = double.Parse(label1.Text);
                            Q = "";
                        }
                        Q += "*";

                        label2.Text = label1.Text + " * ";

                        label1.Text = "0";


                    }
                    break;



                case Keys.Multiply:




                    G = 0;
                    W = 0;
                    mohammad();
                    Z = 0;


                    if (Q1 == "")
                    {
                        b = a; a = 0;
                        Q1 = "12";
                        if (Q == "-" | Q == "+" | Q == "/")
                        {
                            a = double.Parse(label1.Text);
                            Q = "";
                        }
                        Q += "*";

                        label2.Text = label1.Text + " * ";

                        label1.Text = "0";
                    }
                    else if (Q1 == "12" && label1.Text == "")
                    {

                        Q1 = "12";
                        if (Q == "-" | Q == "+" | Q == "/")
                        {
                            a = double.Parse(label1.Text);
                            Q = ""; label1.Text = "";
                        }
                    }

                    else if (Q1 == "12" && b != 0 && a != 0)
                    {


                        c = a * b; label1.Text = c + "";
                        label2.Text = b + " * " + a + " = " + c;
                        Q = "";
                        label1.Text = c + "";
                        Q1 = "";
                        b = c;
                        a = 0;


                        Q1 = "12";
                        if (Q == "-" | Q == "+" | Q == "/")
                        {
                            a = double.Parse(label1.Text);
                            Q = "";
                        }
                        Q += "*";

                        label2.Text = label1.Text + " * ";

                        label1.Text = "0";


                    }




                    break;


                case Keys.Divide:



                    W = 0;
                    mohammad();
                    Z = 0;

                    if (Q1 == "")
                    {
                        b = a; a = 0;
                        Q1 = "13";
                        if (Q == "-" | Q == "+" | Q == "*")
                        {
                            a = double.Parse(label1.Text);
                            Q = "";
                        }
                        Q += "/";

                        label2.Text = label1.Text + " / ";

                        label1.Text = "0";
                    }

                    else if (Q1 == "13" && b != 0 && a != 0)
                    {


                        c = b / a; if (a == b) { c = 1; }
                        label1.Text = c + "";
                        label2.Text = b + " / " + a + " = " + c;
                        Q = "";
                        label1.Text = c + "";
                        Q1 = "";
                        b = c;
                        a = 0;


                        Q1 = "13";
                        if (Q == "-" | Q == "+" | Q == "*")
                        {
                            a = double.Parse(label1.Text);
                            Q = "";
                        }
                        Q += "/";

                        label2.Text = label1.Text + " / ";

                        label1.Text = "0";


                    }

                    


                    break;


               case Keys.Return:

                    if (Q == "+")
                    {

                        c = a + b; label1.Text = c + "";
                        label2.Text = b + " + " + a + " = " + c;
                        Q = "";
                        label1.Text = c + ""; Q1 = "";
                        a = c;
                        b = 0;
                    }

                    else if (Q == "-")
                    {
                        c = a - b; c = c * -1; label1.Text = c + "";
                        label2.Text = b + " - " + a + " = " + c;
                        Q = "";
                        label1.Text = c + ""; Q1 = "";
                        a = c;
                        b = 0;

                    }
                    else if (Q == "*")
                    {
                        c = a * b; label1.Text = c + "";
                        label2.Text = b + " * " + a + " = " + c;
                        Q = "";
                        label1.Text = c + "";
                        Q1 = "";
                        a = c;
                        b = 0;
                    }

                    else if (Q == "/")
                    {
                        c = b / a; if (a == b) { c = 1; }
                        label1.Text = c + "";
                        label2.Text = b + " / " + a + " = " + c;
                        Q = "";
                        label1.Text = c + "";

                        Q1 = "";
                        a = c;
                        b = 0;

                    }

                    break;



                case Keys.Back:


                    G = 1;
                    if (label1.Text != "0")
                    {

                        if (a != 0)
                        {
                            F = label1.Text;
                            F = F.Substring(0, F.Length - 1);
                            label1.Text = F;
                            if ((int)c % 10 == 0)
                            {
                                c = double.Parse(label1.Text);
                            }
                            if (label1.Text == "")
                            {
                                label1.Text = "0";
                            }
                        }
                    }

                    break;


                case Keys.Add:

                    G = 0;
                    W = 0;
                    mohammad();//تابع محمد را صدا بزن

                    Z = 0;//زد که برای پاک کردن 0 پشت عدد هست را 0 کن تا 0 پشت ورودی دوم یا هرچنتا ی کاربر پاک شود


                    if (Q1 == "")//اگر کیو1 هیچی بود این دستور رو اجراکن
                    {
                        b = a;  //ای را که وردی اول کاربر هست رو توی بی بریز تا دو وردی گرفته شود 

                        a = 0;  //ای را صفر کن تا وردی دوم توی ای جایگذاری شود

                        Q1 = "13";//کیو1 را13 کن تا دوباره این دستور اجرا نشود

                        if (Q == "-" | Q == "*" | Q == "/")//اگر علامتی که کاربر وارد می کند علامتی غیر از + بود  
                        {

                            Q = "";
                        }
                        Q += "+";


                        label2.Text = label1.Text + " + ";//هرچی درونه لیبل 1 هست رو بریز توی لیبل 2 به علاوه ی علامت جمع بکن

                        label1.Text = "0";//لیبل1 رو 0 کن تا برای ورودی 2 عدد را درست بنویسه
                    }



                    else if (Q1 == "13" && b != 0 && a != 0)//اگر کیو1 13 بود و ورودی اول و دوم 0 نبود دستور را اجراکن
                    {


                        c = a + b; label1.Text = c + ""; //ورودی اول را به علاوه ی ورودی دوم بکن بریز توی سی که جواب هست بعد جواب را به علاوه ی دو سمی کالم خالی بکن تا به استیرینگ تبدیل شود و درون لیبل 1 چاپ کن 
                        label2.Text = b + " + " + a + " = " + c;//درون لیبل 2 بنویس ای + بی = سی
                        Q = "";
                        label1.Text = c + "";
                        Q1 = "";
                        b = c;
                        a = 0;


                        Q1 = "13";
                        if (Q == "-" | Q == "*" | Q == "/")
                        {
                            a = double.Parse(label1.Text);
                            Q = "";
                        }
                        Q += "+";

                        label2.Text = label1.Text + " + ";

                        label1.Text = "0";


                    }


                    break;





            }
return true;



        }

















        private void mohammad() { W = 0; }//تابع برای اینکه بعد از وارد کردن عدد بتوان دوباره پشت عدد اعشار گذاشت






        private void button14_Click_1(object sender, EventArgs e)
        {
            if (Q == "+")
            {

                c = a + b; label1.Text = c + "";
                label2.Text = b + " + " + a + " = " + c;
                Q = "";
                label1.Text = c + ""; Q1 = "";
                a = c;
                b = 0;
            }

            else if (Q == "-")
            {
                c = a - b; c = c * -1; label1.Text = c + "";
                label2.Text = b + " - " + a + " = " + c;
                Q = "";
                label1.Text = c + ""; Q1 = "";
                a = c;
                b = 0;

            }
            else if (Q == "*")
            {
                c = a * b; label1.Text = c + "";
                label2.Text = b + " * " + a + " = " + c;
                Q = "";
                label1.Text = c + "";
                Q1 = "";
                a = c;
                b = 0;
            }

            else if (Q == "/")
            {
                c = b / a; if (a == b) { c = 1; }
                label1.Text = c + "";
                label2.Text = b + " / " + a + " = " + c;
                Q = "";
                label1.Text = c + "";

                Q1 = "";
                a = c;
                b = 0;

            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Z++;
            if (Z == 1)
            {
                F = label1.Text;
                F = F.Substring(0, F.Length - 1);
                label1.Text = F;
            }

            if (G == 1)
            {
                F = label1.Text;
                F = F.Substring(0, F.Length - 1);
                label1.Text = F;G = 0;
            }
            







            Button S = (Button)sender;
            label1.Text += S.Text;
            a = double.Parse(label1.Text);

        }

        private void button16_Click_1(object sender, EventArgs e)
        {

            G = 0;
            W = 0;
            mohammad();//تابع محمد را صدا بزن

            Z = 0;//زد که برای پاک کردن 0 پشت عدد هست را 0 کن تا 0 پشت ورودی دوم یا هرچنتا ی کاربر پاک شود


            if (Q1 == "")//اگر کیو1 هیچی بود این دستور رو اجراکن
            {
                b = a;  //ای را که وردی اول کاربر هست رو توی بی بریز تا دو وردی گرفته شود 

                a = 0;  //ای را صفر کن تا وردی دوم توی ای جایگذاری شود

                Q1 = "13";//کیو1 را13 کن تا دوباره این دستور اجرا نشود

                if (Q == "-" | Q == "*" | Q == "/")//اگر علامتی که کاربر وارد می کند علامتی غیر از + بود  
                {

                    Q = "";
                }
                Q += "+";


                label2.Text = label1.Text + " + ";//هرچی درونه لیبل 1 هست رو بریز توی لیبل 2 به علاوه ی علامت جمع بکن

                label1.Text = "0";//لیبل1 رو 0 کن تا برای ورودی 2 عدد را درست بنویسه
            }



            else if (Q1 == "13" && b != 0 && a != 0)//اگر کیو1 13 بود و ورودی اول و دوم 0 نبود دستور را اجراکن
            {


                c = a + b; label1.Text = c + ""; //ورودی اول را به علاوه ی ورودی دوم بکن بریز توی سی که جواب هست بعد جواب را به علاوه ی دو سمی کالم خالی بکن تا به استیرینگ تبدیل شود و درون لیبل 1 چاپ کن 
                label2.Text = b + " + " + a + " = " + c;//درون لیبل 2 بنویس ای + بی = سی
                Q = "";
                label1.Text = c + "";
                Q1 = "";
                b = c;
                a = 0;


                Q1 = "13";
                if (Q == "-" | Q == "*" | Q == "/")
                {
                    a = double.Parse(label1.Text);
                    Q = "";
                }
                Q += "+";

                label2.Text = label1.Text + " + ";

                label1.Text = "0";


            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            G = 0;
            W = 0;

            mohammad();

            Z = 0;
            if (Q1 == "")
            {
                b = a; a = 0;
                Q1 = "14";
                if (Q == "*" | Q == "+" | Q == "/")
                {
                    a = double.Parse(label1.Text);
                    Q = "";
                }
                Q += "-";

                label2.Text = label1.Text + " - ";

                label1.Text = "0";
            }
            else if (Q1 == "14" && label1.Text == "")
            {

                Q1 = "14";
                if (Q == "-" | Q == "+" | Q == "/")
                {
                    a = double.Parse(label1.Text);
                    Q = ""; label1.Text = "";
                }
            }

            else if (Q1 == "14" && b != 0 && a != 0)
            {


                c = a * b; label1.Text = c + "";
                label2.Text = b + " * " + a + " = " + c;
                Q = "";
                label1.Text = c + "";
                Q1 = "";
                b = c;
                a = 0;


                Q1 = "14";
                if (Q == "*" | Q == "+" | Q == "/")
                {
                    a = double.Parse(label1.Text);
                    Q = "";
                }
                Q += "*";

                label2.Text = label1.Text + " * ";

                label1.Text = "0";


            }


        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            G = 0;
            W = 0;
            mohammad();
            Z = 0;


            if (Q1 == "")
            {
                b = a; a = 0;
                Q1 = "12";
                if (Q == "-" | Q == "+" | Q == "/")
                {
                    a = double.Parse(label1.Text);
                    Q = "";
                }
                Q += "*";

                label2.Text = label1.Text + " * ";

                label1.Text = "0";
            }
            else if (Q1 == "12" && label1.Text == "")
            {

                Q1 = "12";
                if (Q == "-" | Q == "+" | Q == "/")
                {
                    a = double.Parse(label1.Text);
                    Q = ""; label1.Text = "";
                }
            }

            else if (Q1 == "12" && b != 0 && a != 0)
            {


                c = a * b; label1.Text = c + "";
                label2.Text = b + " * " + a + " = " + c;
                Q = "";
                label1.Text = c + "";
                Q1 = "";
                b = c;
                a = 0;


                Q1 = "12";
                if (Q == "-" | Q == "+" | Q == "/")
                {
                    a = double.Parse(label1.Text);
                    Q = "";
                }
                Q += "*";

                label2.Text = label1.Text + " * ";

                label1.Text = "0";


            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            W = 0;
            mohammad();
            Z = 0;

            if (Q1 == "")
            {
                b = a; a = 0;
                Q1 = "13";
                if (Q == "-" | Q == "+" | Q == "*")
                {
                    a = double.Parse(label1.Text);
                    Q = "";
                }
                Q += "/";

                label2.Text = label1.Text + " / ";

                label1.Text = "0";
            }

            else if (Q1 == "13" && b != 0 && a != 0)
            {


                c = b / a; if (a == b) { c = 1; }
                label1.Text = c + "";
                label2.Text = b + " / " + a + " = " + c;
                Q = "";
                label1.Text = c + "";
                Q1 = "";
                b = c;
                a = 0;


                Q1 = "13";
                if (Q == "-" | Q == "+" | Q == "*")
                {
                    a = double.Parse(label1.Text);
                    Q = "";
                }
                Q += "/";

                label2.Text = label1.Text + " / ";

                label1.Text = "0";


            }
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            G=1;
            if (label1.Text != "0")
            {

                if (a != 0)
                {
                    F = label1.Text;
                    F = F.Substring(0, F.Length - 1);
                    label1.Text = F;
                    if ((int)c % 10 == 0) { 
                   c = double.Parse(label1.Text);}
                    if (label1.Text == "")
                    {
                        label1.Text = "0";
                    }
                }
            }

        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            if (a > 0)
            {
                a = a * -1;
                label1.Text = a + "";

            }
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            if (a < 0)
            {
                a = a * -1;
                label1.Text = a + "";
            }

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            W++;
            if (W == 1)
            {

                Button S = (Button)sender;
                label1.Text += S.Text;
                a = double.Parse(label1.Text);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

                a = a * -1;
                label1.Text = a + "";


            }
        }
    }

