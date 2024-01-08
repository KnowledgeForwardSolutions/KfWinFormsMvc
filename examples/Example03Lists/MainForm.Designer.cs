namespace Example03Lists;

partial class MainForm
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
      _dieTypeComboBox = new ComboBox();
      _dieTypeLabel = new Label();
      _numSidesLabel = new Label();
      _numSidesDisplayLabel = new Label();
      _d6Button = new Button();
      _clearAllButton = new Button();
      _d12Button = new Button();
      SuspendLayout();
      // 
      // _dieTypeComboBox
      // 
      _dieTypeComboBox.DisplayMember = "Description";
      _dieTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      _dieTypeComboBox.FormattingEnabled = true;
      _dieTypeComboBox.Location = new Point(99, 12);
      _dieTypeComboBox.Name = "_dieTypeComboBox";
      _dieTypeComboBox.Size = new Size(168, 29);
      _dieTypeComboBox.TabIndex = 0;
      _dieTypeComboBox.ValueMember = "DieType";
      // 
      // _dieTypeLabel
      // 
      _dieTypeLabel.AutoSize = true;
      _dieTypeLabel.Location = new Point(12, 15);
      _dieTypeLabel.Name = "_dieTypeLabel";
      _dieTypeLabel.Size = new Size(72, 21);
      _dieTypeLabel.TabIndex = 1;
      _dieTypeLabel.Text = "Die Type:";
      // 
      // _numSidesLabel
      // 
      _numSidesLabel.AutoSize = true;
      _numSidesLabel.Location = new Point(12, 64);
      _numSidesLabel.Name = "_numSidesLabel";
      _numSidesLabel.Size = new Size(81, 21);
      _numSidesLabel.TabIndex = 2;
      _numSidesLabel.Text = "# of Sides:";
      // 
      // _numSidesDisplayLabel
      // 
      _numSidesDisplayLabel.BorderStyle = BorderStyle.FixedSingle;
      _numSidesDisplayLabel.Location = new Point(99, 60);
      _numSidesDisplayLabel.Name = "_numSidesDisplayLabel";
      _numSidesDisplayLabel.Size = new Size(168, 29);
      _numSidesDisplayLabel.TabIndex = 5;
      _numSidesDisplayLabel.Text = "label1";
      _numSidesDisplayLabel.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // _d6Button
      // 
      _d6Button.Location = new Point(99, 130);
      _d6Button.Name = "_d6Button";
      _d6Button.Size = new Size(100, 40);
      _d6Button.TabIndex = 7;
      _d6Button.Text = "D6";
      _d6Button.UseVisualStyleBackColor = true;
      // 
      // _clearAllButton
      // 
      _clearAllButton.Location = new Point(99, 193);
      _clearAllButton.Name = "_clearAllButton";
      _clearAllButton.Size = new Size(100, 40);
      _clearAllButton.TabIndex = 8;
      _clearAllButton.Text = "Clear All";
      _clearAllButton.UseVisualStyleBackColor = true;
      // 
      // _d12Button
      // 
      _d12Button.Location = new Point(278, 130);
      _d12Button.Name = "_d12Button";
      _d12Button.Size = new Size(100, 40);
      _d12Button.TabIndex = 9;
      _d12Button.Text = "D12";
      _d12Button.UseVisualStyleBackColor = true;
      _d12Button.Click += _d12Button_Click;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(9F, 21F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(784, 561);
      Controls.Add(_d12Button);
      Controls.Add(_clearAllButton);
      Controls.Add(_d6Button);
      Controls.Add(_numSidesDisplayLabel);
      Controls.Add(_numSidesLabel);
      Controls.Add(_dieTypeLabel);
      Controls.Add(_dieTypeComboBox);
      Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      Margin = new Padding(4);
      Name = "MainForm";
      Text = "KfWinFormsMvc Example03 - Lists";
      ResumeLayout(false);
      PerformLayout();
   }

   #endregion

   private ComboBox _dieTypeComboBox;
   private Label _dieTypeLabel;
   private Label _numSidesLabel;
   private Label _numSidesDisplayLabel;
   private Button _d6Button;
   private Button _clearAllButton;
   private Button _d12Button;
}
