using System;
using System.Windows.Forms;

namespace RS1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Form1 Alpha = new Form1();
            //Application.Run(Alpha);
            Application.Run(new Form1());
        }
    }
    public class Road
    {
        private char[,] lanes;
        public void Create(int MaxLaneLength)
        {
            lanes = new char[6, 9];
            for (int Row = 0; Row < 6; Row++)
            {
                for (int Column = 0; Column <= MaxLaneLength; Column++)
                {
                    if (Column == 0 || (Column % 2 == 0))
                    {
                        if (Column == 0)
                        {
                            lanes[Row, Column] = ']';
                        }
                        else if (Column == MaxLaneLength)
                        {
                            lanes[Row, Column] = '[';
                        }
                        else
                        {
                            lanes[Row, Column] = '|';
                        }
                    }
                    else
                    {
                        lanes[Row, Column] = ' ';
                    }
                }
            }
        }
        public char GetLocation(int row, int column)
        {
            return lanes[row, column];
        }
        public void SetLocation(int row, int column)
        {
            lanes[row, column] = '"';  
        }
        public void SetLocation(int row,int column,char value)
        {
            lanes[row, column] = value;
        }
        public int Length(bool option) //True for RowLength, False for Column.
        {
            if (option)
                return lanes.GetLength(0)-1;
            else
                return lanes.GetLength(1)-1;
        }
    }
    public class Car
    {
        private int CarLocX, CarLocY;
        int RLow;
        char Original;
        public void SetLocation(int value, bool option) //true for ROW, False for Column
        {
            if (option)
                CarLocX = value;
            else
                CarLocY = value;
        }
        public void SetLocation(int row, int column)
        {
            CarLocX = row;
            CarLocY = column;
        }
        public void Create()
        {
            RLow = 5;
            Original = ' ';
            RLow = Manager.iRoad.Length(true);
            CarLocX = RLow;
            CarLocY = 1;
            Manager.iRoad.SetLocation(CarLocX, CarLocY);
        }
        public void Accelerate() //Row for up and down. Coloumn for left and right
        {
            Manager.iRoad.SetLocation(CarLocX, CarLocY, Original); //replace with the original
            Original = Manager.iRoad.GetLocation(CarLocX - 1, CarLocY); //copy the above box 
            //moves up. Index decreases.
            Manager.iRoad.SetLocation(--CarLocX, CarLocY);
        }
        public void AccelerateLeft() //acc and turn
        {
            Manager.iRoad.SetLocation(CarLocX, CarLocY, Original);
            Original = Manager.iRoad.GetLocation(CarLocX - 1, CarLocY - 2);
            //moves left. Row Index decreasing
            CarLocY = CarLocY - 2;
            Manager.iRoad.SetLocation(--CarLocX, CarLocY);
        }
        public void AccelerateRight() //acc and turn
        {
            Manager.iRoad.SetLocation(CarLocX, CarLocY, Original);
            Original = Manager.iRoad.GetLocation(CarLocX - 1, CarLocY + 2);
            //moves right. Row Index increasing
            CarLocY = CarLocY + 2;
            Manager.iRoad.SetLocation(--CarLocX, CarLocY);
        }
        public void TurnLeft()//only turn
        {
            Manager.iRoad.SetLocation(CarLocX, CarLocY, Original);
            Original = Manager.iRoad.GetLocation(CarLocX, CarLocY - 2);
            //moves left. Row Index decreasing
            CarLocY = CarLocY - 2;
            Manager.iRoad.SetLocation(CarLocX, CarLocY);
        }
        public void TurnRight()//only turn
        {
            Manager.iRoad.SetLocation(CarLocX, CarLocY, Original);
            Original = Manager.iRoad.GetLocation(CarLocX, CarLocY + 2);
            //moves right. Row Index increasing
            CarLocY = CarLocY + 2;
            Manager.iRoad.SetLocation(CarLocX, CarLocY);
        }
    }
    public class Obstacle
    {
        public Obstacle(int x, int y, int option)
        {
            switch (option)
            {
                case 0:
                    {
                        Manager.iRoad.SetLocation(x, y, '`');
                        break;
                    }
                case 1:
                    {
                        Manager.iRoad.SetLocation(x, y, '.');
                        break;
                    }
                case 2:
                    {
                        Manager.iRoad.SetLocation(x, y, ':');
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Invalid Input", "Error");
                        break;
                    }
            }
        }
    }
    public static class Manager
    {
        private static readonly Road _Road = new Road();
        private static readonly Car _Car = new Car();
        public static Road iRoad
        {
            get { return _Road; }
        }
        public static Car iCar
        {
            get { return _Car; }
        }
    }
}

