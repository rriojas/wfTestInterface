namespace wfTestInterface
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
      label1 = new Label();
      txtName = new TextBox();
      btnSpeak = new Button();
      txtSpecie = new TextBox();
      label2 = new Label();
      txtSound = new TextBox();
      label3 = new Label();
      lblSpeak = new Label();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 20F);
      label1.Location = new Point(25, 95);
      label1.Name = "label1";
      label1.Size = new Size(94, 37);
      label1.TabIndex = 0;
      label1.Text = "Name:";
      // 
      // txtName
      // 
      txtName.Font = new Font("Segoe UI", 20F);
      txtName.Location = new Point(130, 89);
      txtName.Name = "txtName";
      txtName.Size = new Size(253, 43);
      txtName.TabIndex = 1;
      // 
      // btnSpeak
      // 
      btnSpeak.Font = new Font("Segoe UI", 20F);
      btnSpeak.Location = new Point(246, 275);
      btnSpeak.Name = "btnSpeak";
      btnSpeak.Size = new Size(137, 53);
      btnSpeak.TabIndex = 2;
      btnSpeak.Text = "Speak";
      btnSpeak.UseVisualStyleBackColor = true;
      btnSpeak.Click += btnSpeak_Click;
      // 
      // txtSpecie
      // 
      txtSpecie.Font = new Font("Segoe UI", 20F);
      txtSpecie.Location = new Point(130, 141);
      txtSpecie.Name = "txtSpecie";
      txtSpecie.Size = new Size(253, 43);
      txtSpecie.TabIndex = 4;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI", 20F);
      label2.Location = new Point(25, 144);
      label2.Name = "label2";
      label2.Size = new Size(100, 37);
      label2.TabIndex = 3;
      label2.Text = "Specie:";
      // 
      // txtSound
      // 
      txtSound.Font = new Font("Segoe UI", 20F);
      txtSound.Location = new Point(130, 196);
      txtSound.Name = "txtSound";
      txtSound.Size = new Size(253, 43);
      txtSound.TabIndex = 6;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Font = new Font("Segoe UI", 20F);
      label3.Location = new Point(25, 196);
      label3.Name = "label3";
      label3.Size = new Size(99, 37);
      label3.TabIndex = 5;
      label3.Text = "Sound:";
      // 
      // lblSpeak
      // 
      lblSpeak.AutoSize = true;
      lblSpeak.Font = new Font("Segoe UI", 20F);
      lblSpeak.Location = new Point(149, 352);
      lblSpeak.Name = "lblSpeak";
      lblSpeak.Size = new Size(0, 37);
      lblSpeak.TabIndex = 7;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(lblSpeak);
      Controls.Add(txtSound);
      Controls.Add(label3);
      Controls.Add(txtSpecie);
      Controls.Add(label2);
      Controls.Add(btnSpeak);
      Controls.Add(txtName);
      Controls.Add(label1);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtName;
    private Button btnSpeak;
    private TextBox txtSpecie;
    private Label label2;
    private TextBox txtSound;
    private Label label3;
    private Label lblSpeak;
  }
}
