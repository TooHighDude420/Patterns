namespace FacadePattern
{
    internal class HomeTheaterFacade
    {
        public Amplifier amp;
        public CdPlayer cdPlayer;
        public DvdPlayer dvdPlayer;
        public PopcornPopper popcornPopper;
        public Projector projector;
        public Screen screen;
        public TheaterLights lights;
        public Tuner tuner;

        public HomeTheaterFacade(Amplifier amp, CdPlayer cdPlayer, DvdPlayer dvdPlayer, PopcornPopper popcornPopper, Projector projector, Screen screen, TheaterLights lights, Tuner tuner)
        {
            this.amp = amp;
            this.cdPlayer = cdPlayer;
            this.dvdPlayer = dvdPlayer;
            this.popcornPopper = popcornPopper;
            this.projector = projector;
            this.screen = screen;
            this.lights = lights;
            this.tuner = tuner;
        }

        public void WatchMovie(string name)
        {
            popcornPopper.On();
            popcornPopper.Pop();

            lights.Dim(10);

            screen.Down();

            projector.On();
            projector.SetInput(dvdPlayer);
            projector.WideScreenMode();

            amp.On();
            amp.SetDvd(dvdPlayer);
            amp.SetSurroundSound();
            amp.SetVolume(5);

            dvdPlayer.On();
            dvdPlayer.Play(name);
        }

        public void EndMovie()
        {
            popcornPopper.Off();
            
            screen.Up();

            projector.Off();
            
            amp.Off();
            
            dvdPlayer.Off();
        }

        public void ListenToCd()
        {
            throw new NotImplementedException();
        }

        public void EndCd()
        {
            throw new NotImplementedException();
        }

        public void ListenToRadio()
        {
            throw new NotImplementedException();
        }

        public void EndRadio()
        {
            throw new NotImplementedException();
        }


    }
}