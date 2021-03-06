﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace Kitbox
{
    public partial class Tests : Form
    {
        public Tests()
        {
            InitializeComponent();
        }
        //TestVisualPart
        public void TestVisualPart(VisualPart part)
        {
            part.ChangeScaling(screen.Size);
            screen.Controls.Add(part.Display()["front"]);
            screen.Visible = true;
        }
        //TestKnop
        public Knop TestKnop(int x, int y, Color color, string reference = "knop")
        {
            Knop myknop = new Knop();
            myknop.Location = new Point3D(0, 0, 0);
            myknop.Dimensions = new Size3D(x, y, 0);
            myknop.Color = color;
            myknop.Reference = reference;
            myknop.ConstructVisualPart();
            return myknop;
        }
        //TestDoor
        public Door TestDoor(int x, int y, Color color, string reference = "knop")
        {
            Door mydoor = new Door();
            mydoor.Location = new Point3D(0, 0, 0);
            mydoor.Dimensions = new Size3D(x, y, 0);
            mydoor.Color = color;
            mydoor.SetKnop(TestKnop(6, 6, Color.Black), 4);
            mydoor.Reference = "door";
            mydoor.ConstructVisualPart();
            return mydoor;
        }
        //TestNogging
        public Panel TestPanel(int x, int y, Color color, string reference = "panel")
        {
            Panel mypanel = new Panel();
            mypanel.Location = new Point3D(0, 0, 0);
            mypanel.Dimensions = new Size3D(x, y , 0);
            mypanel.Color = color;
            mypanel.Reference = "panel";
            mypanel.ConstructVisualPart();
            return mypanel;
        }
        //TestAngle
        public Angle TestAngle(int x, int y, Color color, string reference = "angle")
        {
            Angle myangle = new Angle();
            myangle.Location = new Point3D(0, 0, 0);
            myangle.Dimensions = new Size3D(x, y, 0);
            myangle.Color = color;
            myangle.Reference = reference;
            myangle.ConstructVisualPart();
            return myangle;
        }
        //TestBox
        public Box TestBox(int l, int h, int p, string reference = "box")
        {
            Box mybox = new Box(new Size3D(120, 36, 42));
            return mybox;
        }

        private void compute_Click(object sender, EventArgs e)
        {
            Invisible();
            switch (test_input.Text)
            {
                case "vp_door"://VisualPart_Door
                    TestVisualPart(TestDoor(62, 32, Color.Beige).Visual_part);
                    break;
                case "vp_knop"://VisualPart_Knop
                    TestVisualPart(TestKnop(6, 6, Color.Black).Visual_part);
                    break;
                case "vp_panel"://VisualPart_Panel
                    TestVisualPart(TestPanel(120, 2, Color.Tan).Visual_part);
                    break;
                case "vp_angle"://VisualPart_Angle
                    TestVisualPart(TestAngle(2, 108, Color.Black).Visual_part);
                    break;
                case "vp_box"://VisualPart_Box
                    TestVisualPart(TestBox(120, 36, 42).Visual_part);
                    break;
            }
        }

        private void Invisible()
        {
            screen.Controls.Clear();
            screen.Visible = false;
        }
    }
}
