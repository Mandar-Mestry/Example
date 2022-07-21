using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    // Inheritance
    public class Youtuber : Creator
    {
        public override void Create()
        {
            if (base.Creativity >= 50 && base.Energy >=50)
            {
                this.BrainstormVideoIdeas();
                this.Script();
                this.VideoTape();
                this.EditVideo();
                this.RenderVideo();
            }
            else
            {
                throw new Exception("Cannot create a video. Out of ideas or tired");
            }
        }
        
        //Encapsulation
        private void BrainstormVideoIdeas()
        {
            base.Creativity -= 5;
            base.Energy -= 5;
            Console.WriteLine("Brainstorming Video Ideas....");
        }

        private void Script()
        {
            base.Creativity -= 5;
            base.Energy -= 5;
            Console.WriteLine("Creating a video script....");
        }

        private void VideoTape()
        {
            base.Creativity -= 1;
            base.Energy -= 10;
            Console.WriteLine("Videotaping...");
        }

        private void EditVideo()
        {
            base.Creativity -= 5;
            base.Energy -= 5;
            Console.WriteLine("Editing the Video....");
        }

        private void RenderVideo()
        {
            base.Creativity -= 1;
            base.Energy -= 1;
            Console.WriteLine("Rendering the Video...");
        }
    }
}
