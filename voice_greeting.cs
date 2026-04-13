using System;
using System.Media;

namespace Prog6221_POE
{
    public class voice_greeting
    {
        public voice_greeting()
        { //start of constructor

            //call the greet method
            greet();

        } //end of constructor

        //method to play the voice
        private void greet()
        { //start of metho

            //auto get the path of the voice record
            string paths = AppDomain.CurrentDomain.BaseDirectory;

            //then rename the path
            string fullpath = paths.Replace(@"bin\Debug\", "POE_voice.wav");

            //load the audio, then play the audio after instance
            SoundPlayer voice_play = new SoundPlayer(fullpath);
            //load the audio
            voice_play.Load();
            //then play the audio
            voice_play.Play();

        } //end of method
    }
}