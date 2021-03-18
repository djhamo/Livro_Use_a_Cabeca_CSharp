using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveSystem
{

    class Queen : Bee
    {
        public Queen(Worker[] tworkers)
            : base (275)
        {
            workers = tworkers;
        }
        private Worker[] workers;
        private int shiftNumber = 0;

        public bool AssingWork(string newJob, int newShit) 
        {
            foreach (Worker bee in workers)
            {
                if (bee.DoThisJob(newJob, newShit))
                    return true;              
            }
            return false;

        }
        public string WorkNextShift()
        {
            shiftNumber++;
            double honeyConsumption = 0.0;
            string report = "Report for shift # " + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                    report += "Worker #" + (i + 1) + " finished the job\r\n";
                if(String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Worker #" + (i + 1) + " is not working\r\n";
                else
                    if (workers[i].ShiftsLeft > 0)
                        report += "Worker #" + (i + 1) + " is doing " +workers[i].CurrentJob + " for " + workers[i].ShiftsLeft + " more shifts\r\n";
                    else
                        report += "Worker #" + (i + 1) + " will be done with " + workers[i].CurrentJob + " after this shift\r\n";

                honeyConsumption += workers[i].GetHoneyConsumption();
            }
            honeyConsumption += this.GetHoneyConsumption();
            report += "Total honey consumption is $" + honeyConsumption.ToString() + "\r\n";

            return report;
        }

        public override double GetHoneyConsumption()
        {
            double consumption = 0.0;
            double largestWorkerConsumption = 0.0;
            int workersDoingJobs = 0;
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].GetHoneyConsumption() > largestWorkerConsumption)
                    largestWorkerConsumption = workers[i].GetHoneyConsumption();
                if (workers[i].ShiftsLeft > 0)
                    workersDoingJobs++;
            }
            consumption += largestWorkerConsumption;
            if (workersDoingJobs >= 3)
                consumption += 30;
            else
                consumption += 20;

            return consumption;
        }
    }
}
