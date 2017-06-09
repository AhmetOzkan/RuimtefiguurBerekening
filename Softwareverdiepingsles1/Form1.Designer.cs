namespace Softwareverdiepingsles1
{
    partial class Form1
    {
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
            this.btnOppervlakte = new System.Windows.Forms.Button();
            this.btnInhoud = new System.Windows.Forms.Button();
            this.RBcilinder = new System.Windows.Forms.RadioButton();
            this.RBpyramide = new System.Windows.Forms.RadioButton();
            this.RBtrapezium = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbPlaatje = new System.Windows.Forms.PictureBox();
            this.RBbalk = new System.Windows.Forms.RadioButton();
            this.lblOppervlakte = new System.Windows.Forms.Label();
            this.lblInhoud = new System.Windows.Forms.Label();
            this.lblLengte = new System.Windows.Forms.Label();
            this.lblBreedte = new System.Windows.Forms.Label();
            this.lblHoogte = new System.Windows.Forms.Label();
            this.tbLengte1 = new System.Windows.Forms.TextBox();
            this.tbBreedte1 = new System.Windows.Forms.TextBox();
            this.tbHoogte = new System.Windows.Forms.TextBox();
            this.tbLengte2 = new System.Windows.Forms.TextBox();
            this.tbBreedte2 = new System.Windows.Forms.TextBox();
            this.lbCentimeter = new System.Windows.Forms.Label();
            this.lbCentimeter2 = new System.Windows.Forms.Label();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.tbDiameter = new System.Windows.Forms.TextBox();
            this.lblLiters = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaatje)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOppervlakte
            // 
            this.btnOppervlakte.Location = new System.Drawing.Point(380, 278);
            this.btnOppervlakte.Name = "btnOppervlakte";
            this.btnOppervlakte.Size = new System.Drawing.Size(121, 28);
            this.btnOppervlakte.TabIndex = 2;
            this.btnOppervlakte.Text = "Oppervlakte";
            this.btnOppervlakte.UseVisualStyleBackColor = true;
            this.btnOppervlakte.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInhoud
            // 
            this.btnInhoud.Location = new System.Drawing.Point(563, 278);
            this.btnInhoud.Name = "btnInhoud";
            this.btnInhoud.Size = new System.Drawing.Size(133, 29);
            this.btnInhoud.TabIndex = 3;
            this.btnInhoud.Text = "Inhoud";
            this.btnInhoud.UseVisualStyleBackColor = true;
            this.btnInhoud.Click += new System.EventHandler(this.button2_Click);
            // 
            // RBcilinder
            // 
            this.RBcilinder.AutoSize = true;
            this.RBcilinder.Location = new System.Drawing.Point(6, 76);
            this.RBcilinder.Name = "RBcilinder";
            this.RBcilinder.Size = new System.Drawing.Size(59, 17);
            this.RBcilinder.TabIndex = 6;
            this.RBcilinder.Text = "Cilinder";
            this.RBcilinder.UseVisualStyleBackColor = true;
            this.RBcilinder.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RBpyramide
            // 
            this.RBpyramide.AutoSize = true;
            this.RBpyramide.Location = new System.Drawing.Point(6, 53);
            this.RBpyramide.Name = "RBpyramide";
            this.RBpyramide.Size = new System.Drawing.Size(68, 17);
            this.RBpyramide.TabIndex = 8;
            this.RBpyramide.Text = "Pyramide";
            this.RBpyramide.UseVisualStyleBackColor = true;
            this.RBpyramide.CheckedChanged += new System.EventHandler(this.RBpyramide_CheckedChanged);
            // 
            // RBtrapezium
            // 
            this.RBtrapezium.AutoSize = true;
            this.RBtrapezium.BackColor = System.Drawing.SystemColors.Control;
            this.RBtrapezium.Location = new System.Drawing.Point(6, 100);
            this.RBtrapezium.Name = "RBtrapezium";
            this.RBtrapezium.Size = new System.Drawing.Size(74, 17);
            this.RBtrapezium.TabIndex = 9;
            this.RBtrapezium.Text = "Trapezium";
            this.RBtrapezium.UseVisualStyleBackColor = false;
            this.RBtrapezium.CheckedChanged += new System.EventHandler(this.RBtrapezium_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbPlaatje);
            this.groupBox1.Controls.Add(this.RBtrapezium);
            this.groupBox1.Controls.Add(this.RBpyramide);
            this.groupBox1.Controls.Add(this.RBbalk);
            this.groupBox1.Controls.Add(this.RBcilinder);
            this.groupBox1.Location = new System.Drawing.Point(6, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 171);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kies je vorm:";
            // 
            // pbPlaatje
            // 
            this.pbPlaatje.Image = global::Softwareverdiepingsles1.Properties.Resources.tekening_balk;
            this.pbPlaatje.Location = new System.Drawing.Point(86, 13);
            this.pbPlaatje.Name = "pbPlaatje";
            this.pbPlaatje.Size = new System.Drawing.Size(131, 145);
            this.pbPlaatje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlaatje.TabIndex = 10;
            this.pbPlaatje.TabStop = false;
            this.pbPlaatje.Click += new System.EventHandler(this.pbPlaatje_Click);
            // 
            // RBbalk
            // 
            this.RBbalk.AutoSize = true;
            this.RBbalk.Location = new System.Drawing.Point(6, 28);
            this.RBbalk.Name = "RBbalk";
            this.RBbalk.Size = new System.Drawing.Size(46, 17);
            this.RBbalk.TabIndex = 7;
            this.RBbalk.Text = "Balk";
            this.RBbalk.UseVisualStyleBackColor = true;
            this.RBbalk.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lblOppervlakte
            // 
            this.lblOppervlakte.AutoSize = true;
            this.lblOppervlakte.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblOppervlakte.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOppervlakte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOppervlakte.Location = new System.Drawing.Point(229, 375);
            this.lblOppervlakte.Name = "lblOppervlakte";
            this.lblOppervlakte.Size = new System.Drawing.Size(13, 20);
            this.lblOppervlakte.TabIndex = 14;
            this.lblOppervlakte.Text = " ";
            // 
            // lblInhoud
            // 
            this.lblInhoud.AutoSize = true;
            this.lblInhoud.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblInhoud.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInhoud.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInhoud.Location = new System.Drawing.Point(229, 430);
            this.lblInhoud.Name = "lblInhoud";
            this.lblInhoud.Size = new System.Drawing.Size(13, 20);
            this.lblInhoud.TabIndex = 15;
            this.lblInhoud.Text = " ";
            // 
            // lblLengte
            // 
            this.lblLengte.AutoSize = true;
            this.lblLengte.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengte.Location = new System.Drawing.Point(344, 57);
            this.lblLengte.Name = "lblLengte";
            this.lblLengte.Size = new System.Drawing.Size(54, 20);
            this.lblLengte.TabIndex = 16;
            this.lblLengte.Text = "Lengte:";
            this.lblLengte.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBreedte
            // 
            this.lblBreedte.AutoSize = true;
            this.lblBreedte.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreedte.Location = new System.Drawing.Point(466, 57);
            this.lblBreedte.Name = "lblBreedte";
            this.lblBreedte.Size = new System.Drawing.Size(61, 20);
            this.lblBreedte.TabIndex = 17;
            this.lblBreedte.Text = "Breedte:";
            this.lblBreedte.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblHoogte
            // 
            this.lblHoogte.AutoSize = true;
            this.lblHoogte.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoogte.Location = new System.Drawing.Point(592, 57);
            this.lblHoogte.Name = "lblHoogte";
            this.lblHoogte.Size = new System.Drawing.Size(57, 20);
            this.lblHoogte.TabIndex = 18;
            this.lblHoogte.Text = "Hoogte:";
            this.lblHoogte.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbLengte1
            // 
            this.tbLengte1.Location = new System.Drawing.Point(348, 106);
            this.tbLengte1.Name = "tbLengte1";
            this.tbLengte1.Size = new System.Drawing.Size(100, 20);
            this.tbLengte1.TabIndex = 19;
            // 
            // tbBreedte1
            // 
            this.tbBreedte1.Location = new System.Drawing.Point(470, 106);
            this.tbBreedte1.Name = "tbBreedte1";
            this.tbBreedte1.Size = new System.Drawing.Size(100, 20);
            this.tbBreedte1.TabIndex = 20;
            // 
            // tbHoogte
            // 
            this.tbHoogte.Location = new System.Drawing.Point(596, 106);
            this.tbHoogte.Name = "tbHoogte";
            this.tbHoogte.Size = new System.Drawing.Size(100, 20);
            this.tbHoogte.TabIndex = 21;
            // 
            // tbLengte2
            // 
            this.tbLengte2.Location = new System.Drawing.Point(348, 142);
            this.tbLengte2.Name = "tbLengte2";
            this.tbLengte2.Size = new System.Drawing.Size(100, 20);
            this.tbLengte2.TabIndex = 22;
            this.tbLengte2.Visible = false;
            // 
            // tbBreedte2
            // 
            this.tbBreedte2.Location = new System.Drawing.Point(470, 142);
            this.tbBreedte2.Name = "tbBreedte2";
            this.tbBreedte2.Size = new System.Drawing.Size(100, 20);
            this.tbBreedte2.TabIndex = 23;
            this.tbBreedte2.Visible = false;
            // 
            // lbCentimeter
            // 
            this.lbCentimeter.AutoSize = true;
            this.lbCentimeter.Location = new System.Drawing.Point(728, 111);
            this.lbCentimeter.Name = "lbCentimeter";
            this.lbCentimeter.Size = new System.Drawing.Size(57, 13);
            this.lbCentimeter.TabIndex = 24;
            this.lbCentimeter.Text = "Centimeter";
            // 
            // lbCentimeter2
            // 
            this.lbCentimeter2.AutoSize = true;
            this.lbCentimeter2.Location = new System.Drawing.Point(728, 145);
            this.lbCentimeter2.Name = "lbCentimeter2";
            this.lbCentimeter2.Size = new System.Drawing.Size(57, 13);
            this.lbCentimeter2.TabIndex = 25;
            this.lbCentimeter2.Text = "Centimeter";
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiameter.Location = new System.Drawing.Point(344, 57);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(66, 20);
            this.lblDiameter.TabIndex = 26;
            this.lblDiameter.Text = "Diameter:";
            this.lblDiameter.Visible = false;
            this.lblDiameter.Click += new System.EventHandler(this.lblDiameter_Click);
            // 
            // tbDiameter
            // 
            this.tbDiameter.Location = new System.Drawing.Point(348, 107);
            this.tbDiameter.Name = "tbDiameter";
            this.tbDiameter.Size = new System.Drawing.Size(100, 20);
            this.tbDiameter.TabIndex = 27;
            this.tbDiameter.Visible = false;
            // 
            // lblLiters
            // 
            this.lblLiters.AutoSize = true;
            this.lblLiters.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblLiters.Location = new System.Drawing.Point(232, 471);
            this.lblLiters.Name = "lblLiters";
            this.lblLiters.Size = new System.Drawing.Size(10, 13);
            this.lblLiters.TabIndex = 28;
            this.lblLiters.Text = " ";
            this.lblLiters.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1220, 564);
            this.Controls.Add(this.lblLiters);
            this.Controls.Add(this.tbDiameter);
            this.Controls.Add(this.lblDiameter);
            this.Controls.Add(this.lbCentimeter2);
            this.Controls.Add(this.lbCentimeter);
            this.Controls.Add(this.tbBreedte2);
            this.Controls.Add(this.tbLengte2);
            this.Controls.Add(this.tbHoogte);
            this.Controls.Add(this.tbBreedte1);
            this.Controls.Add(this.tbLengte1);
            this.Controls.Add(this.lblHoogte);
            this.Controls.Add(this.lblBreedte);
            this.Controls.Add(this.lblLengte);
            this.Controls.Add(this.lblInhoud);
            this.Controls.Add(this.lblOppervlakte);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInhoud);
            this.Controls.Add(this.btnOppervlakte);
            this.Name = "Form1";
            this.Text = "Oppervlakte Berekenen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaatje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOppervlakte;
        private System.Windows.Forms.Button btnInhoud;
        private System.Windows.Forms.RadioButton RBcilinder;
        private System.Windows.Forms.RadioButton RBpyramide;
        private System.Windows.Forms.RadioButton RBtrapezium;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbPlaatje;
        private System.Windows.Forms.RadioButton RBbalk;
        private System.Windows.Forms.Label lblOppervlakte;
        private System.Windows.Forms.Label lblInhoud;
        private System.Windows.Forms.Label lblLengte;
        private System.Windows.Forms.Label lblBreedte;
        private System.Windows.Forms.Label lblHoogte;
        private System.Windows.Forms.TextBox tbLengte1;
        private System.Windows.Forms.TextBox tbBreedte1;
        private System.Windows.Forms.TextBox tbHoogte;
        private System.Windows.Forms.TextBox tbLengte2;
        private System.Windows.Forms.TextBox tbBreedte2;
        private System.Windows.Forms.Label lbCentimeter;
        private System.Windows.Forms.Label lbCentimeter2;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.TextBox tbDiameter;
        private System.Windows.Forms.Label lblLiters;
    }
}

