using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanMediumCommand : Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            int curSpeed = this.ceilingFan.GetSpeed();
            this.prevSpeed = curSpeed;
            this.ceilingFan.Medium();
        }

        public void Undo()
        {
            switch (this.prevSpeed)
            {
                case 0:
                    this.ceilingFan.Off();
                    break;
                case 1:
                    this.ceilingFan.Low();
                    break;
                case 2:
                    this.ceilingFan.Medium();
                    break;
                case 3:
                    this.ceilingFan.High();
                    break;
            }

        }
    }
}
