using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.Globalization;

namespace RS1
{
    partial class Form1
    {
        //ResourceManager stringManager = new ResourceManager("RS1.Resources", Assembly.GetExecutingAssembly()); //WATCH OUT
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.output = new System.Windows.Forms.RichTextBox();
            this.input_button = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.questionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oThrottle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oIndicator = new System.Windows.Forms.TextBox();
            this.oSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.oBrake = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.oHorn = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.oType = new System.Windows.Forms.ComboBox();
            this.LocLabel = new System.Windows.Forms.Label();
            this.locX = new System.Windows.Forms.TextBox();
            this.locY = new System.Windows.Forms.TextBox();
            this.iAdd = new System.Windows.Forms.Button();
            this.iStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.output.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.output.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.output.Location = new System.Drawing.Point(253, 12);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.output.Size = new System.Drawing.Size(227, 578);
            this.output.TabIndex = 0;
            this.output.Text = "";
            this.output.WordWrap = false;
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // input_button
            // 
            this.input_button.Location = new System.Drawing.Point(15, 128);
            this.input_button.Name = "input_button";
            this.input_button.Size = new System.Drawing.Size(220, 30);
            this.input_button.TabIndex = 100;
            this.input_button.Text = "SUBMIT / RESET";
            this.input_button.UseVisualStyleBackColor = true;
            this.input_button.Click += new System.EventHandler(this.input_button_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 19);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 19);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(12, 90);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 19);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(12, 12);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(142, 15);
            this.questionLabel.TabIndex = 5;
            this.questionLabel.Text = "Give the number of lanes.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "SPEED:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // oThrottle
            // 
            this.oThrottle.Location = new System.Drawing.Point(114, 431);
            this.oThrottle.Margin = new System.Windows.Forms.Padding(10);
            this.oThrottle.Name = "oThrottle";
            this.oThrottle.ReadOnly = true;
            this.oThrottle.Size = new System.Drawing.Size(84, 23);
            this.oThrottle.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "THROTTLE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "INDICATOR:";
            // 
            // oIndicator
            // 
            this.oIndicator.Location = new System.Drawing.Point(114, 474);
            this.oIndicator.Margin = new System.Windows.Forms.Padding(10);
            this.oIndicator.Name = "oIndicator";
            this.oIndicator.ReadOnly = true;
            this.oIndicator.Size = new System.Drawing.Size(84, 23);
            this.oIndicator.TabIndex = 10;
            // 
            // oSpeed
            // 
            this.oSpeed.Location = new System.Drawing.Point(114, 388);
            this.oSpeed.Margin = new System.Windows.Forms.Padding(10);
            this.oSpeed.Name = "oSpeed";
            this.oSpeed.ReadOnly = true;
            this.oSpeed.Size = new System.Drawing.Size(84, 23);
            this.oSpeed.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "BRAKE:";
            // 
            // oBrake
            // 
            this.oBrake.Location = new System.Drawing.Point(114, 517);
            this.oBrake.Margin = new System.Windows.Forms.Padding(10);
            this.oBrake.Name = "oBrake";
            this.oBrake.ReadOnly = true;
            this.oBrake.Size = new System.Drawing.Size(84, 23);
            this.oBrake.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 563);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "HORN:";
            // 
            // oHorn
            // 
            this.oHorn.Location = new System.Drawing.Point(114, 560);
            this.oHorn.Margin = new System.Windows.Forms.Padding(10);
            this.oHorn.Name = "oHorn";
            this.oHorn.ReadOnly = true;
            this.oHorn.Size = new System.Drawing.Size(84, 23);
            this.oHorn.TabIndex = 14;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(12, 192);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(37, 15);
            this.TypeLabel.TabIndex = 15;
            this.TypeLabel.Text = "TYPE:";
            // 
            // oType
            // 
            this.oType.FormattingEnabled = true;
            this.oType.Items.AddRange(new object[] {
            "Bump",
            "Car",
            "Pot hole"});
            this.oType.Location = new System.Drawing.Point(114, 189);
            this.oType.Name = "oType";
            this.oType.Size = new System.Drawing.Size(121, 23);
            this.oType.TabIndex = 16;
            this.oType.SelectedIndexChanged += new System.EventHandler(this.oType_SelectedIndexChanged);
            // 
            // LocLabel
            // 
            this.LocLabel.AutoSize = true;
            this.LocLabel.Location = new System.Drawing.Point(14, 238);
            this.LocLabel.Name = "LocLabel";
            this.LocLabel.Size = new System.Drawing.Size(68, 15);
            this.LocLabel.TabIndex = 17;
            this.LocLabel.Text = "LOCATION:";
            // 
            // locX
            // 
            this.locX.Location = new System.Drawing.Point(114, 235);
            this.locX.Name = "locX";
            this.locX.Size = new System.Drawing.Size(26, 23);
            this.locX.TabIndex = 18;
            // 
            // locY
            // 
            this.locY.Location = new System.Drawing.Point(146, 235);
            this.locY.Name = "locY";
            this.locY.Size = new System.Drawing.Size(26, 23);
            this.locY.TabIndex = 19;
            // 
            // iAdd
            // 
            this.iAdd.Location = new System.Drawing.Point(17, 273);
            this.iAdd.Name = "iAdd";
            this.iAdd.Size = new System.Drawing.Size(220, 28);
            this.iAdd.TabIndex = 101;
            this.iAdd.Text = "ADD";
            this.iAdd.UseVisualStyleBackColor = true;
            this.iAdd.Click += new System.EventHandler(this.iAdd_Click);
            // 
            // iStart
            // 
            this.iStart.Location = new System.Drawing.Point(19, 320);
            this.iStart.Name = "iStart";
            this.iStart.Size = new System.Drawing.Size(218, 35);
            this.iStart.TabIndex = 103;
            this.iStart.Text = "IGNITION";
            this.iStart.UseVisualStyleBackColor = true;
            this.iStart.Click += new System.EventHandler(this.iStart_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.iStart;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(492, 602);
            this.Controls.Add(this.iStart);
            this.Controls.Add(this.iAdd);
            this.Controls.Add(this.locY);
            this.Controls.Add(this.locX);
            this.Controls.Add(this.LocLabel);
            this.Controls.Add(this.oType);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.oHorn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.oBrake);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.oSpeed);
            this.Controls.Add(this.oIndicator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oThrottle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.input_button);
            this.Controls.Add(this.output);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "RS1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button input_button;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oThrottle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox oIndicator;
        private System.Windows.Forms.TextBox oSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox oBrake;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox oHorn;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.ComboBox oType;
        private System.Windows.Forms.Label LocLabel;
        private System.Windows.Forms.TextBox locX;
        private System.Windows.Forms.TextBox locY;
        private Button iAdd;
        private Button iStart;
    }
}

