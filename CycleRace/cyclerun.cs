﻿using System;
using System.Windows.Forms;

namespace RacetrackSimulator
{
    public class CycleRun
    {
        public int place;
        public Random Rand;
        public int StartLine;
        public int Length;
        public PictureBox MyPictureBox = null;

        public void StartlinePosition()
        {
            place = 0;
            MyPictureBox.Left = StartLine;
        }
        public bool CycleRunning()
        {
            var cycleing = Rand.Next(1, 22);
            place += cycleing;
            MyPictureBox.Left = StartLine + place;

            if (MyPictureBox.Left >= Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}