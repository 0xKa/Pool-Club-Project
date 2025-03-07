namespace Pool_Club_Project
{
    partial class frmMain
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
            this.playTable1 = new Pool_Club_Project.PlayTable();
            this.playTable2 = new Pool_Club_Project.PlayTable();
            this.playTable3 = new Pool_Club_Project.PlayTable();
            this.playTable4 = new Pool_Club_Project.PlayTable();
            this.SuspendLayout();
            // 
            // playTable1
            // 
            this.playTable1.BackColor = System.Drawing.Color.Transparent;
            this.playTable1.FeesPerHour = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.playTable1.Location = new System.Drawing.Point(48, 12);
            this.playTable1.Name = "playTable1";
            this.playTable1.PlayerName = "Player1";
            this.playTable1.Size = new System.Drawing.Size(343, 233);
            this.playTable1.TabIndex = 0;
            this.playTable1.TableTitle = "Table1";
            this.playTable1.TableCompleted += new System.EventHandler<Pool_Club_Project.PlayTable.TableCompletedEventArgs>(this.playTable1_TableCompleted);
            // 
            // playTable2
            // 
            this.playTable2.BackColor = System.Drawing.Color.Transparent;
            this.playTable2.FeesPerHour = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.playTable2.Location = new System.Drawing.Point(463, 12);
            this.playTable2.Name = "playTable2";
            this.playTable2.PlayerName = "Reda";
            this.playTable2.Size = new System.Drawing.Size(343, 233);
            this.playTable2.TabIndex = 1;
            this.playTable2.TableTitle = "Table2";
            this.playTable2.TableCompleted += new System.EventHandler<Pool_Club_Project.PlayTable.TableCompletedEventArgs>(this.playTable1_TableCompleted);
            // 
            // playTable3
            // 
            this.playTable3.BackColor = System.Drawing.Color.Transparent;
            this.playTable3.FeesPerHour = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.playTable3.Location = new System.Drawing.Point(463, 272);
            this.playTable3.Name = "playTable3";
            this.playTable3.PlayerName = "Mohammed";
            this.playTable3.Size = new System.Drawing.Size(343, 233);
            this.playTable3.TabIndex = 3;
            this.playTable3.TableTitle = "Table4";
            this.playTable3.TableCompleted += new System.EventHandler<Pool_Club_Project.PlayTable.TableCompletedEventArgs>(this.playTable1_TableCompleted);
            // 
            // playTable4
            // 
            this.playTable4.BackColor = System.Drawing.Color.Transparent;
            this.playTable4.FeesPerHour = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.playTable4.Location = new System.Drawing.Point(48, 272);
            this.playTable4.Name = "playTable4";
            this.playTable4.PlayerName = "Ahmed";
            this.playTable4.Size = new System.Drawing.Size(343, 233);
            this.playTable4.TabIndex = 2;
            this.playTable4.TableTitle = "Table3";
            this.playTable4.TableCompleted += new System.EventHandler<Pool_Club_Project.PlayTable.TableCompletedEventArgs>(this.playTable1_TableCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(854, 517);
            this.Controls.Add(this.playTable3);
            this.Controls.Add(this.playTable4);
            this.Controls.Add(this.playTable2);
            this.Controls.Add(this.playTable1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private PlayTable playTable1;
        private PlayTable playTable2;
        private PlayTable playTable3;
        private PlayTable playTable4;
    }
}

