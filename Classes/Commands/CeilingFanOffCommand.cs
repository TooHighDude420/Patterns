using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanOffCommand : Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            this.prevSpeed = this.ceilingFan.GetSpeed();
            this.ceilingFan.Off();
        }

        public void Undo()
        {
            switch (this.prevSpeed)
            {
                case 0:
                    this.Execute();
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
