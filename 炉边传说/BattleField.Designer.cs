﻿namespace 炉边传说
{
    partial class BattleField
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lstHandCard = new System.Windows.Forms.ListBox();
            this.lblSelectedHandCardInfo = new System.Windows.Forms.Label();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "战场信息：";
            // 
            // lstHandCard
            // 
            this.lstHandCard.FormattingEnabled = true;
            this.lstHandCard.Location = new System.Drawing.Point(15, 304);
            this.lstHandCard.Name = "lstHandCard";
            this.lstHandCard.Size = new System.Drawing.Size(120, 95);
            this.lstHandCard.TabIndex = 1;
            this.lstHandCard.SelectedIndexChanged += new System.EventHandler(this.lstHandCard_SelectedIndexChanged);
            // 
            // lblSelectedHandCardInfo
            // 
            this.lblSelectedHandCardInfo.AutoSize = true;
            this.lblSelectedHandCardInfo.Location = new System.Drawing.Point(162, 304);
            this.lblSelectedHandCardInfo.Name = "lblSelectedHandCardInfo";
            this.lblSelectedHandCardInfo.Size = new System.Drawing.Size(79, 13);
            this.lblSelectedHandCardInfo.TabIndex = 2;
            this.lblSelectedHandCardInfo.Text = "当前选择手牌";
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Location = new System.Drawing.Point(762, 183);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(75, 23);
            this.btnEndTurn.TabIndex = 3;
            this.btnEndTurn.Text = "结束回合";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // BattleField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 411);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.lblSelectedHandCardInfo);
            this.Controls.Add(this.lstHandCard);
            this.Controls.Add(this.lblStatus);
            this.Name = "BattleField";
            this.Text = "战场";
            this.Load += new System.EventHandler(this.BattleField_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListBox lstHandCard;
        private System.Windows.Forms.Label lblSelectedHandCardInfo;
        private System.Windows.Forms.Button btnEndTurn;

    }
}