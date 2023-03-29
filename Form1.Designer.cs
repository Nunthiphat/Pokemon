namespace Pokemon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PicCharizard = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbHP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.PicCharmeleon = new System.Windows.Forms.PictureBox();
            this.PicCharmander = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PicBulbasaur = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMonsHP = new System.Windows.Forms.TextBox();
            this.tbMonsName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicCharizard)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCharmeleon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCharmander)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBulbasaur)).BeginInit();
            this.SuspendLayout();
            // 
            // PicCharizard
            // 
            this.PicCharizard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PicCharizard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicCharizard.Image = global::Pokemon.Properties.Resources.Charlizard;
            this.PicCharizard.Location = new System.Drawing.Point(67, 26);
            this.PicCharizard.Name = "PicCharizard";
            this.PicCharizard.Size = new System.Drawing.Size(195, 189);
            this.PicCharizard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicCharizard.TabIndex = 0;
            this.PicCharizard.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gen1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Gen2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(34, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "Gen3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(34, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 6;
            this.button4.Text = "Gen4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(104, 237);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 27);
            this.tbName.TabIndex = 7;
            // 
            // tbHP
            // 
            this.tbHP.Location = new System.Drawing.Point(104, 270);
            this.tbHP.Name = "tbHP";
            this.tbHP.Size = new System.Drawing.Size(125, 27);
            this.tbHP.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(86, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 178);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Pokemon";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Location = new System.Drawing.Point(728, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 140);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Command";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 29);
            this.button5.TabIndex = 3;
            this.button5.Text = "Attack";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(18, 61);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 29);
            this.button6.TabIndex = 4;
            this.button6.Text = "HP + 50";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(18, 96);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 29);
            this.button7.TabIndex = 5;
            this.button7.Text = "Defence + 50";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // PicCharmeleon
            // 
            this.PicCharmeleon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PicCharmeleon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicCharmeleon.Image = global::Pokemon.Properties.Resources.Charmeleon;
            this.PicCharmeleon.Location = new System.Drawing.Point(67, 26);
            this.PicCharmeleon.Name = "PicCharmeleon";
            this.PicCharmeleon.Size = new System.Drawing.Size(195, 189);
            this.PicCharmeleon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicCharmeleon.TabIndex = 13;
            this.PicCharmeleon.TabStop = false;
            this.PicCharmeleon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PicCharmander
            // 
            this.PicCharmander.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PicCharmander.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicCharmander.Image = global::Pokemon.Properties.Resources.Charmander;
            this.PicCharmander.Location = new System.Drawing.Point(67, 26);
            this.PicCharmander.Name = "PicCharmander";
            this.PicCharmander.Size = new System.Drawing.Size(195, 189);
            this.PicCharmander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicCharmander.TabIndex = 14;
            this.PicCharmander.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Pokemon.Properties.Resources.Venusaur;
            this.pictureBox1.Location = new System.Drawing.Point(706, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Pokemon.Properties.Resources.Ivysaur;
            this.pictureBox2.Location = new System.Drawing.Point(706, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 189);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // PicBulbasaur
            // 
            this.PicBulbasaur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PicBulbasaur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBulbasaur.Image = global::Pokemon.Properties.Resources.Venusaur1;
            this.PicBulbasaur.Location = new System.Drawing.Point(706, 26);
            this.PicBulbasaur.Name = "PicBulbasaur";
            this.PicBulbasaur.Size = new System.Drawing.Size(195, 189);
            this.PicBulbasaur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBulbasaur.TabIndex = 17;
            this.PicBulbasaur.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(686, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "HP";
            // 
            // tbMonsHP
            // 
            this.tbMonsHP.Location = new System.Drawing.Point(742, 270);
            this.tbMonsHP.Name = "tbMonsHP";
            this.tbMonsHP.Size = new System.Drawing.Size(125, 27);
            this.tbMonsHP.TabIndex = 19;
            // 
            // tbMonsName
            // 
            this.tbMonsName.Location = new System.Drawing.Point(742, 237);
            this.tbMonsName.Name = "tbMonsName";
            this.tbMonsName.Size = new System.Drawing.Size(125, 27);
            this.tbMonsName.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 507);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMonsHP);
            this.Controls.Add(this.tbMonsName);
            this.Controls.Add(this.PicBulbasaur);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PicCharmander);
            this.Controls.Add(this.PicCharmeleon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHP);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.PicCharizard);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicCharizard)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicCharmeleon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCharmander)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBulbasaur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PicCharizard;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox tbName;
        private TextBox tbHP;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button5;
        private Button button6;
        private Button button7;
        private PictureBox PicCharmeleon;
        private PictureBox PicCharmander;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox PicBulbasaur;
        private Label label3;
        private Label label4;
        private TextBox tbMonsHP;
        private TextBox tbMonsName;
    }
}