using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveSystem
{
    class Worker : Bee
    {
        public Worker(string[] jobs, double weight)
            : base (weight)
        {
            jobsICanDo = jobs;
        }

        private int shiftsToWork;
        private int shiftsWorked;
        public override int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }
        private string currentJob = "";
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        private string[] jobsICanDo;


        public bool DoThisJob(string newJob, int newShit)
        {
            if (!String.IsNullOrEmpty(currentJob))
                return false;

            for (int i = 0; i < jobsICanDo.Length; i++)
            {
                if (jobsICanDo[i] == newJob)
                {
                    currentJob = newJob;
                    this.shiftsToWork = newShit;
                    shiftsWorked = 0;
                    return true;
                }
            }
            return false;
        }

        public bool WorkOneShift()
        {
            if (String.IsNullOrEmpty(currentJob))
            {
                return false;
            }
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsToWork = 0;
                shiftsWorked = 0;
                currentJob = "";
                return true;
            }
            else
                return false;
        }
    }
}
