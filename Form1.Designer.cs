namespace HarmadikNap_Feladat
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
            multipleNumber = new Button();
            singleNumber = new Button();
            szamVizsgalat = new Label();
            eredmeny = new Label();
            eredmenyMezo = new TextBox();
            szamMezo = new TextBox();
            label1 = new Label();
            working = new ProgressBar();
            SuspendLayout();
            // 
            // multipleNumber
            // 
            multipleNumber.Location = new Point(12, 60);
            multipleNumber.Name = "multipleNumber";
            multipleNumber.Size = new Size(188, 23);
            multipleNumber.TabIndex = 0;
            multipleNumber.Text = "Vizsgálat megadott számig";
            multipleNumber.UseVisualStyleBackColor = true;
            multipleNumber.Click += multipleNumber_Click;
            // 
            // singleNumber
            // 
            singleNumber.Location = new Point(262, 60);
            singleNumber.Name = "singleNumber";
            singleNumber.Size = new Size(188, 23);
            singleNumber.TabIndex = 1;
            singleNumber.Text = "Szám vizsgálata";
            singleNumber.UseVisualStyleBackColor = true;
            singleNumber.Click += singleNumber_Click;
            // 
            // szamVizsgalat
            // 
            szamVizsgalat.AutoSize = true;
            szamVizsgalat.ForeColor = Color.Red;
            szamVizsgalat.Location = new Point(308, 17);
            szamVizsgalat.Name = "szamVizsgalat";
            szamVizsgalat.Size = new Size(0, 15);
            szamVizsgalat.TabIndex = 2;
            // 
            // eredmeny
            // 
            eredmeny.AutoSize = true;
            eredmeny.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            eredmeny.Location = new Point(238, 227);
            eredmeny.Name = "eredmeny";
            eredmeny.Size = new Size(0, 20);
            eredmeny.TabIndex = 3;
            // 
            // eredmenyMezo
            // 
            eredmenyMezo.Location = new Point(12, 132);
            eredmenyMezo.Multiline = true;
            eredmenyMezo.Name = "eredmenyMezo";
            eredmenyMezo.ReadOnly = true;
            eredmenyMezo.ScrollBars = ScrollBars.Vertical;
            eredmenyMezo.Size = new Size(188, 308);
            eredmenyMezo.TabIndex = 4;
            // 
            // szamMezo
            // 
            szamMezo.Location = new Point(173, 14);
            szamMezo.Name = "szamMezo";
            szamMezo.Size = new Size(100, 23);
            szamMezo.TabIndex = 5;
            szamMezo.KeyPress += szamMezo_KeyPress_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 17);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 6;
            label1.Text = "Add meg a számot : ";
            // 
            // working
            // 
            working.Location = new Point(12, 112);
            working.Name = "working";
            working.Size = new Size(188, 14);
            working.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(working);
            Controls.Add(label1);
            Controls.Add(szamMezo);
            Controls.Add(eredmenyMezo);
            Controls.Add(eredmeny);
            Controls.Add(szamVizsgalat);
            Controls.Add(singleNumber);
            Controls.Add(multipleNumber);
            Name = "Form1";
            Text = "Harmadik Nap Feladat";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button multipleNumber;
        private Button singleNumber;
        private Label szamVizsgalat;
        private Label eredmeny;
        private TextBox eredmenyMezo;
        private TextBox szamMezo;
        private Label label1;
        private ProgressBar working;
    }
}