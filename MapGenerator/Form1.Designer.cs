namespace MapGenerator
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Back = new System.Windows.Forms.Label();
            this.Point1 = new System.Windows.Forms.Label();
            this.Point2 = new System.Windows.Forms.Label();
            this.Text_ = new System.Windows.Forms.Label();
            this.Lat = new System.Windows.Forms.NumericUpDown();
            this.Long = new System.Windows.Forms.NumericUpDown();
            this.Zoom = new System.Windows.Forms.NumericUpDown();
            this.Img = new System.Windows.Forms.PictureBox();
            this.Gen = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MapData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Lat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Long)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.Back.Location = new System.Drawing.Point(0, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(500, 100);
            this.Back.TabIndex = 0;
            // 
            // Point1
            // 
            this.Point1.BackColor = System.Drawing.Color.Red;
            this.Point1.Location = new System.Drawing.Point(241, 349);
            this.Point1.Name = "Point1";
            this.Point1.Size = new System.Drawing.Size(20, 4);
            this.Point1.TabIndex = 1;
            // 
            // Point2
            // 
            this.Point2.BackColor = System.Drawing.Color.Red;
            this.Point2.Location = new System.Drawing.Point(249, 341);
            this.Point2.Name = "Point2";
            this.Point2.Size = new System.Drawing.Size(4, 20);
            this.Point2.TabIndex = 2;
            // 
            // Text_
            // 
            this.Text_.AutoSize = true;
            this.Text_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.Text_.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Text_.Location = new System.Drawing.Point(12, 20);
            this.Text_.Name = "Text_";
            this.Text_.Size = new System.Drawing.Size(320, 60);
            this.Text_.TabIndex = 3;
            this.Text_.Text = "中心緯度:　　　　　　　　拡大倍率:　　　\r\n\r\n中心経度:　　　　　　　　地図:";
            // 
            // Lat
            // 
            this.Lat.DecimalPlaces = 3;
            this.Lat.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Lat.Location = new System.Drawing.Point(84, 18);
            this.Lat.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.Lat.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.Lat.Name = "Lat";
            this.Lat.Size = new System.Drawing.Size(80, 24);
            this.Lat.TabIndex = 4;
            this.Lat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Lat.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // Long
            // 
            this.Long.DecimalPlaces = 3;
            this.Long.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Long.Location = new System.Drawing.Point(84, 52);
            this.Long.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.Long.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.Long.Name = "Long";
            this.Long.Size = new System.Drawing.Size(80, 24);
            this.Long.TabIndex = 5;
            this.Long.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Long.Value = new decimal(new int[] {
            135,
            0,
            0,
            0});
            // 
            // Zoom
            // 
            this.Zoom.DecimalPlaces = 4;
            this.Zoom.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Zoom.Location = new System.Drawing.Point(257, 18);
            this.Zoom.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.Zoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(70, 24);
            this.Zoom.TabIndex = 6;
            this.Zoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Zoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Img
            // 
            this.Img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Img.Location = new System.Drawing.Point(0, 0);
            this.Img.Name = "Img";
            this.Img.Size = new System.Drawing.Size(0, 0);
            this.Img.TabIndex = 7;
            this.Img.TabStop = false;
            // 
            // Gen
            // 
            this.Gen.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Gen.ForeColor = System.Drawing.Color.Black;
            this.Gen.Location = new System.Drawing.Point(356, 16);
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(132, 70);
            this.Gen.TabIndex = 8;
            this.Gen.Text = "生成";
            this.Gen.UseVisualStyleBackColor = true;
            this.Gen.Click += new System.EventHandler(this.Gen_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Items.AddRange(new object[] {
            "日本(地域)"});
            this.listBox1.Location = new System.Drawing.Point(215, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(112, 21);
            this.listBox1.TabIndex = 9;
            // 
            // MapData
            // 
            this.MapData.AutoSize = true;
            this.MapData.Location = new System.Drawing.Point(-1, 582);
            this.MapData.Name = "MapData";
            this.MapData.Size = new System.Drawing.Size(136, 17);
            this.MapData.TabIndex = 10;
            this.MapData.Text = "地図データ:気象庁";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.MapData);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Gen);
            this.Controls.Add(this.Zoom);
            this.Controls.Add(this.Long);
            this.Controls.Add(this.Lat);
            this.Controls.Add(this.Text_);
            this.Controls.Add(this.Point2);
            this.Controls.Add(this.Point1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Img);
            this.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "MapGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.Lat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Long)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.Label Point1;
        private System.Windows.Forms.Label Point2;
        private System.Windows.Forms.Label Text_;
        private System.Windows.Forms.NumericUpDown Lat;
        private System.Windows.Forms.NumericUpDown Long;
        private System.Windows.Forms.NumericUpDown Zoom;
        private System.Windows.Forms.PictureBox Img;
        private System.Windows.Forms.Button Gen;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label MapData;
    }
}

