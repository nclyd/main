
namespace AS_CourseWork
{
    partial class QuestionPick
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
            this.btnMCQPick = new System.Windows.Forms.Button();
            this.btnDragAndDropPick = new System.Windows.Forms.Button();
            this.btnQuickfirePick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMCQPick
            // 
            this.btnMCQPick.Location = new System.Drawing.Point(103, 240);
            this.btnMCQPick.Name = "btnMCQPick";
            this.btnMCQPick.Size = new System.Drawing.Size(157, 23);
            this.btnMCQPick.TabIndex = 0;
            this.btnMCQPick.Text = "Multiple Choice Question";
            this.btnMCQPick.UseVisualStyleBackColor = true;
            this.btnMCQPick.Click += new System.EventHandler(this.btnMCQPick_Click);
            // 
            // btnDragAndDropPick
            // 
            this.btnDragAndDropPick.Location = new System.Drawing.Point(334, 240);
            this.btnDragAndDropPick.Name = "btnDragAndDropPick";
            this.btnDragAndDropPick.Size = new System.Drawing.Size(126, 23);
            this.btnDragAndDropPick.TabIndex = 1;
            this.btnDragAndDropPick.Text = "Drag and Drop";
            this.btnDragAndDropPick.UseVisualStyleBackColor = true;
            // 
            // btnQuickfirePick
            // 
            this.btnQuickfirePick.Location = new System.Drawing.Point(569, 240);
            this.btnQuickfirePick.Name = "btnQuickfirePick";
            this.btnQuickfirePick.Size = new System.Drawing.Size(144, 23);
            this.btnQuickfirePick.TabIndex = 2;
            this.btnQuickfirePick.Text = "Quickfire";
            this.btnQuickfirePick.UseVisualStyleBackColor = true;
            // 
            // QuestionPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuickfirePick);
            this.Controls.Add(this.btnDragAndDropPick);
            this.Controls.Add(this.btnMCQPick);
            this.Name = "QuestionPick";
            this.Text = "QuestionPick";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMCQPick;
        private System.Windows.Forms.Button btnDragAndDropPick;
        private System.Windows.Forms.Button btnQuickfirePick;
    }
}