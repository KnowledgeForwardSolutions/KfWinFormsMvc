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
      _colorsListBox = new ListBox();
      _colorLabel = new Label();
      _rgbLabel = new Label();
      _rgbDisplayLabel = new Label();
      SuspendLayout();
      // 
      // _dieTypeComboBox
      // 
      _dieTypeComboBox.DisplayMember = "Description";
      _dieTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      _dieTypeComboBox.FormattingEnabled = true;
      _dieTypeComboBox.Location = new Point(99, 11);
      _dieTypeComboBox.Name = "_dieTypeComboBox";
      _dieTypeComboBox.Size = new Size(168, 29);
      _dieTypeComboBox.TabIndex = 0;
      _dieTypeComboBox.ValueMember = "DieType";
      // 
      // _dieTypeLabel
      // 
      _dieTypeLabel.AutoSize = true;
      _dieTypeLabel.Location = new Point(21, 14);
      _dieTypeLabel.Name = "_dieTypeLabel";
      _dieTypeLabel.Size = new Size(72, 21);
      _dieTypeLabel.TabIndex = 1;
      _dieTypeLabel.Text = "Die Type:";
      // 
      // _numSidesLabel
      // 
      _numSidesLabel.AutoSize = true;
      _numSidesLabel.Location = new Point(12, 60);
      _numSidesLabel.Name = "_numSidesLabel";
      _numSidesLabel.Size = new Size(81, 21);
      _numSidesLabel.TabIndex = 2;
      _numSidesLabel.Text = "# of Sides:";
      // 
      // _numSidesDisplayLabel
      // 
      _numSidesDisplayLabel.BorderStyle = BorderStyle.FixedSingle;
      _numSidesDisplayLabel.Location = new Point(99, 56);
      _numSidesDisplayLabel.Name = "_numSidesDisplayLabel";
      _numSidesDisplayLabel.Size = new Size(168, 29);
      _numSidesDisplayLabel.TabIndex = 5;
      _numSidesDisplayLabel.Text = "label1";
      _numSidesDisplayLabel.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // _d6Button
      // 
      _d6Button.Location = new Point(99, 436);
      _d6Button.Name = "_d6Button";
      _d6Button.Size = new Size(100, 40);
      _d6Button.TabIndex = 7;
      _d6Button.Text = "D6";
      _d6Button.UseVisualStyleBackColor = true;
      // 
      // _clearAllButton
      // 
      _clearAllButton.Location = new Point(99, 499);
      _clearAllButton.Name = "_clearAllButton";
      _clearAllButton.Size = new Size(100, 40);
      _clearAllButton.TabIndex = 8;
      _clearAllButton.Text = "Clear All";
      _clearAllButton.UseVisualStyleBackColor = true;
      _clearAllButton.Click += _clearAllButton_Click;
      // 
      // _colorsListBox
      // 
      _colorsListBox.FormattingEnabled = true;
      _colorsListBox.ItemHeight = 21;
      _colorsListBox.Location = new Point(99, 101);
      _colorsListBox.Name = "_colorsListBox";
      _colorsListBox.Size = new Size(168, 151);
      _colorsListBox.TabIndex = 9;
      // 
      // _colorLabel
      // 
      _colorLabel.AutoSize = true;
      _colorLabel.Location = new Point(42, 101);
      _colorLabel.Name = "_colorLabel";
      _colorLabel.Size = new Size(51, 21);
      _colorLabel.TabIndex = 10;
      _colorLabel.Text = "Color:";
      // 
      // _rgbLabel
      // 
      _rgbLabel.AutoSize = true;
      _rgbLabel.Location = new Point(44, 272);
      _rgbLabel.Name = "_rgbLabel";
      _rgbLabel.Size = new Size(49, 21);
      _rgbLabel.TabIndex = 11;
      _rgbLabel.Text = "R,G,B:";
      // 
      // _rgbDisplayLabel
      // 
      _rgbDisplayLabel.BorderStyle = BorderStyle.FixedSingle;
      _rgbDisplayLabel.Location = new Point(99, 268);
      _rgbDisplayLabel.Name = "_rgbDisplayLabel";
      _rgbDisplayLabel.Size = new Size(168, 29);
      _rgbDisplayLabel.TabIndex = 12;
      _rgbDisplayLabel.Text = "label1";
      _rgbDisplayLabel.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(9F, 21F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(784, 561);
      Controls.Add(_rgbDisplayLabel);
      Controls.Add(_rgbLabel);
      Controls.Add(_colorLabel);
      Controls.Add(_colorsListBox);
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
   private ListBox _colorsListBox;
   private Label _colorLabel;
   private Label _rgbLabel;
   private Label _rgbDisplayLabel;
}
