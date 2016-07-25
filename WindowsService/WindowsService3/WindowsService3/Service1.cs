using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService3
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
            InitializeScheduler();
        }

        private void InitializeScheduler()
        {

            Scheduler scd = new Scheduler();
            scd.start();
        }

        protected override void OnStart(string[] args)
        {
           // FileWatcher f = new FileWatcher();
           // sampleFileCreation();
        }
        public void onDebug()
        {
            OnStart(null);
        }
        private void sampleFileCreation()
        {
         
            System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "OnStart.txt");
        }
        protected override void OnStop()
        {
              System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "onStop.txt");
        }
    }
}
