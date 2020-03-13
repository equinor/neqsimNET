using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using neqsim.thermo.system;
using neqsim.thermodynamicOperations;
using System.Diagnostics;

namespace NeqSimVS
{
    class Benchmark
    {

        public void runBenchmark()
        {
            SystemInterface testSystem = new SystemSrkEos(303.15, 35.01325);
            ThermodynamicOperations testOps = new ThermodynamicOperations(testSystem);

            testSystem.addComponent("nitrogen", 0.0028941);
            testSystem.addComponent("CO2", 0.054069291);
            testSystem.addComponent("methane", 0.730570915);
            testSystem.addComponent("ethane", 0.109004002);
            testSystem.addComponent("propane", 0.061518891);
            testSystem.addComponent("n-butane", 0.0164998);
            testSystem.addComponent("i-butane", 0.006585);
            testSystem.addComponent("n-pentane", 0.005953);
            testSystem.addComponent("i-pentane", 0.0040184);
            testSystem.addTBPfraction("C6", 0.6178399, 86.17801 / 1000.0, 0.6639999);
            testSystem.addComponent("water", 0.27082);

            testSystem.createDatabase(true);
            testSystem.setMixingRule(2);
            testSystem.setMultiPhaseCheck(true);

            Console.Write("start benchmark TPflash......");

            testSystem.init(0);
            Stopwatch sw = new Stopwatch();

            sw.Start();
            testOps.TPflash();
            for (int i = 0; i < 5000; i++)
            {
                testOps.TPflash();
            }

            sw.Stop();

            Console.WriteLine("Elapsed={0}", sw.Elapsed);
        }
    }
}
