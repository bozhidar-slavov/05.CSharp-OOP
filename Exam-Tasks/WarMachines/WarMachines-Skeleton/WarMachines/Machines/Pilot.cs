namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Interfaces;
    using Common;

    public class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Pilot name cannot be null!");
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            Validator.CheckIfNull(machine, "Null machine cannot be added to pilot!");
            this.machines.Add(machine);
        }

        public string Report()
        {
            var sortedMachines = this.machines.OrderBy(m => m.HealthPoints).ThenBy(m => m.Name);

            var result = new StringBuilder();

            var noMachineMaybe = this.machines.Count > 0 ? this.machines.Count.ToString() : "no";
            var pluralMaybe = this.machines.Count == 1 ? "machine" : "machines";

            result.AppendLine(string.Format("{0} - {1} {2}", this.Name, noMachineMaybe, pluralMaybe));
            foreach (var machine in sortedMachines)
            {
                result.AppendLine(machine.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
