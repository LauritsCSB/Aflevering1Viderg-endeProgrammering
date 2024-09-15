namespace Aflevering1VidergåendeProgrammering
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
            txtBoxNavn = new TextBox();
            txtBoxPosition = new TextBox();
            lblNavn = new Label();
            btnNavn = new Button();
            lblPosition = new Label();
            btnPosition = new Button();
            listBoxNavne = new ListBox();
            lblListBox = new Label();
            btnOpdater = new Button();
            SuspendLayout();
            // 
            // txtBoxNavn
            // 
            txtBoxNavn.Location = new Point(95, 82);
            txtBoxNavn.Name = "txtBoxNavn";
            txtBoxNavn.Size = new Size(303, 23);
            txtBoxNavn.TabIndex = 0;
            // 
            // txtBoxPosition
            // 
            txtBoxPosition.Location = new Point(95, 179);
            txtBoxPosition.Name = "txtBoxPosition";
            txtBoxPosition.Size = new Size(100, 23);
            txtBoxPosition.TabIndex = 1;
            // 
            // lblNavn
            // 
            lblNavn.AutoSize = true;
            lblNavn.Location = new Point(51, 85);
            lblNavn.Name = "lblNavn";
            lblNavn.Size = new Size(38, 15);
            lblNavn.TabIndex = 2;
            lblNavn.Text = "Navn:";
            // 
            // btnNavn
            // 
            btnNavn.Location = new Point(95, 111);
            btnNavn.Name = "btnNavn";
            btnNavn.Size = new Size(85, 23);
            btnNavn.TabIndex = 3;
            btnNavn.Text = "Tilføj navn";
            btnNavn.UseVisualStyleBackColor = true;
            btnNavn.Click += btnNavn_Click;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(36, 182);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(53, 15);
            lblPosition.TabIndex = 4;
            lblPosition.Text = "Position:";
            // 
            // btnPosition
            // 
            btnPosition.Location = new Point(95, 208);
            btnPosition.Name = "btnPosition";
            btnPosition.Size = new Size(85, 23);
            btnPosition.TabIndex = 5;
            btnPosition.Text = "Slet position";
            btnPosition.UseVisualStyleBackColor = true;
            btnPosition.Click += btnPosition_Click;
            // 
            // listBoxNavne
            // 
            listBoxNavne.FormattingEnabled = true;
            listBoxNavne.ItemHeight = 15;
            listBoxNavne.Location = new Point(515, 82);
            listBoxNavne.Name = "listBoxNavne";
            listBoxNavne.Size = new Size(169, 259);
            listBoxNavne.TabIndex = 6;
            listBoxNavne.SelectedIndexChanged += listBoxNavne_SelectedIndexChanged;
            // 
            // lblListBox
            // 
            lblListBox.AutoSize = true;
            lblListBox.Location = new Point(515, 64);
            lblListBox.Name = "lblListBox";
            lblListBox.Size = new Size(44, 15);
            lblListBox.TabIndex = 7;
            lblListBox.Text = "Navne:";
            // 
            // btnOpdater
            // 
            btnOpdater.Location = new Point(515, 347);
            btnOpdater.Name = "btnOpdater";
            btnOpdater.Size = new Size(75, 23);
            btnOpdater.TabIndex = 8;
            btnOpdater.Text = "Opdater";
            btnOpdater.UseVisualStyleBackColor = true;
            btnOpdater.Click += btnOpdater_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpdater);
            Controls.Add(lblListBox);
            Controls.Add(listBoxNavne);
            Controls.Add(btnPosition);
            Controls.Add(lblPosition);
            Controls.Add(btnNavn);
            Controls.Add(lblNavn);
            Controls.Add(txtBoxPosition);
            Controls.Add(txtBoxNavn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxNavn;
        private TextBox txtBoxPosition;
        private Label lblNavn;
        private Button btnNavn;
        private Label lblPosition;
        private Button btnPosition;
        private ListBox listBoxNavne;
        private Label lblListBox;
        private Button btnOpdater;
    }
}
