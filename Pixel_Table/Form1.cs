using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace servo_deneme
{
    public partial class Form1 : Form
    {
        SerialPort myport;
        SerialPort myport0;

        Boolean mybool00 = false;
        Boolean mybool01 = false;
        Boolean mybool02 = false;
        Boolean mybool03 = false;
        Boolean mybool04 = false;

        Boolean mybool10 = false;
        Boolean mybool11 = false;
        Boolean mybool12 = false;
        Boolean mybool13 = false;
        Boolean mybool14 = false;

        Boolean mybool20 = false;
        Boolean mybool21 = false;
        Boolean mybool22 = false;
        Boolean mybool23 = false;
        Boolean mybool24 = false;

        Boolean mybool30 = false;
        Boolean mybool31 = false;
        Boolean mybool32 = false;
        Boolean mybool33 = false;
        Boolean mybool34 = false;

        Boolean mybool40 = false;
        Boolean mybool41 = false;
        Boolean mybool42 = false;
        Boolean mybool43 = false;

        String s000 = "a";
        String s001 = "b";

        String s010 = "c";
        String s011 = "d";

        String s020 = "e";
        String s021 = "f";

        String s030 = "g";
        String s031 = "h";

        String s040 = "i";
        String s041 = "j";

        String s100 = "k";
        String s101 = "l";

        String s110 = "m";
        String s111 = "n";

        String s120 = "o";
        String s121 = "p";

        String s130 = "r";
        String s131 = "s";

        String s140 = "t";
        String s141 = "u";

        String s200 = "v";
        String s201 = "y";

        String s210 = "z";
        String s211 = "x";

        String s220 = "a";
        String s221 = "b";

        String s230 = "c";
        String s231 = "d";

        String s240 = "e";
        String s241 = "f";

        String s300 = "g";
        String s301 = "h";

        String s310 = "i";
        String s311 = "j";

        String s320 = "k";
        String s321 = "l";

        String s330 = "m";
        String s331 = "n";

        String s340 = "o";
        String s341 = "p";

        String s400 = "r";
        String s401 = "s";

        String s410 = "t";
        String s411 = "u";

        String s420 = "v";
        String s421 = "y";

        String s430 = "z";
        String s431 = "x";

        public Form1()
        {
            InitializeComponent();
            Start();
            Start0();
        }

        private void Start0()
        {
            myport0 = new SerialPort();
            myport0.PortName = "COM4";
            myport0.BaudRate = 9600;
            try
            {
                myport0.Open();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void Start()
        {
            myport = new SerialPort();
            myport.PortName = "COM5";
            myport.BaudRate = 9600;
            try
            {
                myport.Open();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (myport.IsOpen)
            {
                if (mybool00 == false)
                { 
                    myport.WriteLine(s000);
                    mybool00 = true;
                }
                else
                {
                    myport.WriteLine(s001);
                    mybool00 = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (myport.IsOpen)
            {
                if (mybool10 == false)
                {
                    myport.WriteLine(s101);
                    mybool10 = true;
                }
                else
                {
                    myport.WriteLine(s100);
                    mybool10 = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (myport.IsOpen)
            {
                if (mybool20 == false)
                {
                    myport.WriteLine(s201);
                    mybool20 = true;
                }
                else
                {
                    myport.WriteLine(s200);
                    mybool20 = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (myport.IsOpen)
            {
                if (mybool30 == false)
                {
                    myport.WriteLine(s301);
                    mybool30 = true;
                }
                else
                {
                    myport.WriteLine(s300);
                    mybool30 = false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (myport.IsOpen)
            {
                if (mybool40 == false)
                {
                    myport.WriteLine(s401);
                    mybool40 = true;
                }
                else
                {
                    myport.WriteLine(s400);
                    mybool40 = false;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (myport.IsOpen)
            {
                if (mybool01 == false)
                {
                    myport.WriteLine(s011);
                    mybool01 = true;
                }
                else
                {
                    myport.WriteLine(s010);
                    mybool01 = false;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (myport.IsOpen)
            {
                if (mybool11 == false)
                {
                    myport.WriteLine(s111);
                    mybool11 = true;
                }
                else
                {
                    myport.WriteLine(s110);
                    mybool11 = false;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (myport.IsOpen)
            {
                if (mybool21 == false)
                {
                    myport.WriteLine(s211);
                    mybool21 = true;
                }
                else
                {
                    myport.WriteLine(s210);
                    mybool21 = false;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (myport.IsOpen)
            {
                if (mybool31 == false)
                {
                    myport.WriteLine(s311);
                    mybool31 = true;
                }
                else
                {
                    myport.WriteLine(s310);
                    mybool31 = false;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (myport.IsOpen)
            {
                if (mybool41 == false)
                {
                    myport.WriteLine(s411);
                    mybool41 = true;
                }
                else
                {
                    myport.WriteLine(s410);
                    mybool41 = false;
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (myport.IsOpen)
            {
                if (mybool02 == false)
                {
                    myport.WriteLine(s021);
                    mybool02 = true;
                }
                else
                {
                    myport.WriteLine(s020);
                    mybool02 = false;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (myport.IsOpen)
            {
                if (mybool12 == false)
                {
                    myport.WriteLine(s121);
                    mybool12 = true;
                }
                else
                {
                    myport.WriteLine(s120);
                    mybool12 = false;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (myport.IsOpen)
            {
                if (mybool22 == false)
                {
                    myport.WriteLine(s221);
                    mybool22 = true;
                }
                else
                {
                    myport.WriteLine(s220);
                    mybool22 = false;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (myport0.IsOpen)
            {
                if (mybool32 == false)
                {
                    myport0.WriteLine(s321);
                    mybool32 = true;
                }
                else
                {
                    myport0.WriteLine(s320);
                    mybool32 = false;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (myport0.IsOpen)
            {
                if (mybool42 == false)
                {
                    myport0.WriteLine(s421);
                    mybool42 = true;
                }
                else
                {
                    myport0.WriteLine(s420);
                    mybool42 = false;
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (myport0.IsOpen)
            {
                if (mybool03 == false)
                {
                    myport0.WriteLine(s031);
                    mybool03 = true;
                }
                else
                {
                    myport0.WriteLine(s030);
                    mybool03 = false;
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (myport0.IsOpen)
            {
                if (mybool13 == false)
                {
                    myport0.WriteLine(s131);
                    mybool13 = true;
                }
                else
                {
                    myport0.WriteLine(s130);
                    mybool13 = false;
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (myport0.IsOpen)
            {
                if (mybool23 == false)
                {
                    myport0.WriteLine(s231);
                    mybool23 = true;
                }
                else
                {
                    myport0.WriteLine(s230);
                    mybool23 = false;
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (myport0.IsOpen)
            {
                if (mybool33 == false)
                {
                    myport0.WriteLine(s331);
                    mybool33 = true;
                }
                else
                {
                    myport0.WriteLine(s330);
                    mybool33 = false;
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (myport0.IsOpen)
            {
                if (mybool43 == false)
                {
                    myport0.WriteLine(s431);
                    mybool43 = true;
                }
                else
                {
                    myport0.WriteLine(s430);
                    mybool43 = false;
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (myport0.IsOpen)
            {
                if (mybool04 == false)
                {
                    myport0.WriteLine(s041);
                    mybool04 = true;
                }
                else
                {
                    myport0.WriteLine(s040);
                    mybool04 = false;
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (myport0.IsOpen)
            {
                if (mybool14 == false)
                {
                    myport0.WriteLine(s141);
                    mybool14 = true;
                }
                else
                {
                    myport0.WriteLine(s140);
                    mybool14 = false;
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (myport0.IsOpen)
            {
                if (mybool24 == false)
                {
                    myport0.WriteLine(s241);
                    mybool24 = true;
                }
                else
                {
                    myport0.WriteLine(s240);
                    mybool24 = false;
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (myport0.IsOpen)
            {
                if (mybool34 == false)
                {
                    myport0.WriteLine(s341);
                    mybool34 = true;
                }
                else
                {
                    myport0.WriteLine(s340);
                    mybool34 = false;
                }
            }
        }
    }
}

