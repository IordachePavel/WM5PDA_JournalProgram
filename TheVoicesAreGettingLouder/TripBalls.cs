using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace TheVoicesAreGettingLouder
{
    public partial class TripBalls : Form
    {
        Thread ScreenSaverUpdate;


        public int Mode = 1;

        int xMax = 240;
        int yMax = 320;
        int xMin = 0;
        int yMin = 0;

        int SideHit = 0;
        int IntermediaryMemoryValue = 0;
        int OldDrawMemory = 0;

        int xA = 0;
        int yA = 0;
        int xB = 0;
        int yB = 0;
        int xC = 0;
        int yC = 0;
        int xD = 0;
        int yD = 0;

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public double Direction { get; set; }
            public int Radius { get; set; }
            public bool ComputedTargetQuadrant { get; set; }
            public int TargetQuardant { get; set; }
            public int MaxRadius { get; set; }

            public Point(int x, int y, double dir, int rad, bool computedtargetquadrant, int targetquadrant, int mxradius)
            {
                X = x;
                Y = y;
                Direction = dir;
                Radius = rad;
                ComputedTargetQuadrant = computedtargetquadrant;
                TargetQuardant = targetquadrant;
                MaxRadius = mxradius;
            }
        }

        Point A = new Point(120, 160, 3 * Math.PI / 2, 0,false, 0,0);
        Point B = new Point(120, 160, 7 * Math.PI / 6, 0,false,0,0);
        Point C = new Point(120, 160, (7 * Math.PI / 6) + (2 * Math.PI / 3), 0,false,0,0);
        Point D = new Point(120, 160, (5 * Math.PI) / 3, 0,false,0,0);


        public void ChangeScreensaver(object sender, EventArgs e)
        {
            ComputedEnvVariable = false;
            xMax = 240;
            yMax = 320;
            xMin = 0;
            yMin = 0;
            A.X = 120;
            A.Y = 160;
            A.Direction = GenerateRandomFloat(0, 2 * Math.PI);
            A.Radius = 0;
            A.ComputedTargetQuadrant = false;
            A.TargetQuardant = 0;
            A.MaxRadius = 0;
            B.X = 120;
            B.Y = 160;
            B.Direction = GenerateRandomFloat(0, 2 * Math.PI);
            B.Radius = 0;
            B.ComputedTargetQuadrant = false;
            B.TargetQuardant = 0;
            B.MaxRadius = 0;
            C.X = 120;
            C.Y = 160;
            C.Direction = GenerateRandomFloat(0, 2 * Math.PI);
            C.Radius = 0;
            C.ComputedTargetQuadrant = false;
            C.TargetQuardant = 0;
            C.MaxRadius = 0;
            D.X = 120;
            D.Y = 160;
            D.Direction = GenerateRandomFloat(0, 2 * Math.PI);
            D.Radius = 0;
            D.ComputedTargetQuadrant = false;
            D.TargetQuardant = 0;
            D.MaxRadius = 0;
            //A = new Point(120, 160, 3 * Math.PI / 2, 0, false, 0, 0);
            //B = new Point(120, 160, 7 * Math.PI / 6, 0, false, 0, 0);
            //C = new Point(120, 160, (7 * Math.PI / 6) + (2 * Math.PI / 3), 0, false, 0, 0);
            //D = new Point(120, 160, (5 * Math.PI) / 3, 0, false, 0, 0);
            xA = 0;
            yA = 0;
            xB = 0;
            yB = 0;
            xC = 0;
            yC = 0;
            xD = 0;
            yD = 0;
            //if(false)
            if (Mode < 4)
            {
                Mode++;
            }
            else
            {
                Mode = 1;
            }
          //  Mode = 4;
        }

        public double GenerateRandomFloat(double min, double max)
        {
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }

        public int ComputeTargetQuadrant(Point point)
        {
            if (point.Direction >= 0 && point.Direction <= Math.PI / 2)
            {
                return 1;
            }
            if (point.Direction >= Math.PI / 2 && point.Direction <= Math.PI)
            {
                return 2;
            }
            if (point.Direction >= Math.PI && point.Direction <= 3 * (Math.PI / 2))
            {
                return 3;
            }
            else
                return 4;
        }
        public int ComputeRadiusMaxValue(int quadrant, Point point)
        {
            // 1st quadrant 0 - 90 deg (0 - PI/2)
            // 2nd quadrant 90 - 180 deg (PI/2 - PI)
            // 3rd quadrant 180 - 270 deg (PI - 3PI/2)
            // 4th quadrant 270 - 360 deg (3PI/2 - 2PI)

            // Limits of the box
            

            double ETA1 = 0;
            double ETA2 = 0;

            // Calculate ETA1 and ETA2 based on the quadrant
            switch (quadrant)
            {
                case 1: // Moving towards top right corner
                    // Limits are X = xMax, Y = 0 (top)
                    ETA1 = Math.Abs((xMax - point.X) / Math.Cos(point.Direction)); // Calc for X
                    ETA2 = Math.Abs((yMin - point.Y) / Math.Sin(point.Direction)); // Calc for Y
                    break;

                case 2: // Moving towards top left corner
                    // Limits are X = 0, Y = 0 (top)
                    ETA1 = Math.Abs((xMin - point.X) / Math.Cos(point.Direction)); // Calc for X
                    ETA2 = Math.Abs((yMin - point.Y) / Math.Sin(point.Direction)); // Calc for Y
                    break;

                case 3: // Moving towards bottom left corner
                    // Limits are X = 0, Y = yMax (bottom)
                    ETA1 = Math.Abs((xMin - point.X) / Math.Cos(point.Direction)); // Calc for X
                    ETA2 = Math.Abs((yMax - point.Y) / Math.Sin(point.Direction)); // Calc for Y
                    break;

                case 4: // Moving towards bottom right corner
                    // Limits are X = xMax, Y = yMax (bottom)
                    ETA1 = Math.Abs((xMax - point.X) / Math.Cos(point.Direction)); // Calc for X
                    ETA2 = Math.Abs((yMax - point.Y) / Math.Sin(point.Direction)); // Calc for Y
                    break;

                default:
                    throw new ArgumentOutOfRangeException("Invalid quadrant value");
            }

            //Side 1 right
            //Side 2 top
            //Side 3 left
            //Side 4 bottom
            //ETA1 is X
            //ETA2 is Y
            //Smallest ETA is the side its going to hit.
            if (ETA1 > ETA2)
            {
                SideHit = SideHitCompute(quadrant, 1);
                return Convert.ToInt32(ETA2);
            }
            else
            {
                SideHit = SideHitCompute(quadrant, 2);
                return Convert.ToInt32(ETA1);
            }
           // return (int)Math.Min(ETA1, ETA2);
        }

        public int SideHitCompute(int quadrant,int XYHit)
        {
            switch (quadrant)
            {
                case 1:
                    if (XYHit == 1)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                case 2:
                if (XYHit == 1)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
                case 3:
                if (XYHit == 1)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
                case 4:
                if (XYHit == 1)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
                default:
                throw new ArgumentOutOfRangeException("Invalid Parameters");

            }
        }

        public void ComputeImpact(ref Point point)
        {
            // 1st quadrant 0 - 90 deg (0 - PI/2)
            // 2nd quadrant 90 - 180 deg (PI/2 - PI)
            // 3rd quadrant 180 - 270 deg (PI - 3PI/2)
            // 4th quadrant 270 - 360 deg (3PI/2 - 2PI)

            point.X = point.X + Convert.ToInt32(point.Radius * Math.Cos(point.Direction));
            point.Y = point.Y - Convert.ToInt32(point.Radius * Math.Sin(point.Direction));
            double dir = point.Direction;
            int rad = point.Radius;
            int px = point.X;
            int py = point.Y;
            if (point.Y >= yMax) // Hit lower side
            {
               // label2.Invoke((Action)(() => label2.Text = "Hit lower side!\n" + Convert.ToString(dir * (180 / Math.PI)) + "\n" + Convert.ToString(px + Convert.ToInt32(rad * Math.Cos(dir))) + " " + Convert.ToString(py - Convert.ToInt32(rad * Math.Sin(dir)))));
                point.Direction = ComputeOutputQuadrant(point.Direction, 1);
            }
            else if (point.Y <= yMin) // Hit higher side
            {
               // label2.Invoke((Action)(() => label2.Text = "Hit higher side!\n" + Convert.ToString(dir * (180 / Math.PI)) + "\n" + Convert.ToString(px + Convert.ToInt32(rad * Math.Cos(dir))) + " " + Convert.ToString(py - Convert.ToInt32(rad * Math.Sin(dir)))));
                point.Direction = ComputeOutputQuadrant(point.Direction, 2);
            }
            else if (point.X >= xMax) // Hit far right side
            {
                //label2.Invoke((Action)(() => label2.Text = "Hit far right side!\n" + Convert.ToString(dir * (180 / Math.PI)) + "\n" + Convert.ToString(px + Convert.ToInt32(rad * Math.Cos(dir))) + " " + Convert.ToString(py - Convert.ToInt32(rad * Math.Sin(dir)))));
                point.Direction = ComputeOutputQuadrant(point.Direction, 3);
            }
            else if (point.X <= xMin) // Hit far left side
            {
                //label2.Invoke((Action)(() => label2.Text = "Hit far left side!\n" + Convert.ToString(dir * (180 / Math.PI)) + "\n" + Convert.ToString(px + Convert.ToInt32(rad * Math.Cos(dir))) + " " + Convert.ToString(py - Convert.ToInt32(rad * Math.Sin(dir)))));
                point.Direction = ComputeOutputQuadrant(point.Direction, 4);
            }
            else
            {
                //throw new Exception("The hit position is out of range! Position value: " + Convert.ToString(point.X) + " " + Convert.ToString(point.Y) + " " + Convert.ToString(MaxRadius)) ;
                // shhhh...
            }
            point.Radius = 3;          
        }

        public double ComputeOutputQuadrant(double Direction, int Side)
        {
            // For Side values:
            // Hit lower side - 1
            //
            // \     /
            //  \   /
            //   \ /
            //____#____________
            // Hit higher side - 2
            //____#____________
            //   / \
            //  /   \
            // /     \
            ///       \
            // Hit far right side - 3
            //                   \ |
            //                    \|
            //                     #
            //                    /|
            //                   / |
            // Hit far left side - 4
            //| /
            //|/
            //#
            //|\
            //| \
            ////////////////////////
            // Legend: # - Point
            //         \ or / - Trajectory
            //         | or _ - Screen sides

            if (Side == 1)
            {
                if (!(Direction > 3 * (Math.PI / 2)))
                {
                    return GenerateRandomFloat(Math.PI / 2 + (Math.PI / 6), Math.PI - (Math.PI / 6)); 
                }
                else
                {
                    return GenerateRandomFloat((Math.PI / 6), Math.PI / 2 - (Math.PI / 6));        
                }
            }
            if (Side == 2)
            {
                if ((Direction > Math.PI / 2))
                {
                    return GenerateRandomFloat(Math.PI + (Math.PI / 6), 3 * (Math.PI / 2) - (Math.PI / 6));   
                }
                else
                {
                    return GenerateRandomFloat(3 * (Math.PI / 2) + (Math.PI / 6), 2 * Math.PI - (Math.PI / 6));                
                }
            }
            if (Side == 3)
            {
                if ((Direction < 2 * Math.PI)&&Direction>Math.PI/2*3)
                {
                    return GenerateRandomFloat(Math.PI + (Math.PI / 6), 3 * (Math.PI / 2) - (Math.PI / 6));
                }
                else
                {
                    return GenerateRandomFloat(Math.PI + (Math.PI / 6) / 2, Math.PI/2 - (Math.PI / 6));                  
                }
            }
            if (Side == 4)
            {
                if (!(Direction > Math.PI))
                {
                    return GenerateRandomFloat((Math.PI / 6), Math.PI / 2 - 2*(Math.PI / 6));
                }
                else
                {
                    return GenerateRandomFloat(Math.PI * 3 / 2 + (Math.PI / 6), 2 * Math.PI - (Math.PI / 6));   
                }
            }
            throw new Exception("The specified direction is somehow out of range! Direction value: " + Convert.ToString(Direction));
        }

        public bool AdvancePoint(ref Point point)
        {
            if (!point.ComputedTargetQuadrant)
            {
                point.ComputedTargetQuadrant = true;
                //Find out which side will it hit
                point.TargetQuardant = ComputeTargetQuadrant(point);
                point.MaxRadius = ComputeRadiusMaxValue(point.TargetQuardant, point);
            }

            //(OUTDATED) Get current point position
            //int x =point.X + Convert.ToInt32(point.Radius * Math.Cos(point.Direction));
            //int y =point.Y - Convert.ToInt32(point.Radius * Math.Sin(point.Direction));
            if(point.Radius<point.MaxRadius)
            {
                point.Radius++;
                return true; // no side hit
            }
            else
            {
                //MessageBox.Show("HIT!");
                ComputeImpact(ref point);
                point.ComputedTargetQuadrant = false;
                return false;// side hit
            }
        }

        public TripBalls()
        {
            InitializeComponent();
            timer1.Tick += ActivateScreensaver;
            SwitchScreensaverTimer.Tick += ChangeScreensaver;
            ScreenSaverUpdate = new Thread(new ThreadStart(Screensaver));
        }

        private void ActivateScreensaver(object sender, EventArgs e)
        {
                timer1.Enabled = false;   
                ScreenSaverUpdate.Start();
        }

        public bool ComputedEnvVariable = false;
        private void Screensaver()
        {
            Bitmap Canvas = new Bitmap(240, 320);
            using (Pen pen = new Pen(Color.Green))
            using (Graphics gfx = Graphics.FromImage(Canvas))
            {
                pen.Color = Color.Green;
                pen.Width = 2;
                Bitmap TargetImage = new Bitmap(Properties.Resources.GRACE);
                int Height = TargetImage.Height;
                int Width = TargetImage.Width;
                Brush blackBrush = new SolidBrush(Color.Black);
                Brush whiteBrush = new SolidBrush(Color.White); 
                Brush redBrush = new SolidBrush(Color.Red);
                Brush blueBrush = new SolidBrush(Color.Blue); 
                while(Form1.ScreensaverRunning){
                if(Mode==1)
                {
                    if (!ComputedEnvVariable)
                    {
                        gfx.Clear(Color.Black);
                        ComputedEnvVariable = true;
                    }
                    //pen.Color = Color.Black;
                    gfx.DrawLine(pen, xA, yA, xB, yB);
                    gfx.DrawLine(pen, xB, yB, xC, yC);
                    gfx.DrawLine(pen, xC, yC, xD, yD);
                    gfx.DrawLine(pen, xD, yD, xA, yA);

                    

                    for (int Deviation = 0; Deviation < 40; Deviation += 5)
                    {
                        pen.Color = Color.Black;
                        gfx.DrawLine(pen, xA+Deviation, yA+Deviation, xB+Deviation, yB+Deviation );
                        gfx.DrawLine(pen, xB+Deviation, yB+Deviation, xC+Deviation, yC+Deviation );
                        gfx.DrawLine(pen, xC+Deviation, yC+Deviation, xD+Deviation, yD+Deviation );
                        gfx.DrawLine(pen, xD+Deviation, yD+Deviation, xA+Deviation, yA+Deviation );
                    }
                    AdvancePoint(ref A);
                    AdvancePoint(ref B);
                    AdvancePoint(ref C);
                    AdvancePoint(ref D);
                    xA = A.X + Convert.ToInt32(A.Radius * Math.Cos(A.Direction));
                    yA = A.Y - Convert.ToInt32(A.Radius * Math.Sin(A.Direction));
                    xB = B.X + Convert.ToInt32(B.Radius * Math.Cos(B.Direction));
                    yB = B.Y - Convert.ToInt32(B.Radius * Math.Sin(B.Direction));
                    xC = C.X + Convert.ToInt32(C.Radius * Math.Cos(C.Direction));
                    yC = C.Y - Convert.ToInt32(C.Radius * Math.Sin(C.Direction));
                    xD = D.X + Convert.ToInt32(D.Radius * Math.Cos(D.Direction));
                    yD = D.Y - Convert.ToInt32(D.Radius * Math.Sin(D.Direction));

                    for (int Deviation = 0; Deviation < 40; Deviation+=5)
                    {
                        pen.Color = Color.Green;
                        gfx.DrawLine(pen, xA + Deviation, yA + Deviation, xB + Deviation, yB + Deviation);
                        gfx.DrawLine(pen, xB + Deviation, yB + Deviation, xC + Deviation, yC + Deviation);
                        gfx.DrawLine(pen, xC + Deviation, yC + Deviation, xD + Deviation, yD + Deviation);
                        gfx.DrawLine(pen, xD + Deviation, yD + Deviation, xA + Deviation, yA + Deviation);
                    }
                    //Thread.Sleep(7);
                    //AdvancePoint(ref A);
                }
                if (Mode == 2)
                {
                    if (!ComputedEnvVariable)
                    {
                        gfx.Clear(Color.Black);
                        xMax = xMax - 3 * (Width / 2);
                        yMax = yMax - 3 * (Height / 2);
                        xMin = xMin - Width / 2;
                        yMin = yMin - Height / 2;
                        ComputedEnvVariable = true;
                    }
                       
                        AdvancePoint(ref A);
                        gfx.FillRectangle(blackBrush, xA + Width / 2, yA + Height / 2, Width, Height);
                        xA = A.X + Convert.ToInt32(A.Radius * Math.Cos(A.Direction));
                        yA = A.Y - Convert.ToInt32(A.Radius * Math.Sin(A.Direction));
                        gfx.DrawImage(TargetImage, xA + Width / 2, yA + Height / 2);
                       Thread.Sleep(7);
                    
                }
                if (Mode == 4)
                {
                    if (!ComputedEnvVariable)
                    {
                        gfx.Clear(Color.Black);
                        xMax = 233;
                        yMax = 320;
                        xMin = 0;
                        yMin = 0;
                        yMin = 10;
                        yMax = yMax - 20;

                        B.Y = 10;
                        C.Y = yMax+14;
                        ComputedEnvVariable = true;
                    }

                    if (SideHit == 2) // Top paddle, point B
                    {
                       // gfx.FillRectangle(blueBrush, 120 + 7 / 2, 160 + 7 / 2, 7, 7);
                        //gfx.FillRectangle(blackBrush, B.X + 7 / 2, B.Y + 7 / 2, 7, 7);
                        IntermediaryMemoryValue = A.X + Convert.ToInt32(A.MaxRadius * Math.Cos(A.Direction));
                        if (B.X != IntermediaryMemoryValue)
                        {
                            gfx.FillRectangle(blackBrush, B.X - 50 / 2, B.Y - 7 / 2, 50, 7);
                            if (B.X < IntermediaryMemoryValue)
                            {
                                B.X ++;
                            }
                            if (B.X > IntermediaryMemoryValue)
                            {
                                B.X --;
                            }
                            gfx.FillRectangle(whiteBrush, B.X - 50 / 2, B.Y - 7 / 2, 50, 7);
                            
                        }
                        }
                        
                    if (SideHit == 4) // Bottom paddle, point C
                    {
                       // gfx.FillRectangle(redBrush, 120 + 7 / 2, 160 + 7 / 2, 7, 7);
                        IntermediaryMemoryValue = A.X + Convert.ToInt32(A.MaxRadius * Math.Cos(A.Direction));
                        if (C.X != IntermediaryMemoryValue)
                        {
                            gfx.FillRectangle(blackBrush, C.X - 50 / 2, C.Y - 7 / 2, 50, 7);
                            if (C.X < IntermediaryMemoryValue)
                            {
                                C.X ++;
                            }
                            if (C.X > IntermediaryMemoryValue)
                            {
                                C.X --;
                            }
                            gfx.FillRectangle(whiteBrush, C.X - 50 / 2, C.Y - 7 / 2, 50, 7);
                        }
                        
                    }
                    AdvancePoint(ref A);
                    //if (!AdvancePoint(ref A) && (SideHit%2!=1) && ((B.X != IntermediaryMemoryValue) || (C.X != IntermediaryMemoryValue)))
                   // {
                     //   A.X = 120;
                   //     A.Y = 160;
                   //     A.Direction = 3 * Math.PI / 2;
                    //    A.Radius = 0;
                 //       A.ComputedTargetQuadrant = false;
                   //     A.TargetQuardant = 0;
                   //     A.MaxRadius = 0;
                  //  }
                    gfx.FillRectangle(blackBrush, xA + 7 / 2, yA + 7 / 2, 7, 7);
                    xA = A.X + Convert.ToInt32(A.Radius * Math.Cos(A.Direction));
                    yA = A.Y - Convert.ToInt32(A.Radius * Math.Sin(A.Direction));
                    gfx.FillRectangle(whiteBrush, xA + 7 / 2, yA + 7 / 2, 7, 7);
                    Thread.Sleep(7);
                }
                if (Mode == 3)
                {
                    if (!ComputedEnvVariable)
                    {
                        gfx.Clear(Color.Black);
                        ComputedEnvVariable = true;
                    }
                    //pen.Color = Color.Black;
                    gfx.DrawLine(pen, xA, yA, xB, yB);
                    gfx.DrawLine(pen, xB, yB, xC, yC);
                    gfx.DrawLine(pen, xC, yC, xD, yD);
                    gfx.DrawLine(pen, xD, yD, xA, yA);

                        pen.Color = Color.Black;
                        gfx.DrawLine(pen, xA , yA , xB , yB );
                        gfx.DrawLine(pen, xB , yB , xC , yC );
                        gfx.DrawLine(pen, xC , yC , xD , yD );
                        gfx.DrawLine(pen, xD , yD , xA , yA );
                 
                    AdvancePoint(ref A);
                    AdvancePoint(ref B);
                    AdvancePoint(ref C);
                    AdvancePoint(ref D);
                    xA = A.X + Convert.ToInt32(A.Radius * Math.Cos(A.Direction));
                    yA = A.Y - Convert.ToInt32(A.Radius * Math.Sin(A.Direction));
                    xB = B.X + Convert.ToInt32(B.Radius * Math.Cos(B.Direction));
                    yB = B.Y - Convert.ToInt32(B.Radius * Math.Sin(B.Direction));
                    xC = C.X + Convert.ToInt32(C.Radius * Math.Cos(C.Direction));
                    yC = C.Y - Convert.ToInt32(C.Radius * Math.Sin(C.Direction));
                    xD = D.X + Convert.ToInt32(D.Radius * Math.Cos(D.Direction));
                    yD = D.Y - Convert.ToInt32(D.Radius * Math.Sin(D.Direction));
                    pen.Color = Color.Blue;
                    gfx.DrawLine(pen, xA, yA, xB, yB);
                    gfx.DrawLine(pen, xB, yB, xC, yC);
                    gfx.DrawLine(pen, xC, yC, xD, yD);
                    gfx.DrawLine(pen, xD, yD, xA, yA);
                    //Thread.Sleep(7);
                    //AdvancePoint(ref A);
                }
                if (pictureBox2.InvokeRequired)
                {
                    pictureBox2.Invoke((Action)(() => pictureBox2.Image = Canvas));
                    //label1.Invoke((Action)(() => label1.Text = Convert.ToString(A.X) + " " + Convert.ToString(A.Y) + " " + Convert.ToString(A.X + Convert.ToInt32(A.Radius * Math.Cos(A.Direction))) + " " + Convert.ToString(A.Y - Convert.ToInt32(A.Radius * Math.Sin(A.Direction)))));
                }
            }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1.ScreensaverRunning = false;
            ScreenSaverUpdate.Abort();
            this.Close();
        }
    }
}
