using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; } 
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string Name, Employer EmployerName, Location EmployerLocation, PositionType JobType, CoreCompetency JobCoreCompetency)
        {
            this.Name = Name;
            this.EmployerName = EmployerName;
            this.EmployerLocation = EmployerLocation;
            this.JobType = JobType;
            this.JobCoreCompetency = JobCoreCompetency;
        }
        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id &&
                   Name == job.Name &&
                   EqualityComparer<Employer>.Default.Equals(EmployerName, job.EmployerName) &&
                   EqualityComparer<Location>.Default.Equals(EmployerLocation, job.EmployerLocation) &&
                   EqualityComparer<PositionType>.Default.Equals(JobType, job.JobType) &&
                   EqualityComparer<CoreCompetency>.Default.Equals(JobCoreCompetency, job.JobCoreCompetency);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }
        //Added ToString
        public override string ToString()
        {
            if (Name == "")
            {
                Name = "Data not available";
            }
            if (EmployerName.Value == "" || EmployerName.Value == null)
            {
                EmployerName.Value = "Data not available";
            }

            if (EmployerLocation.Value == "" || EmployerLocation.Value == null)
            {
                EmployerLocation.Value = "Data not available";
            }

            if (JobType.Value == "" || JobType.Value == null)
            {
                JobType.Value = "Data not available";
            }

#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
            if (JobCoreCompetency.Value == "" || JobCoreCompetency == null)
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
            {
                JobCoreCompetency.Value = "Data not available";
            }


            string output = $"\nID: {Id}\nName: {Name}\n Employer: {EmployerName.Value}\n Location: {EmployerLocation.Value}\n Position Type: {JobType.Value}\n Core Competency: {JobCoreCompetency.Value}\n";
            return output;
        }
    }
}
