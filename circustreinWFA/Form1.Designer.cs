
namespace circustreinWFA
{
    partial class CircusTrein
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
            this.startBTN = new System.Windows.Forms.Button();
            this.SCarnivoreTB = new System.Windows.Forms.TextBox();
            this.SHerbivoreTB = new System.Windows.Forms.TextBox();
            this.MHerbivoreTB = new System.Windows.Forms.TextBox();
            this.LHerbivoreTB = new System.Windows.Forms.TextBox();
            this.MCarnivoreTB = new System.Windows.Forms.TextBox();
            this.LCarnivoreTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startBTN
            // 
            this.startBTN.Location = new System.Drawing.Point(87, 358);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(75, 23);
            this.startBTN.TabIndex = 0;
            this.startBTN.Text = "bereken";
            this.startBTN.UseVisualStyleBackColor = true;
            // 
            // SCarnivoreTB
            // 
            this.SCarnivoreTB.Location = new System.Drawing.Point(75, 43);
            this.SCarnivoreTB.Name = "SCarnivoreTB";
            this.SCarnivoreTB.Size = new System.Drawing.Size(100, 22);
            this.SCarnivoreTB.TabIndex = 1;
            // 
            // SHerbivoreTB
            // 
            this.SHerbivoreTB.Location = new System.Drawing.Point(201, 43);
            this.SHerbivoreTB.Name = "SHerbivoreTB";
            this.SHerbivoreTB.Size = new System.Drawing.Size(100, 22);
            this.SHerbivoreTB.TabIndex = 2;
            // 
            // MHerbivoreTB
            // 
            this.MHerbivoreTB.Location = new System.Drawing.Point(201, 85);
            this.MHerbivoreTB.Name = "MHerbivoreTB";
            this.MHerbivoreTB.Size = new System.Drawing.Size(100, 22);
            this.MHerbivoreTB.TabIndex = 3;
            // 
            // LHerbivoreTB
            // 
            this.LHerbivoreTB.Location = new System.Drawing.Point(201, 127);
            this.LHerbivoreTB.Name = "LHerbivoreTB";
            this.LHerbivoreTB.Size = new System.Drawing.Size(100, 22);
            this.LHerbivoreTB.TabIndex = 4;
            // 
            // MCarnivoreTB
            // 
            this.MCarnivoreTB.Location = new System.Drawing.Point(75, 85);
            this.MCarnivoreTB.Name = "MCarnivoreTB";
            this.MCarnivoreTB.Size = new System.Drawing.Size(100, 22);
            this.MCarnivoreTB.TabIndex = 5;
            // 
            // LCarnivoreTB
            // 
            this.LCarnivoreTB.Location = new System.Drawing.Point(75, 127);
            this.LCarnivoreTB.Name = "LCarnivoreTB";
            this.LCarnivoreTB.Size = new System.Drawing.Size(100, 22);
            this.LCarnivoreTB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Carnivore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Herbivore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "small";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "medium";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "large";
            // 
            // CircusTrein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LCarnivoreTB);
            this.Controls.Add(this.MCarnivoreTB);
            this.Controls.Add(this.LHerbivoreTB);
            this.Controls.Add(this.MHerbivoreTB);
            this.Controls.Add(this.SHerbivoreTB);
            this.Controls.Add(this.SCarnivoreTB);
            this.Controls.Add(this.startBTN);
            this.Name = "CircusTrein";
            this.Text = "Circus Trein";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.TextBox SCarnivoreTB;
        private System.Windows.Forms.TextBox SHerbivoreTB;
        private System.Windows.Forms.TextBox MHerbivoreTB;
        private System.Windows.Forms.TextBox LHerbivoreTB;
        private System.Windows.Forms.TextBox MCarnivoreTB;
        private System.Windows.Forms.TextBox LCarnivoreTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

