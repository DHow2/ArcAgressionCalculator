namespace Arc
{
    partial class Settings
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
            editDowned = new Button();
            editKnocked = new Button();
            editFirst = new Button();
            EditDMG = new Button();
            EditDMGRec = new Button();
            editLooted = new Button();
            textDowned = new TextBox();
            textKnocked = new TextBox();
            textRev = new TextBox();
            textDMG = new TextBox();
            textDMGRec = new TextBox();
            textLooted = new TextBox();
            editRev = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // editDowned
            // 
            editDowned.Location = new Point(425, 82);
            editDowned.Name = "editDowned";
            editDowned.Size = new Size(94, 29);
            editDowned.TabIndex = 0;
            editDowned.Text = "Edit";
            editDowned.UseVisualStyleBackColor = true;
            // 
            // editKnocked
            // 
            editKnocked.Location = new Point(425, 157);
            editKnocked.Name = "editKnocked";
            editKnocked.Size = new Size(94, 29);
            editKnocked.TabIndex = 1;
            editKnocked.Text = "Edit";
            editKnocked.UseVisualStyleBackColor = true;
            // 
            // editFirst
            // 
            editFirst.Location = new Point(425, 233);
            editFirst.Name = "editFirst";
            editFirst.Size = new Size(94, 29);
            editFirst.TabIndex = 2;
            editFirst.Text = "Edit";
            editFirst.UseVisualStyleBackColor = true;
            // 
            // EditDMG
            // 
            EditDMG.Location = new Point(425, 400);
            EditDMG.Name = "EditDMG";
            EditDMG.Size = new Size(94, 29);
            EditDMG.TabIndex = 3;
            EditDMG.Text = "Edit";
            EditDMG.UseVisualStyleBackColor = true;
            // 
            // EditDMGRec
            // 
            EditDMGRec.Location = new Point(425, 491);
            EditDMGRec.Name = "EditDMGRec";
            EditDMGRec.Size = new Size(94, 29);
            EditDMGRec.TabIndex = 4;
            EditDMGRec.Text = "Edit";
            EditDMGRec.UseVisualStyleBackColor = true;
            // 
            // editLooted
            // 
            editLooted.Location = new Point(425, 607);
            editLooted.Name = "editLooted";
            editLooted.Size = new Size(94, 29);
            editLooted.TabIndex = 5;
            editLooted.Text = "Edit";
            editLooted.UseVisualStyleBackColor = true;
            // 
            // textDowned
            // 
            textDowned.Location = new Point(159, 84);
            textDowned.Name = "textDowned";
            textDowned.Size = new Size(125, 27);
            textDowned.TabIndex = 6;
            // 
            // textKnocked
            // 
            textKnocked.Location = new Point(159, 159);
            textKnocked.Name = "textKnocked";
            textKnocked.Size = new Size(125, 27);
            textKnocked.TabIndex = 7;
            // 
            // textRev
            // 
            textRev.Location = new Point(159, 314);
            textRev.Name = "textRev";
            textRev.Size = new Size(125, 27);
            textRev.TabIndex = 8;
            // 
            // textDMG
            // 
            textDMG.Location = new Point(159, 402);
            textDMG.Name = "textDMG";
            textDMG.Size = new Size(125, 27);
            textDMG.TabIndex = 9;
            // 
            // textDMGRec
            // 
            textDMGRec.Location = new Point(159, 493);
            textDMGRec.Name = "textDMGRec";
            textDMGRec.Size = new Size(125, 27);
            textDMGRec.TabIndex = 10;
            // 
            // textLooted
            // 
            textLooted.Location = new Point(159, 609);
            textLooted.Name = "textLooted";
            textLooted.Size = new Size(125, 27);
            textLooted.TabIndex = 11;
            // 
            // editRev
            // 
            editRev.Location = new Point(425, 312);
            editRev.Name = "editRev";
            editRev.Size = new Size(94, 29);
            editRev.TabIndex = 12;
            editRev.Text = "Edit";
            editRev.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 235);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 13;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 828);
            Controls.Add(textBox1);
            Controls.Add(editRev);
            Controls.Add(textLooted);
            Controls.Add(textDMGRec);
            Controls.Add(textDMG);
            Controls.Add(textRev);
            Controls.Add(textKnocked);
            Controls.Add(textDowned);
            Controls.Add(editLooted);
            Controls.Add(EditDMGRec);
            Controls.Add(EditDMG);
            Controls.Add(editFirst);
            Controls.Add(editKnocked);
            Controls.Add(editDowned);
            Name = "Settings";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button editDowned;
        private Button editKnocked;
        private Button editFirst;
        private Button EditDMG;
        private Button EditDMGRec;
        private Button editLooted;
        private TextBox textDowned;
        private TextBox textKnocked;
        private TextBox textRev;
        private TextBox textDMG;
        private TextBox textDMGRec;
        private TextBox textLooted;
        private Button editRev;
        private TextBox textBox1;
    }
}