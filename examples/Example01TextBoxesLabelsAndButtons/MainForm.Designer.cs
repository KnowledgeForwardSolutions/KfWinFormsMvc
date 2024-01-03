namespace Example01TextBoxesLabelsAndButtons;

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
      _firstNameTextBox = new TextBox();
      _firstNameLabel = new Label();
      _lastNameTextBox = new TextBox();
      _lastNameLabel = new Label();
      _fullNameDisplayLabel = new Label();
      _fullNameLabel = new Label();
      _clearAllButton = new Button();
      _detailsPanel = new Panel();
      _detailsLabel = new Label();
      _details1Label = new Label();
      _details2Label = new Label();
      label1 = new Label();
      label2 = new Label();
      _detailsPanel.SuspendLayout();
      SuspendLayout();
      // 
      // _firstNameTextBox
      // 
      _firstNameTextBox.Location = new Point(107, 12);
      _firstNameTextBox.Name = "_firstNameTextBox";
      _firstNameTextBox.Size = new Size(150, 29);
      _firstNameTextBox.TabIndex = 0;
      // 
      // _firstNameLabel
      // 
      _firstNameLabel.AutoSize = true;
      _firstNameLabel.Location = new Point(12, 15);
      _firstNameLabel.Name = "_firstNameLabel";
      _firstNameLabel.Size = new Size(89, 21);
      _firstNameLabel.TabIndex = 1;
      _firstNameLabel.Text = "First Name:";
      // 
      // _lastNameTextBox
      // 
      _lastNameTextBox.Location = new Point(107, 55);
      _lastNameTextBox.Name = "_lastNameTextBox";
      _lastNameTextBox.Size = new Size(150, 29);
      _lastNameTextBox.TabIndex = 2;
      // 
      // _lastNameLabel
      // 
      _lastNameLabel.AutoSize = true;
      _lastNameLabel.Location = new Point(14, 58);
      _lastNameLabel.Name = "_lastNameLabel";
      _lastNameLabel.Size = new Size(87, 21);
      _lastNameLabel.TabIndex = 3;
      _lastNameLabel.Text = "Last Name:";
      // 
      // _fullNameDisplayLabel
      // 
      _fullNameDisplayLabel.BorderStyle = BorderStyle.FixedSingle;
      _fullNameDisplayLabel.Location = new Point(107, 95);
      _fullNameDisplayLabel.Name = "_fullNameDisplayLabel";
      _fullNameDisplayLabel.Size = new Size(150, 29);
      _fullNameDisplayLabel.TabIndex = 4;
      _fullNameDisplayLabel.Text = "label1";
      _fullNameDisplayLabel.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // _fullNameLabel
      // 
      _fullNameLabel.AutoSize = true;
      _fullNameLabel.Location = new Point(17, 99);
      _fullNameLabel.Name = "_fullNameLabel";
      _fullNameLabel.Size = new Size(84, 21);
      _fullNameLabel.TabIndex = 5;
      _fullNameLabel.Text = "Full Name:";
      // 
      // _clearAllButton
      // 
      _clearAllButton.Location = new Point(91, 151);
      _clearAllButton.Name = "_clearAllButton";
      _clearAllButton.Size = new Size(100, 40);
      _clearAllButton.TabIndex = 6;
      _clearAllButton.Text = "Clear All";
      _clearAllButton.UseVisualStyleBackColor = true;
      // 
      // _detailsPanel
      // 
      _detailsPanel.Controls.Add(label2);
      _detailsPanel.Controls.Add(label1);
      _detailsPanel.Controls.Add(_details2Label);
      _detailsPanel.Controls.Add(_details1Label);
      _detailsPanel.Controls.Add(_detailsLabel);
      _detailsPanel.Location = new Point(300, 12);
      _detailsPanel.Name = "_detailsPanel";
      _detailsPanel.Size = new Size(272, 337);
      _detailsPanel.TabIndex = 7;
      // 
      // _detailsLabel
      // 
      _detailsLabel.AutoSize = true;
      _detailsLabel.Location = new Point(3, 8);
      _detailsLabel.Name = "_detailsLabel";
      _detailsLabel.Size = new Size(60, 21);
      _detailsLabel.TabIndex = 0;
      _detailsLabel.Text = "Details:";
      // 
      // _details1Label
      // 
      _details1Label.Location = new Point(3, 43);
      _details1Label.Name = "_details1Label";
      _details1Label.Size = new Size(266, 45);
      _details1Label.TabIndex = 1;
      _details1Label.Text = "TextViewController binding TextBox to model FirstName property";
      // 
      // _details2Label
      // 
      _details2Label.Location = new Point(3, 112);
      _details2Label.Name = "_details2Label";
      _details2Label.Size = new Size(266, 45);
      _details2Label.TabIndex = 2;
      _details2Label.Text = "TextViewController binding TextBox to model LastName property";
      // 
      // label1
      // 
      label1.Location = new Point(3, 181);
      label1.Name = "label1";
      label1.Size = new Size(266, 45);
      label1.TabIndex = 3;
      label1.Text = "TextView binding Label to model FirstName and LastName properties";
      // 
      // label2
      // 
      label2.Location = new Point(3, 250);
      label2.Name = "label2";
      label2.Size = new Size(266, 45);
      label2.TabIndex = 4;
      label2.Text = "ClickController binding Button to model ClearAll method\r\n";
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(9F, 21F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.Control;
      ClientSize = new Size(584, 361);
      Controls.Add(_detailsPanel);
      Controls.Add(_clearAllButton);
      Controls.Add(_fullNameLabel);
      Controls.Add(_fullNameDisplayLabel);
      Controls.Add(_lastNameLabel);
      Controls.Add(_lastNameTextBox);
      Controls.Add(_firstNameLabel);
      Controls.Add(_firstNameTextBox);
      Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      Margin = new Padding(4, 4, 4, 4);
      Name = "MainForm";
      Text = "KfWinFormsMvc Example 01 - Text and Buttons";
      _detailsPanel.ResumeLayout(false);
      _detailsPanel.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
   }

   #endregion

   private TextBox _firstNameTextBox;
   private Label _firstNameLabel;
   private TextBox _lastNameTextBox;
   private Label _lastNameLabel;
   private Label _fullNameDisplayLabel;
   private Label _fullNameLabel;
   private Button _clearAllButton;
   private Panel _detailsPanel;
   private Label _details2Label;
   private Label _details1Label;
   private Label _detailsLabel;
   private Label label2;
   private Label label1;
}
