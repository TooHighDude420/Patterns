using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Command[]> commandLoop = [];
            RemoteControl remoteControl = new();
            Light kitchenLight = new("kitchen");
            Light livingRoomLight = new("Living Room");
            CeilingFan livingroomCeilingFan = new("living room");
            GarageDoor garageDoor = new(new("garage"));
            Stereo stereo = new();

            Command livingLightOn = new LightOnCommand(livingRoomLight);
            Command livingLightOff = new LightOffCommand(livingRoomLight);
            commandLoop.Add([livingLightOn, livingLightOff]);

            // remoteControl.SetCommand(1, livingLightOn, livingLightOff);

            Command kitchenLightOn = new LightOnCommand(kitchenLight);
            Command kitchenLightOff = new LightOffCommand(kitchenLight);
            commandLoop.Add([kitchenLightOn, kitchenLightOff]);
            // remoteControl.SetCommand(2, kitchenLightOn, kitchenLightOff);

            Command ceilingFanOff = new CeilingFanOffCommand(livingroomCeilingFan);
            Command ceilingFanLow = new CeilingFanLowCommand(livingroomCeilingFan);
            Command ceilingFanMedium = new CeilingFanMediumCommand(livingroomCeilingFan);
            Command ceilingFanHigh = new CeilingFanHighCommand(livingroomCeilingFan);
            commandLoop.Add([ceilingFanLow, ceilingFanOff]);
            commandLoop.Add([ceilingFanMedium, ceilingFanOff]);
            commandLoop.Add([ceilingFanHigh, ceilingFanOff]);
            // remoteControl.SetCommand(3, ceilingFanMedium, ceilingFanOff);

            Command garageDoorOpen = new GarageDoorUpCommand(garageDoor);
            Command garageDoorClose = new GarageDoorDownCommand(garageDoor);
            commandLoop.Add([garageDoorOpen, garageDoorClose]);
            // remoteControl.SetCommand(4, garageDoorOpen, garageDoorClose);

            Command stereoOnCd = new StereoOnWithCdCommand(stereo);
            Command stereoOnDvd = new StereoOnWithDvdCommand(stereo);
            Command stereoOnRadio = new StereoOnWithRadioCommand(stereo);
            Command stereoOff = new StereoOffCommand(stereo);
            commandLoop.Add([stereoOnCd, stereoOff]);
            commandLoop.Add([stereoOnDvd, stereoOff]);
            commandLoop.Add([stereoOnRadio, stereoOff]);

            // Test the pressing of Buttons here. Don't forget to test the Undo button
            Random random = new Random();

            foreach (Command[] onOff in commandLoop)
            {
                int undo = random.Next(0, 2);

                remoteControl.SetCommand(1, onOff[0], onOff[1]);
                remoteControl.OnButtonWasPushed(1);

                if (undo == 1)
                {
                    remoteControl.UndoButtonWasPushed();
                }

                else
                {
                    remoteControl.OffButtonWasPushed(1);
                }
            }
        }
    }
}