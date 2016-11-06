using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RS1
{
    public partial class Form1 : Form
    {
        private int n = 4, ob = 0;
        string StringLane;
        public Form1()
        {
            InitializeComponent();
        }
        public void TextConvert()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j <=  n; j++) 
                {
                    StringLane += Manager.iRoad.GetLocation(i, j).ToString();
                }
                StringLane += Environment.NewLine;
            }
            this.output.Text = StringLane;
        }
        public void FirstLaunch()
         {
            StringLane = "";
            Manager.iRoad.Create(n);
            Manager.iCar.Create();
            TextConvert();
        }
        public void TestCase1()
        {
            StringLane = "";
            Manager.iRoad.Create(n);
            Manager.iCar.Create();
            Manager.iRoad.SetLocation(5, 3, '`');
            Manager.iRoad.SetLocation(5, 5, '`');
            Manager.iRoad.SetLocation(3, 1, '.');
            Manager.iRoad.SetLocation(3, 3, '`');
            Manager.iRoad.SetLocation(2, 1, '.');
            Manager.iRoad.SetLocation(2, 3, '`');
            Manager.iRoad.SetLocation(2, 5, '.');
            Manager.iRoad.SetLocation(2, 7, '`');
            Manager.iRoad.SetLocation(1, 7, '.');
            Manager.iRoad.SetLocation(0, 5, '.');
            Manager.iRoad.SetLocation(0, 3, '.');
            TextConvert();
        }
        private void output_TextChanged(object sender, EventArgs e)
        {
        }

        private void input_button_Click(object sender, EventArgs e)
        {
            FirstLaunch();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            n = 4;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            n = 6;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            n = 8;
        }

        private void iAdd_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            int.TryParse(locX.Text, out x);
            int.TryParse(locY.Text, out y);
            if (x != 5 && (y%2)!= 0)
            {
                Obstacle A = new Obstacle(x, y, ob);
                StringLane = "";
                TextConvert();
            }
            if(x==0 && y == 0)
            {
                TestCase1();
            }
        }

        private void iStart_Click(object sender, EventArgs e) //ignition
        {
            ThreadPool.QueueUserWorkItem(Ignite);
        }
        private async void Ignite(object state) //movement code. Starts at ext bottom-left.
        {
            int i = 5, j = 1;
            try {
                while ( i != 0 || j < n - 1)  //FYI: Fake = i and j (used to control loop), Actual = CarLocX and CarLocY
                {
                    if (Manager.iRoad.GetLocation(i - 1, j) == ' ' || Manager.iRoad.GetLocation(i - 1, j) == '`' || Manager.iRoad.GetLocation(i - 1, j) == ':') //goes forwards whenever possible
                    {
                        oThrottle.Text= "Accelerate";
                        await PutTaskDelay();
                        StringLane = "";
                        Manager.iCar.Accelerate(); //actual accelerate
                        TextConvert();
                        i--; //fake accelerate
                        oThrottle.Text = "";
                        continue;
                    }
                    else if ( j <= n - 2 && ( Manager.iRoad.GetLocation(i - 1, j + 2) == ' ' || Manager.iRoad.GetLocation(i - 1, j + 2) == '`' || Manager.iRoad.GetLocation(i - 1, j + 2) == ':') )
                    {
                        oThrottle.Text = "Accelerate";
                        oIndicator.Text = "Right";
                        await PutTaskDelay();
                        StringLane = "";
                        Manager.iCar.AccelerateRight(); //actual accelerate and right turn
                        TextConvert();
                        i--; //fake accelerate
                        j = j + 2; //obvious fake right turn.
                        oIndicator.Text = "";
                        oThrottle.Text = "";
                        continue;
                    }
                    else if ( j >= 3 && ( Manager.iRoad.GetLocation(i - 1, j - 2) == ' ' || Manager.iRoad.GetLocation(i - 1, j - 2) == '`' || Manager.iRoad.GetLocation(i - 1, j - 2) == ':') )
                    {
                        oThrottle.Text = "Accelerate";
                        oIndicator.Text = "Left";
                        await PutTaskDelay();
                        StringLane = "";
                        Manager.iCar.AccelerateLeft(); //actual accelerate and left turn
                        TextConvert();
                        i--;//fake accelerate
                        j = j - 2;//obvious fake left turn.
                        oIndicator.Text = "";
                        oThrottle.Text = "";
                        continue;
                    }
                    else if ( j <= n - 2 && ( Manager.iRoad.GetLocation(i, j + 2) == ' ' || Manager.iRoad.GetLocation(i - 1, j + 2) == '`' || Manager.iRoad.GetLocation(i - 1, j + 2) == ':') )
                    {
                        oBrake.Text = "Engaged";
                        oThrottle.Text = "Decelerate";
                        oIndicator.Text = "Right";
                        await PutTaskDelay();
                        StringLane = "";
                        Manager.iCar.TurnRight(); //actual right turn
                        TextConvert();
                        j = j + 2; //obvious fake right turn.
                        oIndicator.Text = "";
                        oBrake.Text = "";
                        oThrottle.Text = "";
                        continue;
                    }
                    else if ( j >= 3 && ( Manager.iRoad.GetLocation(i - 1, j - 2) == ' ' || Manager.iRoad.GetLocation(i - 1, j - 2) == '`' || Manager.iRoad.GetLocation(i - 1, j - 2) == ':') )
                    {
                        oBrake.Text = "Engaged";
                        oThrottle.Text = "Decelerate";
                        oIndicator.Text = "Left";
                        await PutTaskDelay();
                        StringLane = "";
                        Manager.iCar.TurnLeft(); //actual left turn
                        TextConvert();
                        j = j - 2;//obvious fake left turn.
                        oIndicator.Text = "";
                        oBrake.Text = "";
                        oThrottle.Text = "";
                        continue;
                    }
                    else
                    {
                        MessageBox.Show("Traverse Fail. Road Blocked");
                        break;
                    }
                }
            }
            catch(IndexOutOfRangeException)
            {
                if(j >= 1 && j <= n - 1)
                {
                    MessageBox.Show("Arrived at Destination!");
                }
                else
                MessageBox.Show("Array Out of Range. Restart with different pattern.");
            }
        }
        static async Task PutTaskDelay() //method to Delay for 1000ms
        {
            await Task.Delay(1000);
        }

        private void oType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //0 -> Bump
            //1 -> Car
            //3 -> Pothole
            ob = oType.SelectedIndex;
            //MessageBox.Show("meow"+ob);
        }
    }
}
