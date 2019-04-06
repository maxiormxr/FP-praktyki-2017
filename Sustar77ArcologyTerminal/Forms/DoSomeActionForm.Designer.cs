namespace Sustar77ArcologyTerminal.Forms
{
    partial class DoSomeActionForm
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
            this.produce = new System.Windows.Forms.RadioButton();
            this.propaganda = new System.Windows.Forms.RadioButton();
            this.clean = new System.Windows.Forms.RadioButton();
            this.buildArcology = new System.Windows.Forms.RadioButton();
            this.expandPopulationCapacity = new System.Windows.Forms.RadioButton();
            this.expandFoodCapacity = new System.Windows.Forms.RadioButton();
            this.letsDoThisButton = new System.Windows.Forms.Button();
            this.setParameterTrackBar = new System.Windows.Forms.TrackBar();
            this.weAreReady = new System.Windows.Forms.RadioButton();
            this.restart = new System.Windows.Forms.RadioButton();
            this.parameterValueTextBox = new System.Windows.Forms.TextBox();
            this.importFood = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.setParameterTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // produce
            // 
            this.produce.AutoSize = true;
            this.produce.Location = new System.Drawing.Point(12, 35);
            this.produce.Name = "produce";
            this.produce.Size = new System.Drawing.Size(65, 17);
            this.produce.TabIndex = 1;
            this.produce.TabStop = true;
            this.produce.Text = "Produce";
            this.produce.UseVisualStyleBackColor = true;
            this.produce.CheckedChanged += new System.EventHandler(this.produceRadioButton_CheckedChanged);
            // 
            // propaganda
            // 
            this.propaganda.AutoSize = true;
            this.propaganda.Location = new System.Drawing.Point(12, 58);
            this.propaganda.Name = "propaganda";
            this.propaganda.Size = new System.Drawing.Size(83, 17);
            this.propaganda.TabIndex = 3;
            this.propaganda.TabStop = true;
            this.propaganda.Text = "Propaganda";
            this.propaganda.UseVisualStyleBackColor = true;
            this.propaganda.CheckedChanged += new System.EventHandler(this.propagandaRadioButton_CheckedChanged);
            // 
            // clean
            // 
            this.clean.AutoSize = true;
            this.clean.Location = new System.Drawing.Point(12, 81);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(52, 17);
            this.clean.TabIndex = 2;
            this.clean.TabStop = true;
            this.clean.Text = "Clean";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.CheckedChanged += new System.EventHandler(this.cleanRadioButton_CheckedChanged);
            // 
            // buildArcology
            // 
            this.buildArcology.AutoSize = true;
            this.buildArcology.Location = new System.Drawing.Point(12, 104);
            this.buildArcology.Name = "buildArcology";
            this.buildArcology.Size = new System.Drawing.Size(92, 17);
            this.buildArcology.TabIndex = 5;
            this.buildArcology.TabStop = true;
            this.buildArcology.Text = "Build Arcology";
            this.buildArcology.UseVisualStyleBackColor = true;
            this.buildArcology.CheckedChanged += new System.EventHandler(this.buildArcologyRadioButton_CheckedChanged);
            // 
            // expandPopulationCapacity
            // 
            this.expandPopulationCapacity.AutoSize = true;
            this.expandPopulationCapacity.Location = new System.Drawing.Point(12, 127);
            this.expandPopulationCapacity.Name = "expandPopulationCapacity";
            this.expandPopulationCapacity.Size = new System.Drawing.Size(158, 17);
            this.expandPopulationCapacity.TabIndex = 4;
            this.expandPopulationCapacity.TabStop = true;
            this.expandPopulationCapacity.Text = "Expand Population Capacity";
            this.expandPopulationCapacity.UseVisualStyleBackColor = true;
            this.expandPopulationCapacity.CheckedChanged += new System.EventHandler(this.expandPopulationCapacityRadioButton_CheckedChanged);
            // 
            // expandFoodCapacity
            // 
            this.expandFoodCapacity.AutoSize = true;
            this.expandFoodCapacity.Location = new System.Drawing.Point(12, 150);
            this.expandFoodCapacity.Name = "expandFoodCapacity";
            this.expandFoodCapacity.Size = new System.Drawing.Size(132, 17);
            this.expandFoodCapacity.TabIndex = 7;
            this.expandFoodCapacity.TabStop = true;
            this.expandFoodCapacity.Text = "Expand Food Capacity";
            this.expandFoodCapacity.UseVisualStyleBackColor = true;
            this.expandFoodCapacity.CheckedChanged += new System.EventHandler(this.expandFoodCapacityRadioButton_CheckedChanged);
            // 
            // letsDoThisButton
            // 
            this.letsDoThisButton.Location = new System.Drawing.Point(12, 219);
            this.letsDoThisButton.Name = "letsDoThisButton";
            this.letsDoThisButton.Size = new System.Drawing.Size(132, 31);
            this.letsDoThisButton.TabIndex = 8;
            this.letsDoThisButton.Text = "Let\'s Do This";
            this.letsDoThisButton.UseVisualStyleBackColor = true;
            this.letsDoThisButton.Click += new System.EventHandler(this.letsDoThisButton_Click);
            // 
            // setParameterTrackBar
            // 
            this.setParameterTrackBar.Location = new System.Drawing.Point(176, 35);
            this.setParameterTrackBar.Maximum = 200;
            this.setParameterTrackBar.Minimum = 1;
            this.setParameterTrackBar.Name = "setParameterTrackBar";
            this.setParameterTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.setParameterTrackBar.Size = new System.Drawing.Size(45, 215);
            this.setParameterTrackBar.TabIndex = 9;
            this.setParameterTrackBar.Value = 1;
            this.setParameterTrackBar.Scroll += new System.EventHandler(this.setParameterTrackBar_Scroll);
            // 
            // weAreReady
            // 
            this.weAreReady.AutoSize = true;
            this.weAreReady.Location = new System.Drawing.Point(12, 173);
            this.weAreReady.Name = "weAreReady";
            this.weAreReady.Size = new System.Drawing.Size(94, 17);
            this.weAreReady.TabIndex = 10;
            this.weAreReady.TabStop = true;
            this.weAreReady.Text = "We are Ready";
            this.weAreReady.UseVisualStyleBackColor = true;
            this.weAreReady.CheckedChanged += new System.EventHandler(this.weAreReadyRadioButton_CheckedChanged);
            // 
            // restart
            // 
            this.restart.AutoSize = true;
            this.restart.Location = new System.Drawing.Point(12, 196);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(59, 17);
            this.restart.TabIndex = 11;
            this.restart.TabStop = true;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.CheckedChanged += new System.EventHandler(this.restartRadioButton_CheckedChanged);
            // 
            // parameterValueTextBox
            // 
            this.parameterValueTextBox.Location = new System.Drawing.Point(176, 12);
            this.parameterValueTextBox.MaxLength = 3;
            this.parameterValueTextBox.Name = "parameterValueTextBox";
            this.parameterValueTextBox.Size = new System.Drawing.Size(42, 20);
            this.parameterValueTextBox.TabIndex = 12;
            this.parameterValueTextBox.Click += new System.EventHandler(this.parameterValueTextBox_Click);
            this.parameterValueTextBox.TextChanged += new System.EventHandler(this.parameterValueTextBox_TextChanged);
            // 
            // importFood
            // 
            this.importFood.AutoSize = true;
            this.importFood.Location = new System.Drawing.Point(12, 12);
            this.importFood.Name = "importFood";
            this.importFood.Size = new System.Drawing.Size(78, 17);
            this.importFood.TabIndex = 0;
            this.importFood.TabStop = true;
            this.importFood.Text = "Import food";
            this.importFood.UseVisualStyleBackColor = true;
            this.importFood.CheckedChanged += new System.EventHandler(this.importFoodRadioButton_CheckedChanged);
            // 
            // DoSomeActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 258);
            this.Controls.Add(this.parameterValueTextBox);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.weAreReady);
            this.Controls.Add(this.setParameterTrackBar);
            this.Controls.Add(this.letsDoThisButton);
            this.Controls.Add(this.expandFoodCapacity);
            this.Controls.Add(this.buildArcology);
            this.Controls.Add(this.expandPopulationCapacity);
            this.Controls.Add(this.propaganda);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.produce);
            this.Controls.Add(this.importFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DoSomeActionForm";
            this.Text = "Do Some Action";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoSomeActionForm_FormClosed);
            this.Load += new System.EventHandler(this.DoSomeActionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.setParameterTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton produce;
        private System.Windows.Forms.RadioButton propaganda;
        private System.Windows.Forms.RadioButton clean;
        private System.Windows.Forms.RadioButton buildArcology;
        private System.Windows.Forms.RadioButton expandPopulationCapacity;
        private System.Windows.Forms.RadioButton expandFoodCapacity;
        private System.Windows.Forms.Button letsDoThisButton;
        private System.Windows.Forms.TrackBar setParameterTrackBar;
        private System.Windows.Forms.RadioButton weAreReady;
        private System.Windows.Forms.RadioButton restart;
        private System.Windows.Forms.TextBox parameterValueTextBox;
        private System.Windows.Forms.RadioButton importFood;
    }
}