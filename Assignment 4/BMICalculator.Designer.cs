namespace Assignment_4
{
    partial class BMICalculator
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
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialRadio = new System.Windows.Forms.RadioButton();
            this.MetricRadio = new System.Windows.Forms.RadioButton();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.MyHeightTextBox = new System.Windows.Forms.TextBox();
            this.MyWeightTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ErrorLabelA = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Controls.Add(this.ResetButton, 1, 3);
            this.TableLayoutPanel.Controls.Add(this.MyWeightTextBox, 1, 2);
            this.TableLayoutPanel.Controls.Add(this.MetricRadio, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.ImperialRadio, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.MyHeightLabel, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.MyWeightLabel, 0, 2);
            this.TableLayoutPanel.Controls.Add(this.MyHeightTextBox, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.SubmitButton, 0, 3);
            this.TableLayoutPanel.Controls.Add(this.ErrorLabel, 0, 4);
            this.TableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 5;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(274, 219);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // ImperialRadio
            // 
            this.ImperialRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialRadio.AutoSize = true;
            this.ImperialRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.ImperialRadio.Location = new System.Drawing.Point(3, 3);
            this.ImperialRadio.Name = "ImperialRadio";
            this.ImperialRadio.Size = new System.Drawing.Size(131, 30);
            this.ImperialRadio.TabIndex = 0;
            this.ImperialRadio.TabStop = true;
            this.ImperialRadio.Text = "Imperial";
            this.ImperialRadio.UseVisualStyleBackColor = true;
            // 
            // MetricRadio
            // 
            this.MetricRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricRadio.AutoSize = true;
            this.MetricRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.MetricRadio.Location = new System.Drawing.Point(140, 3);
            this.MetricRadio.Name = "MetricRadio";
            this.MetricRadio.Size = new System.Drawing.Size(131, 30);
            this.MetricRadio.TabIndex = 1;
            this.MetricRadio.TabStop = true;
            this.MetricRadio.Text = "Metric";
            this.MetricRadio.UseVisualStyleBackColor = true;
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MyHeightLabel.Location = new System.Drawing.Point(3, 36);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(131, 45);
            this.MyHeightLabel.TabIndex = 2;
            this.MyHeightLabel.Text = "My Height: ";
            this.MyHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MyWeightLabel.Location = new System.Drawing.Point(3, 81);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(131, 45);
            this.MyWeightLabel.TabIndex = 3;
            this.MyWeightLabel.Text = "My Weight: ";
            this.MyWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyHeightTextBox
            // 
            this.MyHeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyHeightTextBox.Location = new System.Drawing.Point(140, 39);
            this.MyHeightTextBox.Name = "MyHeightTextBox";
            this.MyHeightTextBox.Size = new System.Drawing.Size(131, 39);
            this.MyHeightTextBox.TabIndex = 4;
            this.MyHeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MyWeightTextBox
            // 
            this.MyWeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyWeightTextBox.Location = new System.Drawing.Point(140, 84);
            this.MyWeightTextBox.Name = "MyWeightTextBox";
            this.MyWeightTextBox.Size = new System.Drawing.Size(131, 39);
            this.MyWeightTextBox.TabIndex = 5;
            this.MyWeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.SubmitButton.Location = new System.Drawing.Point(3, 129);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(131, 89);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Calculate BMI";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ResetButton.Location = new System.Drawing.Point(140, 129);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(131, 89);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset Input";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ErrorLabel.Location = new System.Drawing.Point(3, 221);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(131, 20);
            this.ErrorLabel.TabIndex = 8;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ErrorLabelA
            // 
            this.ErrorLabelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ErrorLabelA.Location = new System.Drawing.Point(14, 227);
            this.ErrorLabelA.Name = "ErrorLabelA";
            this.ErrorLabelA.Size = new System.Drawing.Size(269, 35);
            this.ErrorLabelA.TabIndex = 1;
            this.ErrorLabelA.Text = "Error Label";
            this.ErrorLabelA.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(12, 301);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 111);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Underweight\r\nNormal\r\nOverweight\r\nObese";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BMITextBox
            // 
            this.BMITextBox.Enabled = false;
            this.BMITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BMITextBox.Location = new System.Drawing.Point(12, 256);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(271, 35);
            this.BMITextBox.TabIndex = 3;
            this.BMITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 424);
            this.Controls.Add(this.BMITextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ErrorLabelA);
            this.Controls.Add(this.TableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.RadioButton MetricRadio;
        private System.Windows.Forms.RadioButton ImperialRadio;
        private System.Windows.Forms.TextBox MyWeightTextBox;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.TextBox MyHeightTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label ErrorLabelA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox BMITextBox;
    }
}

