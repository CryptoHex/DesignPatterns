using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FactoryPattern.Machines
{
    public class MachineFactory
    {
        private Dictionary<string, Type> machines;

        public MachineFactory()
        {
            GetAllMachines();
        }

        public  IMachine CreateInstance(string description)
        {
            Type machineType = GetMachineType(description);

            IMachine machine =(IMachine) Activator.CreateInstance(machineType);

            return machine;
        }

        private  Type GetMachineType(string description)
        {
            if(machines.ContainsKey(description))
            {
                return machines[description];
            }
            return typeof(UnknownMachine);           
        }

        private  void GetAllMachines()
        {
            machines = new Dictionary<string, Type>();
            var Types = Assembly.GetExecutingAssembly().GetTypes()
                            .Where(t => t.GetInterface(typeof(IMachine).Name) != null)
                            .ToList();

            foreach(var type in Types)
            {
                machines.Add(type.Name.ToLower(), type);
            }
        }

    }
}
