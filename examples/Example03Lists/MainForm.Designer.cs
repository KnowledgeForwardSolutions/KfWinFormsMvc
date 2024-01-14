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
      components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
      _materialsListBox = new ListBox();
      _materialsLabel = new Label();
      _selectedMaterialsDisplayLabel = new Label();
      _selectedMaterialsLabel = new Label();
      _detailsPanel = new Panel();
      label5 = new Label();
      label4 = new Label();
      label3 = new Label();
      label1 = new Label();
      label2 = new Label();
      _details1Label = new Label();
      _detailsLabel = new Label();
      imageList1 = new ImageList(components);
      label6 = new Label();
      label7 = new Label();
      _detailsPanel.SuspendLayout();
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
      _d6Button.Location = new Point(99, 641);
      _d6Button.Name = "_d6Button";
      _d6Button.Size = new Size(100, 40);
      _d6Button.TabIndex = 7;
      _d6Button.Text = "D6";
      _d6Button.UseVisualStyleBackColor = true;
      // 
      // _clearAllButton
      // 
      _clearAllButton.Location = new Point(99, 709);
      _clearAllButton.Name = "_clearAllButton";
      _clearAllButton.Size = new Size(100, 40);
      _clearAllButton.TabIndex = 8;
      _clearAllButton.Text = "Clear All";
      _clearAllButton.UseVisualStyleBackColor = true;
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
      // _materialsListBox
      // 
      _materialsListBox.FormattingEnabled = true;
      _materialsListBox.ItemHeight = 21;
      _materialsListBox.Location = new Point(99, 313);
      _materialsListBox.Name = "_materialsListBox";
      _materialsListBox.SelectionMode = SelectionMode.MultiExtended;
      _materialsListBox.Size = new Size(168, 235);
      _materialsListBox.TabIndex = 13;
      // 
      // _materialsLabel
      // 
      _materialsLabel.Location = new Point(16, 313);
      _materialsLabel.Name = "_materialsLabel";
      _materialsLabel.Size = new Size(77, 45);
      _materialsLabel.TabIndex = 14;
      _materialsLabel.Text = "Available Materials:";
      // 
      // _selectedMaterialsDisplayLabel
      // 
      _selectedMaterialsDisplayLabel.BorderStyle = BorderStyle.FixedSingle;
      _selectedMaterialsDisplayLabel.Location = new Point(99, 564);
      _selectedMaterialsDisplayLabel.Name = "_selectedMaterialsDisplayLabel";
      _selectedMaterialsDisplayLabel.Size = new Size(168, 58);
      _selectedMaterialsDisplayLabel.TabIndex = 15;
      _selectedMaterialsDisplayLabel.Text = "label1";
      // 
      // _selectedMaterialsLabel
      // 
      _selectedMaterialsLabel.AutoSize = true;
      _selectedMaterialsLabel.Location = new Point(16, 568);
      _selectedMaterialsLabel.Name = "_selectedMaterialsLabel";
      _selectedMaterialsLabel.Size = new Size(77, 21);
      _selectedMaterialsLabel.TabIndex = 16;
      _selectedMaterialsLabel.Text = "Materials:";
      // 
      // _detailsPanel
      // 
      _detailsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      _detailsPanel.Controls.Add(label7);
      _detailsPanel.Controls.Add(label6);
      _detailsPanel.Controls.Add(label5);
      _detailsPanel.Controls.Add(label4);
      _detailsPanel.Controls.Add(label3);
      _detailsPanel.Controls.Add(label1);
      _detailsPanel.Controls.Add(label2);
      _detailsPanel.Controls.Add(_details1Label);
      _detailsPanel.Controls.Add(_detailsLabel);
      _detailsPanel.Location = new Point(302, 11);
      _detailsPanel.Name = "_detailsPanel";
      _detailsPanel.Size = new Size(870, 670);
      _detailsPanel.TabIndex = 17;
      // 
      // label5
      // 
      label5.Location = new Point(3, 346);
      label5.Name = "label5";
      label5.Size = new Size(864, 45);
      label5.TabIndex = 13;
      label5.Text = "Materials - Custom view binding Label to model SelectedMaterials property with overridden handler to display concatonated list of material names\r\n\r\n";
      // 
      // label4
      // 
      label4.Location = new Point(3, 264);
      label4.Name = "label4";
      label4.Size = new Size(864, 66);
      label4.TabIndex = 12;
      label4.Text = resources.GetString("label4.Text");
      // 
      // label3
      // 
      label3.Location = new Point(3, 203);
      label3.Name = "label3";
      label3.Size = new Size(864, 45);
      label3.TabIndex = 11;
      label3.Text = "R,G,B- Custom view binding Label to model SelectedColor property with overridden handler to display the R,G,B values for the selected color\r\n\r\n";
      // 
      // label1
      // 
      label1.Location = new Point(3, 142);
      label1.Name = "label1";
      label1.Size = new Size(864, 45);
      label1.TabIndex = 10;
      label1.Text = "Colors - custom view/controller derived from SingleSelectListBoxViewController that binds ListBox to model SelectedColor property. Overrides GetItems method to provide fixed list of colors\r\n\r\n";
      // 
      // label2
      // 
      label2.Location = new Point(3, 81);
      label2.Name = "label2";
      label2.Size = new Size(864, 45);
      label2.TabIndex = 9;
      label2.Text = "# of Sides - Custom view binding Label to model SelectedDieType property with overridden handler to display the number of sides for the selected die type\r\n\r\n";
      // 
      // _details1Label
      // 
      _details1Label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      _details1Label.Location = new Point(3, 40);
      _details1Label.Name = "_details1Label";
      _details1Label.Size = new Size(864, 25);
      _details1Label.TabIndex = 2;
      _details1Label.Text = "DieType - DropDownListViewController binding ComboBox to model DieTypes property and SelectedDieType propeorty\r\n";
      // 
      // _detailsLabel
      // 
      _detailsLabel.AutoSize = true;
      _detailsLabel.Location = new Point(3, 3);
      _detailsLabel.Name = "_detailsLabel";
      _detailsLabel.Size = new Size(60, 21);
      _detailsLabel.TabIndex = 1;
      _detailsLabel.Text = "Details:";
      // 
      // imageList1
      // 
      imageList1.ColorDepth = ColorDepth.Depth32Bit;
      imageList1.ImageSize = new Size(16, 16);
      imageList1.TransparentColor = Color.Transparent;
      // 
      // label6
      // 
      label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      label6.Location = new Point(3, 407);
      label6.Name = "label6";
      label6.Size = new Size(864, 25);
      label6.TabIndex = 18;
      label6.Text = "D6 - ClickController that binds Button Click event to model D6 method";
      // 
      // label7
      // 
      label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      label7.Location = new Point(3, 448);
      label7.Name = "label7";
      label7.Size = new Size(864, 25);
      label7.TabIndex = 19;
      label7.Text = "ClearAll - ClickController that binds Button Click event to model ClearAll method";
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(9F, 21F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1184, 761);
      Controls.Add(_detailsPanel);
      Controls.Add(_selectedMaterialsLabel);
      Controls.Add(_selectedMaterialsDisplayLabel);
      Controls.Add(_materialsLabel);
      Controls.Add(_materialsListBox);
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
      _detailsPanel.ResumeLayout(false);
      _detailsPanel.PerformLayout();
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
   private ListBox _materialsListBox;
   private Label _materialsLabel;
   private Label _selectedMaterialsDisplayLabel;
   private Label _selectedMaterialsLabel;
   private Panel _detailsPanel;
   private Label _detailsLabel;
   private Label _details1Label;
   private Label label2;
   private Label label1;
   private Label label3;
   private Label label4;
   private Label label5;
   private Label label6;
   private ImageList imageList1;
   private Label label7;
}
