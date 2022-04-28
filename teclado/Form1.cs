using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace teclado
{
    public partial class Form1 : Form
    {
        public int c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c = 0;
            this.Focus();
            
         
        }
        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    btn_esc.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.F1:
                    btn_f1.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.F2:
                    btn_f2.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.F3:
                    btn_f3.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.F4:
                    btn_f4.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.F5:
                    btn_f5.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.F6:
                    button37.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.F7:
                    button36.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.F8:
                    button35.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.F9:
                    button46.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.F10:
                    button45.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.F12:
                    button43.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Pause:
                    button42.Visible = false;
                    btn_print.Visible = false;
                    c = c + 1 ;
                    break;
               
                case Keys.Insert:
                    button40.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Delete:
                    button39.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Oem5:
                    button34.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.D1:
                    button33.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.D2:
                    button32.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.D3:
                    button31.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.D4:
                    button30.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.D5:
                    button29.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.D6:
                    button28.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.D7:
                    button27.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.D8:
                    button26.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.D9:
                    button25.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.D0:
                    button24.Visible = false;
                    button23.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Oem1:
                    button5.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Oem6:
                    button22.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Back:
                    button18.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Q:
                    button15.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.W:
                    button14.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.E:
                    button13.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.R:
                    button12.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.T:
                    button11.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Y:
                    button10.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.U:
                    button9.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.I:
                    button8.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.O:
                    button7.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.P:
                   //button6.Text = "*";
                    button6.Visible = false;
                    button5.Visible = false;
                    c = c + 1 ;
                    break;
                
                case Keys.Oemplus:
                    button4.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Enter:
                    button3.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.CapsLock:
                    button58.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.A:
                    button57.Visible = false;
                     c = c + 1 ;
                    break;
                case Keys.S:
                    button56.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.D:
                    button55.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.F:
                    button54.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.G:
                    button53.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.H:
                    button52.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.J:
                    button51.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.K:
                    button50.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.L:
                    button49.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Oemtilde:
                    button48.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Oem7:
                    button47.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.OemQuestion:
                    button17.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.OemBackslash:
                    button70.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Z:
                    button69.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.X:
                    button68.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.C:
                    button67.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.V:
                    button66.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.B:
                    button65.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.N:
                    button64.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.M:
                    button63.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Oemcomma:
                    button62.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.OemPeriod:
                    button61.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.OemMinus:
                    button60.Visible = false;
                    button59.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.ShiftKey:
                    button71.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.ControlKey:
                    button83.Visible = false;
                    button82.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.LWin:
                    button81.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Menu:
                    button80.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Space:
                    button79.Visible = false;
                    button73.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Apps:
                    button78.Visible = false;
                    button77.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Left:
                    button76.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Down:
                    button75.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Right:
                    button74.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.F11:
                    button1.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Up:
                    btn_arriba.Visible = false;
                    button72.Visible = false;
                    c = c + 1 ;
                    break;
                case Keys.Tab:
                    button16.Visible = false;
                    c = c + 1 ;
                    
                
                    
                    break;
            }
        }

        private void button2_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
        }

        private void btn_print_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // label2.Text = c.ToString();
            if (c > 79)
            {
                TextWriter unidad = new StreamWriter(@"LOG\teclado_ok.txt");
                unidad.Write(label2.Text);
                unidad.Close();
                Close();
            }
        }

      

       
       
    }
}
