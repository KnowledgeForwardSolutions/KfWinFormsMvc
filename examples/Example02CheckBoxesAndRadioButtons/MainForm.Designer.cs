// Ignore Spelling: Sms

namespace Example02CheckBoxesAndRadioButtons;

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
      _group1 = new GroupBox();
      _subscribeToSmsTextOffersCheckBox = new CheckBox();
      _phoneNumberTextBox = new TextBox();
      _phoneNumberLabel = new Label();
      _subscribeToEmailOffersCheckBox = new CheckBox();
      _emailLabel = new Label();
      _emailAddressTextBox = new TextBox();
      _detailsPanel = new Panel();
      label1 = new Label();
      label2 = new Label();
      _detailsLabel7 = new Label();
      _detailsLabel6 = new Label();
      _detailsLabel5 = new Label();
      _detailsLabel4 = new Label();
      _detailsLabel3 = new Label();
      _details2Label = new Label();
      _details1Label = new Label();
      _detailsLabel = new Label();
      _group2 = new GroupBox();
      _shippingCostDisplayLabel = new Label();
      _shippingCostLabel = new Label();
      _shippingSpeedLabel = new Label();
      _overnightShippingRadioButton = new RadioButton();
      _secondDayAirShippingRadioButton = new RadioButton();
      _groundShippingRadioButton = new RadioButton();
      _clearAllButton = new Button();
      _group1.SuspendLayout();
      _detailsPanel.SuspendLayout();
      _group2.SuspendLayout();
      SuspendLayout();
      // 
      // _group1
      // 
      _group1.Controls.Add(_subscribeToSmsTextOffersCheckBox);
      _group1.Controls.Add(_phoneNumberTextBox);
      _group1.Controls.Add(_phoneNumberLabel);
      _group1.Controls.Add(_subscribeToEmailOffersCheckBox);
      _group1.Controls.Add(_emailLabel);
      _group1.Controls.Add(_emailAddressTextBox);
      _group1.Location = new Point(12, 12);
      _group1.Name = "_group1";
      _group1.Size = new Size(393, 165);
      _group1.TabIndex = 0;
      _group1.TabStop = false;
      _group1.Text = "Contact Info";
      // 
      // _subscribeToSmsTextOffersCheckBox
      // 
      _subscribeToSmsTextOffersCheckBox.AutoSize = true;
      _subscribeToSmsTextOffersCheckBox.Location = new Point(131, 129);
      _subscribeToSmsTextOffersCheckBox.Name = "_subscribeToSmsTextOffersCheckBox";
      _subscribeToSmsTextOffersCheckBox.Size = new Size(224, 25);
      _subscribeToSmsTextOffersCheckBox.TabIndex = 5;
      _subscribeToSmsTextOffersCheckBox.Text = "Subscribe to SMS text offers";
      _subscribeToSmsTextOffersCheckBox.UseVisualStyleBackColor = true;
      // 
      // _phoneNumberTextBox
      // 
      _phoneNumberTextBox.Location = new Point(131, 94);
      _phoneNumberTextBox.Name = "_phoneNumberTextBox";
      _phoneNumberTextBox.Size = new Size(151, 29);
      _phoneNumberTextBox.TabIndex = 4;
      // 
      // _phoneNumberLabel
      // 
      _phoneNumberLabel.AutoSize = true;
      _phoneNumberLabel.Location = new Point(6, 97);
      _phoneNumberLabel.Name = "_phoneNumberLabel";
      _phoneNumberLabel.Size = new Size(119, 21);
      _phoneNumberLabel.TabIndex = 3;
      _phoneNumberLabel.Text = "Phone Number:";
      // 
      // _subscribeToEmailOffersCheckBox
      // 
      _subscribeToEmailOffersCheckBox.AutoSize = true;
      _subscribeToEmailOffersCheckBox.Location = new Point(131, 63);
      _subscribeToEmailOffersCheckBox.Name = "_subscribeToEmailOffersCheckBox";
      _subscribeToEmailOffersCheckBox.Size = new Size(201, 25);
      _subscribeToEmailOffersCheckBox.TabIndex = 2;
      _subscribeToEmailOffersCheckBox.Text = "Subscribe to email offers";
      _subscribeToEmailOffersCheckBox.UseVisualStyleBackColor = true;
      // 
      // _emailLabel
      // 
      _emailLabel.AutoSize = true;
      _emailLabel.Location = new Point(14, 31);
      _emailLabel.Name = "_emailLabel";
      _emailLabel.Size = new Size(111, 21);
      _emailLabel.TabIndex = 1;
      _emailLabel.Text = "Email Address:";
      // 
      // _emailAddressTextBox
      // 
      _emailAddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      _emailAddressTextBox.Location = new Point(131, 28);
      _emailAddressTextBox.Name = "_emailAddressTextBox";
      _emailAddressTextBox.Size = new Size(256, 29);
      _emailAddressTextBox.TabIndex = 0;
      // 
      // _detailsPanel
      // 
      _detailsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      _detailsPanel.Controls.Add(label1);
      _detailsPanel.Controls.Add(label2);
      _detailsPanel.Controls.Add(_detailsLabel7);
      _detailsPanel.Controls.Add(_detailsLabel6);
      _detailsPanel.Controls.Add(_detailsLabel5);
      _detailsPanel.Controls.Add(_detailsLabel4);
      _detailsPanel.Controls.Add(_detailsLabel3);
      _detailsPanel.Controls.Add(_details2Label);
      _detailsPanel.Controls.Add(_details1Label);
      _detailsPanel.Controls.Add(_detailsLabel);
      _detailsPanel.Location = new Point(447, 12);
      _detailsPanel.Name = "_detailsPanel";
      _detailsPanel.Size = new Size(625, 577);
      _detailsPanel.TabIndex = 8;
      // 
      // label1
      // 
      label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      label1.Location = new Point(3, 522);
      label1.Name = "label1";
      label1.Size = new Size(619, 25);
      label1.TabIndex = 9;
      label1.Text = "ClickController binding Button to model ClearAll method\r\n";
      // 
      // label2
      // 
      label2.Location = new Point(3, 461);
      label2.Name = "label2";
      label2.Size = new Size(619, 45);
      label2.TabIndex = 8;
      label2.Text = "Custom view binding Label to model ShippingSpeed property with overridden handler to display ShippingSpeed instead\r\n\r\n";
      // 
      // _detailsLabel7
      // 
      _detailsLabel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      _detailsLabel7.Location = new Point(3, 400);
      _detailsLabel7.Name = "_detailsLabel7";
      _detailsLabel7.Size = new Size(619, 45);
      _detailsLabel7.TabIndex = 7;
      _detailsLabel7.Text = "RadioButtonViewController binding RadioButton to model ShippingSpeed property (value = ShippingSpeed.Overnight)\r\n";
      // 
      // _detailsLabel6
      // 
      _detailsLabel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      _detailsLabel6.Location = new Point(3, 339);
      _detailsLabel6.Name = "_detailsLabel6";
      _detailsLabel6.Size = new Size(619, 45);
      _detailsLabel6.TabIndex = 6;
      _detailsLabel6.Text = "RadioButtonViewController binding RadioButton to model ShippingSpeed property (value = ShippingSpeed.SecondDayAir)\r\n";
      // 
      // _detailsLabel5
      // 
      _detailsLabel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      _detailsLabel5.Location = new Point(3, 278);
      _detailsLabel5.Name = "_detailsLabel5";
      _detailsLabel5.Size = new Size(619, 45);
      _detailsLabel5.TabIndex = 5;
      _detailsLabel5.Text = "RadioButtonViewController binding RadioButton to model ShippingSpeed property (value = ShippingSpeed.Ground)\r\n";
      // 
      // _detailsLabel4
      // 
      _detailsLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      _detailsLabel4.Location = new Point(3, 186);
      _detailsLabel4.Name = "_detailsLabel4";
      _detailsLabel4.Size = new Size(619, 45);
      _detailsLabel4.TabIndex = 4;
      _detailsLabel4.Text = "Custom view/contoller binding CheckBox to model SubscribeToSmsTextOffers property with additional handler to enable/disable upon PhoneNumber changes\r\n";
      // 
      // _detailsLabel3
      // 
      _detailsLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      _detailsLabel3.Location = new Point(3, 145);
      _detailsLabel3.Name = "_detailsLabel3";
      _detailsLabel3.Size = new Size(619, 25);
      _detailsLabel3.TabIndex = 3;
      _detailsLabel3.Text = "TextViewController binding TextBox to model PhoneNumber property";
      // 
      // _details2Label
      // 
      _details2Label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      _details2Label.Location = new Point(3, 84);
      _details2Label.Name = "_details2Label";
      _details2Label.Size = new Size(619, 49);
      _details2Label.TabIndex = 2;
      _details2Label.Text = "Custom view/contoller binding CheckBox to model SubscribeToEmailOffers property with additional handler to enable/disable upon EmailAddress changes\r\n";
      // 
      // _details1Label
      // 
      _details1Label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      _details1Label.Location = new Point(3, 43);
      _details1Label.Name = "_details1Label";
      _details1Label.Size = new Size(619, 25);
      _details1Label.TabIndex = 1;
      _details1Label.Text = "TextViewController binding TextBox to model EmailAddress property";
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
      // _group2
      // 
      _group2.Controls.Add(_shippingCostDisplayLabel);
      _group2.Controls.Add(_shippingCostLabel);
      _group2.Controls.Add(_shippingSpeedLabel);
      _group2.Controls.Add(_overnightShippingRadioButton);
      _group2.Controls.Add(_secondDayAirShippingRadioButton);
      _group2.Controls.Add(_groundShippingRadioButton);
      _group2.Location = new Point(12, 264);
      _group2.Name = "_group2";
      _group2.Size = new Size(393, 184);
      _group2.TabIndex = 9;
      _group2.TabStop = false;
      _group2.Text = "Shipping Info";
      // 
      // _shippingCostDisplayLabel
      // 
      _shippingCostDisplayLabel.BorderStyle = BorderStyle.FixedSingle;
      _shippingCostDisplayLabel.Location = new Point(134, 130);
      _shippingCostDisplayLabel.Name = "_shippingCostDisplayLabel";
      _shippingCostDisplayLabel.Size = new Size(150, 29);
      _shippingCostDisplayLabel.TabIndex = 5;
      _shippingCostDisplayLabel.Text = "label1";
      _shippingCostDisplayLabel.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // _shippingCostLabel
      // 
      _shippingCostLabel.AutoSize = true;
      _shippingCostLabel.Location = new Point(15, 134);
      _shippingCostLabel.Name = "_shippingCostLabel";
      _shippingCostLabel.Size = new Size(110, 21);
      _shippingCostLabel.TabIndex = 4;
      _shippingCostLabel.Text = "Shipping Cost:";
      // 
      // _shippingSpeedLabel
      // 
      _shippingSpeedLabel.AutoSize = true;
      _shippingSpeedLabel.Location = new Point(6, 30);
      _shippingSpeedLabel.Name = "_shippingSpeedLabel";
      _shippingSpeedLabel.Size = new Size(122, 21);
      _shippingSpeedLabel.TabIndex = 3;
      _shippingSpeedLabel.Text = "Shipping Speed:";
      // 
      // _overnightShippingRadioButton
      // 
      _overnightShippingRadioButton.AutoSize = true;
      _overnightShippingRadioButton.Location = new Point(134, 90);
      _overnightShippingRadioButton.Name = "_overnightShippingRadioButton";
      _overnightShippingRadioButton.Size = new Size(98, 25);
      _overnightShippingRadioButton.TabIndex = 2;
      _overnightShippingRadioButton.TabStop = true;
      _overnightShippingRadioButton.Text = "Overnight";
      _overnightShippingRadioButton.UseVisualStyleBackColor = true;
      // 
      // _secondDayAirShippingRadioButton
      // 
      _secondDayAirShippingRadioButton.AutoSize = true;
      _secondDayAirShippingRadioButton.Location = new Point(134, 59);
      _secondDayAirShippingRadioButton.Name = "_secondDayAirShippingRadioButton";
      _secondDayAirShippingRadioButton.Size = new Size(110, 25);
      _secondDayAirShippingRadioButton.TabIndex = 1;
      _secondDayAirShippingRadioButton.TabStop = true;
      _secondDayAirShippingRadioButton.Text = "2nd Day Air";
      _secondDayAirShippingRadioButton.UseVisualStyleBackColor = true;
      // 
      // _groundShippingRadioButton
      // 
      _groundShippingRadioButton.AutoSize = true;
      _groundShippingRadioButton.Location = new Point(134, 28);
      _groundShippingRadioButton.Name = "_groundShippingRadioButton";
      _groundShippingRadioButton.Size = new Size(81, 25);
      _groundShippingRadioButton.TabIndex = 0;
      _groundShippingRadioButton.TabStop = true;
      _groundShippingRadioButton.Text = "Ground";
      _groundShippingRadioButton.UseVisualStyleBackColor = true;
      // 
      // _clearAllButton
      // 
      _clearAllButton.Location = new Point(143, 481);
      _clearAllButton.Name = "_clearAllButton";
      _clearAllButton.Size = new Size(100, 40);
      _clearAllButton.TabIndex = 10;
      _clearAllButton.Text = "Clear All";
      _clearAllButton.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(9F, 21F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1084, 601);
      Controls.Add(_clearAllButton);
      Controls.Add(_group2);
      Controls.Add(_detailsPanel);
      Controls.Add(_group1);
      Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      Margin = new Padding(4);
      Name = "MainForm";
      Text = "KfWinFormsMvc Example 02 - CheckBoxes and RadioButtons";
      _group1.ResumeLayout(false);
      _group1.PerformLayout();
      _detailsPanel.ResumeLayout(false);
      _detailsPanel.PerformLayout();
      _group2.ResumeLayout(false);
      _group2.PerformLayout();
      ResumeLayout(false);
   }

   #endregion

   private GroupBox _group1;
   private CheckBox _subscribeToSmsTextOffersCheckBox;
   private TextBox _phoneNumberTextBox;
   private Label _phoneNumberLabel;
   private CheckBox _subscribeToEmailOffersCheckBox;
   private Label _emailLabel;
   private TextBox _emailAddressTextBox;
   private Panel _detailsPanel;
   private Label _detailsLabel4;
   private Label _detailsLabel3;
   private Label _details2Label;
   private Label _details1Label;
   private Label _detailsLabel;
   private GroupBox _group2;
   private RadioButton _overnightShippingRadioButton;
   private RadioButton _secondDayAirShippingRadioButton;
   private RadioButton _groundShippingRadioButton;
   private Label _shippingCostLabel;
   private Label _shippingSpeedLabel;
   private Label _shippingCostDisplayLabel;
   private Label _detailsLabel7;
   private Label _detailsLabel6;
   private Label _detailsLabel5;
   private Button _clearAllButton;
   private Label label1;
   private Label label2;
}
