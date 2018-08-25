namespace SistemaVotacao.View
{
    partial class MySession
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
            this.lWelcome = new System.Windows.Forms.Label();
            this.lDay = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.lRestaurant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lVotes = new System.Windows.Forms.Label();
            this.listRestaurant = new System.Windows.Forms.ListBox();
            this.tbVote = new System.Windows.Forms.TextBox();
            this.bVote = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lWelcome
            // 
            this.lWelcome.AutoSize = true;
            this.lWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWelcome.Location = new System.Drawing.Point(12, 9);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(187, 24);
            this.lWelcome.TabIndex = 0;
            this.lWelcome.Text = "Bem Vindo, <USER>";
            this.lWelcome.Click += new System.EventHandler(this.lWelcome_Click);
            // 
            // lDay
            // 
            this.lDay.AutoSize = true;
            this.lDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDay.Location = new System.Drawing.Point(94, 243);
            this.lDay.Name = "lDay";
            this.lDay.Size = new System.Drawing.Size(76, 13);
            this.lDay.TabIndex = 2;
            this.lDay.Text = "Segunda-Feira";
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(19, 72);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 16;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lRestaurant
            // 
            this.lRestaurant.AutoSize = true;
            this.lRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRestaurant.Location = new System.Drawing.Point(179, 274);
            this.lRestaurant.Name = "lRestaurant";
            this.lRestaurant.Size = new System.Drawing.Size(154, 18);
            this.lRestaurant.TabIndex = 17;
            this.lRestaurant.Text = "Nome do Restaurante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nº Votos: ";
            // 
            // lVotes
            // 
            this.lVotes.AutoSize = true;
            this.lVotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVotes.Location = new System.Drawing.Point(113, 307);
            this.lVotes.Name = "lVotes";
            this.lVotes.Size = new System.Drawing.Size(24, 18);
            this.lVotes.TabIndex = 19;
            this.lVotes.Text = "00";
            // 
            // listRestaurant
            // 
            this.listRestaurant.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRestaurant.FormattingEnabled = true;
            this.listRestaurant.ItemHeight = 18;
            this.listRestaurant.Location = new System.Drawing.Point(336, 122);
            this.listRestaurant.Name = "listRestaurant";
            this.listRestaurant.Size = new System.Drawing.Size(166, 94);
            this.listRestaurant.TabIndex = 20;
            this.listRestaurant.SelectedIndexChanged += new System.EventHandler(this.listRestaurant_SelectedIndexChanged);
            // 
            // tbVote
            // 
            this.tbVote.BackColor = System.Drawing.SystemColors.Menu;
            this.tbVote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVote.Location = new System.Drawing.Point(336, 89);
            this.tbVote.Name = "tbVote";
            this.tbVote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbVote.Size = new System.Drawing.Size(166, 24);
            this.tbVote.TabIndex = 21;
            // 
            // bVote
            // 
            this.bVote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVote.Location = new System.Drawing.Point(382, 224);
            this.bVote.Name = "bVote";
            this.bVote.Size = new System.Drawing.Size(74, 37);
            this.bVote.TabIndex = 22;
            this.bVote.Text = "Votar!";
            this.bVote.UseVisualStyleBackColor = true;
            this.bVote.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Restaurante do dia: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Selecione ou digite abaixo seu restaurante";
            // 
            // MySession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 387);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bVote);
            this.Controls.Add(this.tbVote);
            this.Controls.Add(this.listRestaurant);
            this.Controls.Add(this.lVotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lRestaurant);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.lDay);
            this.Controls.Add(this.lWelcome);
            this.Name = "MySession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySession";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MySession_FormClosed);
            this.Load += new System.EventHandler(this.MySession_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lWelcome;
        private System.Windows.Forms.Label lDay;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Label lRestaurant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lVotes;
        private System.Windows.Forms.ListBox listRestaurant;
        private System.Windows.Forms.TextBox tbVote;
        private System.Windows.Forms.Button bVote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}