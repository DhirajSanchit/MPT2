using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoRemoteControl
{
    public partial class RemoteControlForm : Form
    {
        private SerialMessenger serialMessenger;
        private Timer readMessageTimer;
        // TODO: Below fill in the actual Arduino COM port.
        private string port = "COM5";
        private int speed = 9600;

        public RemoteControlForm()
        {
            InitializeComponent();

            MessageBuilder messageBuilder = new MessageBuilder();
            serialMessenger = new SerialMessenger(port, speed, messageBuilder);


            MessageBox.Show("Ready, Set, Go!", "Get Ready!", MessageBoxButtons.OK);

            readMessageTimer = new Timer();
            readMessageTimer.Interval = 500;
            readMessageTimer.Tick += new EventHandler(ReadMessageTimer_Tick);

                            MessageBox.Show("Ready Set go!", "Get Ready", MessageBoxButtons.OK);

            try
            {
                serialMessenger.Connect();
                readMessageTimer.Enabled = true;
                Console.WriteLine("Connected!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


            Console.WriteLine();
             
        }

 
        private void ReadMessageTimer_Tick(object sender, EventArgs e)
        {
            string message = serialMessenger.ReadMessages();
            if (message != null && message != "")
            {
                processReceivedMessage(message);
            }
        }

        /// <summary>
        /// handle received messages
        /// </summary>
        /// <param name="message"></param>
        private void processReceivedMessage(string message)
        {
            // First trim whitespace characters like a trailing '\r'.
            // This is needed because the Arduino Serial.println adds \r\n.
            // '\n' will be removed because this is used as the message separation character,
            // but the '\r' must also be removed, otherwise comparing the message strings will not work.
            message = message.Trim();
            // Add message to the listBox.
            listBoxHistory.Items.Add(message);
       //     MessageBox.Show(message, "result", MessageBoxButtons.OK);
            // TODO: Below fill in your message handling.

 

//            if (message != "GO!")
//            {
//                MessageBox.Show("Ready Set go!", "Get Ready", MessageBoxButtons.OK);
//            }
        }
 
        private void RemoteControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            disconnect();
        }

        private void disconnect()
        {
            try
            {
                readMessageTimer.Enabled = false;
                serialMessenger.Disconnect();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        } 

        private void RemoteControlForm_Load(object sender, EventArgs e)
        {
            
        } 
    }
}
