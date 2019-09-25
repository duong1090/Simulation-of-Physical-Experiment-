using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DienTruong_Ver5
{
    public partial class Form1 : Form
    {
        
        const int XBOX = 149;
        const int YBOX = 12;
        const int SIZEXBOX = 615;
        const int SIZEYBOX = 480;

        const int LENGTHMAX = 50;
        const int LENGTHMIN = 10;

        const int DISMAX = 25;
        const int MIDPOINTX = 12;
        const int MIDPOINTY = 12;
        const int MATRIXLIMIT = 25;

        const int VECTORS = 500;
        const int SIZEBUTTONS = 21;
        

        const int SIZEMEASURE = 15;



        List<ButtonCircle> listPositive = new List<ButtonCircle>();
        List<ButtonCircle> listNegative = new List<ButtonCircle>();

        int[,] ArrayVector = new int[VECTORS, 2];
        float[,] ArrayPropertiesVectors = new float[VECTORS, 2];
        int[] Length = new int[15];

        int mouseX, mouseY;
        int originX, originY;
        Button btnMove;
        Button btnVuaTao;
        private bool Flag = false;

        private bool FlagMeasure = false;
        int mouseX1, mouseY1;
        int originX1, originY1;

        int CountPositive = 0, CountNegative = 0;
        float Qcharges = 1;


        //Form
        private void Form1_Load(object sender, EventArgs e)
        {
            //Tao cac Vector
            Bitmap bm = new Bitmap(615, 480);
            int x = 0, y = 0;
            for (int i = 0; i < VECTORS; i++)
            {
                ArrayVector[i, 0] = MIDPOINTX + x * DISMAX;
                ArrayVector[i, 1] = MIDPOINTY + y * DISMAX;
                
                pictureBox1.Image = bm;
                x++;
                if (x == MATRIXLIMIT)
                {
                    x = 0; y++;
                }

            }
            /*
            //Tao do dai Vector
            for (int i = 0; i < ARRAYLENGTHVECTORS; i++)
                Length[i] = 5 * i;*/
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Tinh Vector
            if (Flag)
            {
                
                btnMove.Location = new Point(originX - mouseX + Cursor.Position.X, originY - mouseY + Cursor.Position.Y);
                if (btnMove.Location.X >= XBOX + SIZEXBOX - SIZEBUTTONS)
                    btnMove.Location = new Point(XBOX + SIZEXBOX - SIZEBUTTONS, btnMove.Location.Y);
                if (btnMove.Location.Y > YBOX + SIZEYBOX - SIZEBUTTONS)
                    btnMove.Location = new Point(btnMove.Location.X, YBOX + SIZEYBOX - SIZEBUTTONS);
                if (btnMove.Location.Y < YBOX)
                    btnMove.Location = new Point(btnMove.Location.X, YBOX);
                if (btnMove.Location.X < 0)
                    btnMove.Location = new Point(0, btnMove.Location.Y);

                Bitmap bm = new Bitmap(615, 480);
                if ((Cursor.Position.X - mouseX) != 0 || (Cursor.Position.Y - mouseY) != 0)
                {
                    float Emax = -1, Emin = 1;
                    for (int i = 0; i < VECTORS; i++)
                    {
                        int XV = ArrayVector[i, 0], YV = ArrayVector[i,1];
                        float E=1, angle=1;
                        

                        Electric(XV, YV,ref E,ref angle);
                        float ELength = (float)(Math.Pow(E * 1E+10, 1.0 / 4))/1.5F;

                        if (ELength > Emax)
                            Emax = ELength;
                        if (ELength < Emin)
                            Emin = ELength;

                        
                        
                        ArrayPropertiesVectors[i, 0] = angle;
                        ArrayPropertiesVectors[i, 1] = ELength;
                        DrawVector(bm, ArrayVector[i, 0], ArrayVector[i, 1], (int)ArrayPropertiesVectors[i, 1], ArrayPropertiesVectors[i, 0]);
                        pictureBox1.Image = bm;
                    }
                }

            }
            
            //Tinh Measure
            if (FlagMeasure)
            {
                Measure.Location = new Point(originX1 - mouseX1 + Cursor.Position.X, originY1 - mouseY1 + Cursor.Position.Y);
                Measure.BringToFront();
            }
            if (Measure.Location.X > XBOX && Measure.Location.Y > YBOX)
            {
                int XV = Measure.Location.X - XBOX + (SIZEMEASURE/2); int YV = Measure.Location.Y - YBOX + (SIZEMEASURE/2);

                if (XV > 0 && YV > 0)
                {
                    float E = 1, angle = 1;
                    Electric(XV, YV,ref E,ref angle);
                    if ((Cursor.Position.X - mouseX) != 0 || (Cursor.Position.Y - mouseY) != 0)
                        DauDo.Text = Math.Round((E  * 9E+4),3).ToString();
                }
            }
            else
            {
                DauDo.Text = null;
                //if (Measure.Location.X < XBOX)
                  //  Measure.Location = new Point(23, 155);
            }
        }



        //Charges
        private void PositiveCharges_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonCircle btnGoc = (ButtonCircle)sender;
            ButtonCircle btn = new ButtonCircle();

            btn.Location = new Point(btnGoc.Location.X, btnGoc.Location.Y);
            btn.Size = new Size(btnGoc.Size.Width, btnGoc.Size.Height);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackgroundImageLayout = btnGoc.BackgroundImageLayout;
            btn.BackgroundImage = btnGoc.BackgroundImage;
            btn.Tag = Qcharges.ToString();
            btn.MouseDown += new MouseEventHandler(btnMove_MouseDown);
            btn.MouseUp += new MouseEventHandler(btnMove_MouseUp);
            listPositive.Add(btn);
            Controls.Add(btn);
            listPositive[CountPositive].BringToFront();

            btnMove_MouseDown(listPositive[CountPositive], null);
            btnVuaTao = btn;
            CountPositive++;

        }
        private void PositiveCharges_MouseUp(object sender, MouseEventArgs e)
        {
            btnMove_MouseUp(btnVuaTao, null);
        }



        private void NegativeCharges_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonCircle btnGoc = (ButtonCircle)sender;
            ButtonCircle btn = new ButtonCircle();
            btn.Location = new Point(btnGoc.Location.X, btnGoc.Location.Y);
            btn.Size = new Size(btnGoc.Size.Width, btnGoc.Size.Height);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            btn.BackgroundImageLayout = btnGoc.BackgroundImageLayout;
            btn.BackgroundImage = btnGoc.BackgroundImage;
            btn.Name = "btnAm" + listPositive.Count.ToString();
            btn.Tag = Qcharges.ToString();
            btn.MouseDown += new MouseEventHandler(btnMove_MouseDown);
            btn.MouseUp += new MouseEventHandler(btnMove_MouseUp);
            listNegative.Add(btn);
            Controls.Add(btn);
            listNegative[CountNegative].BringToFront();
            btnMove_MouseDown(listNegative[CountNegative], null);
            btnVuaTao = btn;
            CountNegative++;
        }

        private void NegativeCharges_MouseUp(object sender, MouseEventArgs e)
        {
            btnMove_MouseUp(btnVuaTao, null);
        }

        private void btnMove_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonCircle btnDisappear = (ButtonCircle)sender;
            if (!(btnMove.Location.X >= XBOX && btnMove.Location.Y >= YBOX))
            {
                if (listPositive.Contains(btnDisappear))
                {
                    CountPositive--;
                    listPositive.Remove(btnDisappear);

                }
                if (listNegative.Contains(btnDisappear))
                {
                    CountNegative--;
                    listNegative.Remove(btnDisappear);
                }
                timer1_Tick(null, null);
                Controls.Remove(btnDisappear);

            }
            Flag = false;

        }

        private void btnMove_MouseDown(object sender, MouseEventArgs e)
        {
            btnMove = (Button)sender;
            Flag = true;
            mouseX = Cursor.Position.X;
            mouseY = Cursor.Position.Y;

            originX = btnMove.Location.X;
            originY = btnMove.Location.Y;
        }
        


        //Measure
        private void Measure_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonCircle btnDisappear = (ButtonCircle)sender;
            if (!(Measure.Location.X >= XBOX && Measure.Location.Y >= YBOX))
            {
                timer1_Tick(null, null);
                Measure.Location = new Point(23, 155);
            }

            FlagMeasure = false;

        }

        private void Measure_MouseDown(object sender, MouseEventArgs e)
        {
            FlagMeasure = true;
            mouseX1 = Cursor.Position.X;
            mouseY1 = Cursor.Position.Y;
            originX1 = Measure.Location.X;
            originY1 = Measure.Location.Y;
        }

        private void Information_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            form.Hide();
            

        }



        //Tools
        private void SetQ_Click(object sender, EventArgs e)
        {

            if (float.TryParse(DienTich.Text, out Qcharges))
                Qcharges /= 10;



            else
                MessageBox.Show("NHẬP LỖI. VUI LÒNG NHẬP LẠI", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            

        }
        private void Reset_Click(object sender, EventArgs e)
        {
            //Xoa Vector
            while (CountPositive > 0)
            {
                Controls.Remove(listPositive[0]);
                listPositive.Remove(listPositive[0]);
                CountPositive--;
            }
            while (CountNegative > 0)
            {
                Controls.Remove(listNegative[0]);
                listNegative.Remove(listNegative[0]);
                CountNegative--;
            }
            pictureBox1.Image = null;

            //Dua Measure ve trang thai ban dau
            Measure.Location = new Point(23, 155);
            DienTich.Text = 10.ToString();
            DauDo.Text = null;
            
            //Cai dat lai Qcharges
            Qcharges = 1;
        }



        //Functions
        public void Electric(int XV, int YV,ref float E,ref float angle)
        {

            float EX = 0, EY = 0, sin;
            int j = 0, k = 0;
            while (j < CountPositive || k < CountNegative)
            {
                int XB = 0, YB = 0;
                if (j < CountPositive)
                {

                    XB = listPositive[j].Location.X - XBOX + (SIZEBUTTONS/2); YB = listPositive[j].Location.Y - YBOX + (SIZEBUTTONS/2);
                    EX += new Caculator(XB, YB, XV, YV).ElectricX() * float.Parse(listPositive[j].Tag.ToString());
                    EY += new Caculator(XB, YB, XV, YV).ElectricY() * float.Parse(listPositive[j].Tag.ToString());
                    j++;
                }

                if (k < CountNegative)
                {
                    XB = listNegative[k].Location.X - XBOX + (SIZEBUTTONS / 2); YB = listNegative[k].Location.Y - YBOX + (SIZEBUTTONS / 2);
                    EX -= new Caculator(XB, YB, XV, YV).ElectricX() * float.Parse(listNegative[k].Tag.ToString());
                    EY -= new Caculator(XB, YB, XV, YV).ElectricY() * float.Parse(listNegative[k].Tag.ToString());
                    k++;
                }
            }

            E = (float)Math.Sqrt((EX * EX) + (EY * EY));
            sin = EY / E;
            angle = (float)Math.Asin(sin);
            if (EX <= 0 && EY <= 0)
                angle = (float)Math.PI - angle;
            if (EX < 0 && EY > 0)
                angle = -(float)Math.PI - angle;
        }
        
        public void DrawVector(Bitmap bm, int x, int y, int Length, float angle)
        {
            Graphics g = Graphics.FromImage(bm);
            Pen p = new Pen(Color.White, 2.0F);

            p.EndCap = LineCap.ArrowAnchor;
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);
            

            int X1 = (int)((((float)-Length / 2) * cos) + x);
            int Y1 = (int)((((float)-Length / 2) * sin) + y);
            int X2 = (int)((((float)Length / 2) * cos) + x);
            int Y2 = (int)((((float)Length / 2) * sin) + y);

            AdjustableArrowCap arrow = new AdjustableArrowCap(3.5F, 3.5F);
            p.CustomEndCap = arrow;
            g.DrawLine(p, new Point(X1, Y1), new Point(X2, Y2));

            p.Dispose();
            g.Dispose();
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
