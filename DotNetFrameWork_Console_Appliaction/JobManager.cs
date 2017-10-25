using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameWork_Console_Appliaction
{
    public partial class JobManager : ServiceBase
    {
        public JobManager()
        {
            InitializeComponent();
        }

        public JobManager(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }




        protected override void OnStart(string[] args)
        {
            base.OnStart(args);
        }

        protected override void OnStop()
        {
            base.OnStop();
        }


       
    }
}
