﻿namespace View
{
    namespace MenuModule
    {
        partial class HowToPlay3
        {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.Button Exit;

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
            /// AUTO GENERATED BY C# VISUAL STUDIO
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                this.Exit = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // Exit
                // 
                this.Exit.BackColor = System.Drawing.Color.Transparent;
                this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                this.Exit.FlatAppearance.BorderSize = 0;
                this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.Exit.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Exit.ForeColor = System.Drawing.Color.White;
                this.Exit.Location = new System.Drawing.Point(24, 435);
                this.Exit.Name = "Exit";
                this.Exit.Size = new System.Drawing.Size(80, 24);
                this.Exit.TabIndex = 2;
                this.Exit.UseVisualStyleBackColor = false;
                this.Exit.Click += new System.EventHandler(this.Exit_Click);
                // 
                // HowToPlay3
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.BackgroundImage = global::Blaze_Brigade.Resource1.instructions3;
                this.ClientSize = new System.Drawing.Size(668, 478);
                this.ControlBox = false;
                this.Controls.Add(this.Exit);
                this.Name = "HowToPlay3";
                this.Text = "How To Play";
                this.ResumeLayout(false);

            }


            #endregion

        }
    }
}