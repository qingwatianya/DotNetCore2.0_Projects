using JobSchedule.FlashItemOffline;
using JobSchedule.VoidUnPaidOrderJob;
using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace JobSchedule
{
    public partial class JobManager : ServiceBase
    {
        public JobManager()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
           

            //把作业，触发器加入调度器
            ScheduleBase.AddSchedule(new AutoVoidUnPaidOrderService());
            
            //ScheduleBase.AddSchedule(new FlashItemOfflineJobService());

            //开启调度器
            ScheduleBase.Scheduler.Start();
        }

        protected override void OnStop()
        {
            ScheduleBase.Scheduler.Shutdown(true);
        }
    }
}
