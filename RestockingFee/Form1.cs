using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RestockingFee
{
    public partial class MainWindow : Form
    {
        private static PasteValidator pasteValidator;
        private static Thread pasteValidatorThread;
        public MainWindow()
        {
            InitializeComponent();
            pasteValidator = new PasteValidator(pasteButton);
            pasteValidatorThread = new Thread(pasteValidator.Start);
            pasteValidatorThread.Start();
            this.FormClosed += MyClosedHandler;

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            inputTextbox.Text = "0";
            outputTextBox.Text = "0";
        }
        private void PasteButton_Click(object sender, EventArgs e)
        {
            String clipboardText = System.Windows.Forms.Clipboard.GetText();
            double sourceDouble;
            if (Double.TryParse(clipboardText, out sourceDouble))
            {
                inputTextbox.Text = clipboardText.ToString();
                AttemptToParseInput(clipboardText);
                pasteValidator.ValidateInput(true); 
            }
            else
            {
                pasteValidator.ValidateInput(false); 
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(outputTextBox.Text);
        }

        private void InputTextbox_TextChanged(object sender, EventArgs e)
        {
            AttemptToParseInput(inputTextbox.Text);
        }

        private void InputTextbox_MouseClick(object sender, EventArgs e)
        {
            inputTextbox.SelectAll();
        }

        private void OutputTextbox_MouseClick(object sender, EventArgs e)
        {
            outputTextBox.SelectAll();
        }

        private void AttemptToParseInput(String sourceString)
        {
            double itemPrice;
            if (Double.TryParse(sourceString, out itemPrice))
            {
                outputTextBox.Text = RestockingFeeCalculator.TenPercent(itemPrice).ToString();
            }
        }

        protected void MyClosedHandler(object sender, EventArgs e)
        {
            pasteValidator.Stop();
            pasteValidatorThread.Join();
        }

    }
}
