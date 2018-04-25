namespace ExcelTransform
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Transform = new System.Windows.Forms.Button();
			this.Path = new System.Windows.Forms.TextBox();
			this.ChooseFile = new System.Windows.Forms.Button();
			this.Clear = new System.Windows.Forms.Button();
			this.lblRow = new System.Windows.Forms.Label();
			this.lblCol = new System.Windows.Forms.Label();
			this.tbRow = new System.Windows.Forms.TextBox();
			this.lblSeq = new System.Windows.Forms.Label();
			this.tbSeq = new System.Windows.Forms.TextBox();
			this.tbCol = new System.Windows.Forms.TextBox();
			this.Path2 = new System.Windows.Forms.TextBox();
			this.ChooseFile2 = new System.Windows.Forms.Button();
			this.Clear2 = new System.Windows.Forms.Button();
			this.lblColumn = new System.Windows.Forms.Label();
			this.tbDataName = new System.Windows.Forms.TextBox();
			this.lblRow2 = new System.Windows.Forms.Label();
			this.tbRow2 = new System.Windows.Forms.TextBox();
			this.lblCol2 = new System.Windows.Forms.Label();
			this.tbCol2 = new System.Windows.Forms.TextBox();
			this.Transform2 = new System.Windows.Forms.Button();
			this.lblTransform2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Transform
			// 
			this.Transform.Location = new System.Drawing.Point(643, 151);
			this.Transform.Name = "Transform";
			this.Transform.Size = new System.Drawing.Size(75, 23);
			this.Transform.TabIndex = 10;
			this.Transform.Text = "轉檔";
			this.Transform.UseVisualStyleBackColor = true;
			this.Transform.Click += new System.EventHandler(this.Transform_Click);
			// 
			// Path
			// 
			this.Path.Location = new System.Drawing.Point(12, 52);
			this.Path.Name = "Path";
			this.Path.Size = new System.Drawing.Size(544, 22);
			this.Path.TabIndex = 1;
			// 
			// ChooseFile
			// 
			this.ChooseFile.Location = new System.Drawing.Point(562, 50);
			this.ChooseFile.Name = "ChooseFile";
			this.ChooseFile.Size = new System.Drawing.Size(75, 23);
			this.ChooseFile.TabIndex = 2;
			this.ChooseFile.Text = "選擇檔案";
			this.ChooseFile.UseVisualStyleBackColor = true;
			this.ChooseFile.Click += new System.EventHandler(this.SelectPath);
			// 
			// Clear
			// 
			this.Clear.Location = new System.Drawing.Point(643, 50);
			this.Clear.Name = "Clear";
			this.Clear.Size = new System.Drawing.Size(75, 23);
			this.Clear.TabIndex = 3;
			this.Clear.Text = "清除";
			this.Clear.UseVisualStyleBackColor = true;
			this.Clear.Click += new System.EventHandler(this.Clear_Click);
			// 
			// lblRow
			// 
			this.lblRow.AutoSize = true;
			this.lblRow.Location = new System.Drawing.Point(10, 122);
			this.lblRow.Name = "lblRow";
			this.lblRow.Size = new System.Drawing.Size(221, 12);
			this.lblRow.TabIndex = 6;
			this.lblRow.Text = "Row(橫向，從第幾列開始計算，預設2)：";
			// 
			// lblCol
			// 
			this.lblCol.AutoSize = true;
			this.lblCol.Location = new System.Drawing.Point(10, 156);
			this.lblCol.Name = "lblCol";
			this.lblCol.Size = new System.Drawing.Size(150, 12);
			this.lblCol.TabIndex = 8;
			this.lblCol.Text = "Col(縱向，要計算第幾行)：";
			// 
			// tbRow
			// 
			this.tbRow.Location = new System.Drawing.Point(237, 117);
			this.tbRow.Name = "tbRow";
			this.tbRow.Size = new System.Drawing.Size(152, 22);
			this.tbRow.TabIndex = 7;
			// 
			// lblSeq
			// 
			this.lblSeq.AutoSize = true;
			this.lblSeq.Location = new System.Drawing.Point(10, 92);
			this.lblSeq.Name = "lblSeq";
			this.lblSeq.Size = new System.Drawing.Size(127, 12);
			this.lblSeq.TabIndex = 4;
			this.lblSeq.Text = "排列順序(請用_隔開)：";
			// 
			// tbSeq
			// 
			this.tbSeq.Location = new System.Drawing.Point(195, 89);
			this.tbSeq.Name = "tbSeq";
			this.tbSeq.Size = new System.Drawing.Size(523, 22);
			this.tbSeq.TabIndex = 5;
			// 
			// tbCol
			// 
			this.tbCol.Location = new System.Drawing.Point(237, 151);
			this.tbCol.Name = "tbCol";
			this.tbCol.Size = new System.Drawing.Size(152, 22);
			this.tbCol.TabIndex = 9;
			// 
			// Path2
			// 
			this.Path2.Location = new System.Drawing.Point(12, 223);
			this.Path2.Name = "Path2";
			this.Path2.Size = new System.Drawing.Size(544, 22);
			this.Path2.TabIndex = 11;
			// 
			// ChooseFile2
			// 
			this.ChooseFile2.Location = new System.Drawing.Point(562, 221);
			this.ChooseFile2.Name = "ChooseFile2";
			this.ChooseFile2.Size = new System.Drawing.Size(75, 23);
			this.ChooseFile2.TabIndex = 12;
			this.ChooseFile2.Text = "選擇檔案";
			this.ChooseFile2.UseVisualStyleBackColor = true;
			this.ChooseFile2.Click += new System.EventHandler(this.SelectPath);
			// 
			// Clear2
			// 
			this.Clear2.Location = new System.Drawing.Point(643, 221);
			this.Clear2.Name = "Clear2";
			this.Clear2.Size = new System.Drawing.Size(75, 23);
			this.Clear2.TabIndex = 13;
			this.Clear2.Text = "清除";
			this.Clear2.UseVisualStyleBackColor = true;
			this.Clear2.Click += new System.EventHandler(this.Clear2_Click);
			// 
			// lblColumn
			// 
			this.lblColumn.AutoSize = true;
			this.lblColumn.Location = new System.Drawing.Point(10, 268);
			this.lblColumn.Name = "lblColumn";
			this.lblColumn.Size = new System.Drawing.Size(127, 12);
			this.lblColumn.TabIndex = 14;
			this.lblColumn.Text = "資料名稱(請用_隔開)：";
			// 
			// tbDataName
			// 
			this.tbDataName.Location = new System.Drawing.Point(195, 268);
			this.tbDataName.Name = "tbDataName";
			this.tbDataName.Size = new System.Drawing.Size(523, 22);
			this.tbDataName.TabIndex = 15;
			// 
			// lblRow2
			// 
			this.lblRow2.AutoSize = true;
			this.lblRow2.Location = new System.Drawing.Point(10, 302);
			this.lblRow2.Name = "lblRow2";
			this.lblRow2.Size = new System.Drawing.Size(221, 12);
			this.lblRow2.TabIndex = 16;
			this.lblRow2.Text = "Row(橫向，從第幾列開始計算，預設2)：";
			// 
			// tbRow2
			// 
			this.tbRow2.Location = new System.Drawing.Point(237, 299);
			this.tbRow2.Name = "tbRow2";
			this.tbRow2.Size = new System.Drawing.Size(152, 22);
			this.tbRow2.TabIndex = 17;
			// 
			// lblCol2
			// 
			this.lblCol2.AutoSize = true;
			this.lblCol2.Location = new System.Drawing.Point(10, 337);
			this.lblCol2.Name = "lblCol2";
			this.lblCol2.Size = new System.Drawing.Size(150, 12);
			this.lblCol2.TabIndex = 18;
			this.lblCol2.Text = "Col(縱向，要計算第幾行)：";
			// 
			// tbCol2
			// 
			this.tbCol2.Location = new System.Drawing.Point(237, 334);
			this.tbCol2.Name = "tbCol2";
			this.tbCol2.Size = new System.Drawing.Size(152, 22);
			this.tbCol2.TabIndex = 19;
			// 
			// Transform2
			// 
			this.Transform2.Location = new System.Drawing.Point(643, 332);
			this.Transform2.Name = "Transform2";
			this.Transform2.Size = new System.Drawing.Size(75, 23);
			this.Transform2.TabIndex = 22;
			this.Transform2.Text = "轉檔";
			this.Transform2.UseVisualStyleBackColor = true;
			this.Transform2.Click += new System.EventHandler(this.Transform2_Click);
			// 
			// lblTransform2
			// 
			this.lblTransform2.AutoSize = true;
			this.lblTransform2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblTransform2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lblTransform2.Location = new System.Drawing.Point(12, 189);
			this.lblTransform2.Name = "lblTransform2";
			this.lblTransform2.Size = new System.Drawing.Size(189, 19);
			this.lblTransform2.TabIndex = 23;
			this.lblTransform2.Text = "將資料轉成個別欄位";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 19);
			this.label1.TabIndex = 24;
			this.label1.Text = "將資料轉成陣列";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(730, 406);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTransform2);
			this.Controls.Add(this.Transform2);
			this.Controls.Add(this.tbCol2);
			this.Controls.Add(this.lblCol2);
			this.Controls.Add(this.tbRow2);
			this.Controls.Add(this.lblRow2);
			this.Controls.Add(this.tbDataName);
			this.Controls.Add(this.lblColumn);
			this.Controls.Add(this.Clear2);
			this.Controls.Add(this.ChooseFile2);
			this.Controls.Add(this.Path2);
			this.Controls.Add(this.tbSeq);
			this.Controls.Add(this.lblSeq);
			this.Controls.Add(this.tbRow);
			this.Controls.Add(this.tbCol);
			this.Controls.Add(this.lblCol);
			this.Controls.Add(this.lblRow);
			this.Controls.Add(this.Clear);
			this.Controls.Add(this.ChooseFile);
			this.Controls.Add(this.Path);
			this.Controls.Add(this.Transform);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "報表轉檔程式";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Transform;
		private System.Windows.Forms.TextBox Path;
		private System.Windows.Forms.Button ChooseFile;
		private System.Windows.Forms.Button Clear;
		private System.Windows.Forms.Label lblRow;
		private System.Windows.Forms.Label lblCol;
		private System.Windows.Forms.TextBox tbRow;
		private System.Windows.Forms.Label lblSeq;
		private System.Windows.Forms.TextBox tbSeq;
		private System.Windows.Forms.TextBox tbCol;
		private System.Windows.Forms.TextBox Path2;
		private System.Windows.Forms.Button ChooseFile2;
		private System.Windows.Forms.Button Clear2;
		private System.Windows.Forms.Label lblColumn;
		private System.Windows.Forms.TextBox tbDataName;
		private System.Windows.Forms.Label lblRow2;
		private System.Windows.Forms.TextBox tbRow2;
		private System.Windows.Forms.Label lblCol2;
		private System.Windows.Forms.TextBox tbCol2;
		private System.Windows.Forms.Button Transform2;
		private System.Windows.Forms.Label lblTransform2;
		private System.Windows.Forms.Label label1;
	}
}

