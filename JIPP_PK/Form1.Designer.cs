namespace JIPP_PK
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxOkrag = new System.Windows.Forms.GroupBox();
            this.buttonOkregiStart = new System.Windows.Forms.Button();
            this.buttonOkregiStop = new System.Windows.Forms.Button();
            this.groupBoxGwiazda = new System.Windows.Forms.GroupBox();
            this.buttonGwiazdyStart = new System.Windows.Forms.Button();
            this.buttonGwiazdyStop = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxOkrag, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOkregiStart, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonOkregiStop, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxGwiazda, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonGwiazdyStart, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonGwiazdyStop, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(666, 343);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxOkrag
            // 
            this.groupBoxOkrag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOkrag.Location = new System.Drawing.Point(3, 3);
            this.groupBoxOkrag.Name = "groupBoxOkrag";
            this.groupBoxOkrag.Size = new System.Drawing.Size(327, 268);
            this.groupBoxOkrag.TabIndex = 0;
            this.groupBoxOkrag.TabStop = false;
            this.groupBoxOkrag.Text = "Animacja okręgów";
            // 
            // buttonOkregiStart
            // 
            this.buttonOkregiStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonOkregiStart.Location = new System.Drawing.Point(3, 282);
            this.buttonOkregiStart.Name = "buttonOkregiStart";
            this.buttonOkregiStart.Size = new System.Drawing.Size(327, 23);
            this.buttonOkregiStart.TabIndex = 1;
            this.buttonOkregiStart.Text = "Start";
            this.buttonOkregiStart.UseVisualStyleBackColor = true;
            this.buttonOkregiStart.Click += new System.EventHandler(this.buttonOkregiStart_Click);
            // 
            // buttonOkregiStop
            // 
            this.buttonOkregiStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOkregiStop.Location = new System.Drawing.Point(3, 311);
            this.buttonOkregiStop.Name = "buttonOkregiStop";
            this.buttonOkregiStop.Size = new System.Drawing.Size(327, 23);
            this.buttonOkregiStop.TabIndex = 2;
            this.buttonOkregiStop.Text = "Stop";
            this.buttonOkregiStop.UseVisualStyleBackColor = true;
            this.buttonOkregiStop.Click += new System.EventHandler(this.buttonOkregiStop_Click);
            // 
            // groupBoxGwiazda
            // 
            this.groupBoxGwiazda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGwiazda.Location = new System.Drawing.Point(336, 3);
            this.groupBoxGwiazda.Name = "groupBoxGwiazda";
            this.groupBoxGwiazda.Size = new System.Drawing.Size(327, 268);
            this.groupBoxGwiazda.TabIndex = 3;
            this.groupBoxGwiazda.TabStop = false;
            this.groupBoxGwiazda.Text = "Słoneczko";
            // 
            // buttonGwiazdyStart
            // 
            this.buttonGwiazdyStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonGwiazdyStart.Location = new System.Drawing.Point(336, 282);
            this.buttonGwiazdyStart.Name = "buttonGwiazdyStart";
            this.buttonGwiazdyStart.Size = new System.Drawing.Size(327, 23);
            this.buttonGwiazdyStart.TabIndex = 4;
            this.buttonGwiazdyStart.Text = "Start";
            this.buttonGwiazdyStart.UseVisualStyleBackColor = true;
            this.buttonGwiazdyStart.Click += new System.EventHandler(this.buttonGwiazdyStart_Click);
            // 
            // buttonGwiazdyStop
            // 
            this.buttonGwiazdyStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGwiazdyStop.Location = new System.Drawing.Point(336, 311);
            this.buttonGwiazdyStop.Name = "buttonGwiazdyStop";
            this.buttonGwiazdyStop.Size = new System.Drawing.Size(327, 23);
            this.buttonGwiazdyStop.TabIndex = 5;
            this.buttonGwiazdyStop.Text = "Stop";
            this.buttonGwiazdyStop.UseVisualStyleBackColor = true;
            this.buttonGwiazdyStop.Click += new System.EventHandler(this.buttonGwiazdyStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(666, 343);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Hello world!";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxOkrag;
        private System.Windows.Forms.Button buttonOkregiStart;
        private System.Windows.Forms.Button buttonOkregiStop;
        private System.Windows.Forms.GroupBox groupBoxGwiazda;
        private System.Windows.Forms.Button buttonGwiazdyStart;
        private System.Windows.Forms.Button buttonGwiazdyStop;
    }
}

