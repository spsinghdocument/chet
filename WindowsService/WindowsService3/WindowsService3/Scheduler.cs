﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService3
{
    class Scheduler
    {
        System.Timers.Timer otimer = null;
        double interval = 20000;
        public void start()
        {
            otimer = new System.Timers.Timer(interval);
            otimer.AutoReset = true;
            otimer.Enabled = true;
            otimer.Start();
            otimer.Elapsed += new System.Timers.ElapsedEventHandler(_otimerElapsed);
        }
        void _otimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            fileCreation();
        }
        void fileCreation()
        {

             string sfile = @"D:\snr\vido\WINDOW SERVICE\sp.txt";
            string sDate = DateTime.Now.ToString();
            System.IO.StreamWriter oFileWriter = new System.IO.StreamWriter(sfile, true);
            oFileWriter.WriteLine("\n" + sDate);
            oFileWriter.Close();
        }
    }
}
