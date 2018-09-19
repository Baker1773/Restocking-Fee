using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestockingFee
{
    
    class PasteValidator
    {
        private bool running = true;
        private const int TimeLimit = 500;
        private Stopwatch time = new Stopwatch();
        private bool success;
        private bool hasInput = false;
        private Button pasteButton;

        public PasteValidator(Button pasteButton)
        {
            this.pasteButton = pasteButton;
        }

        public void Start()
        {

            while (running)
            {
                if(hasInput)
                    pasteButton.BackColor = ColorGenerator.GenerateColor(time.ElapsedMilliseconds, TimeLimit, success);
                Thread.Sleep(20);
            }
        }

        public void ValidateInput(bool success)
        {
            hasInput = true;
            this.success = success;
            time.Restart();
        }

        public void Stop()
        {
            running = false;
        }
    }
}
