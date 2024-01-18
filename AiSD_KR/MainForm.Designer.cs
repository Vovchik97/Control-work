namespace AiSD_KR
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Arrays = new System.Windows.Forms.TableLayoutPanel();
            this.label_OriginArray = new System.Windows.Forms.Label();
            this.label_SortArray = new System.Windows.Forms.Label();
            this.list_Origin_Array = new System.Windows.Forms.ListView();
            this.column_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Element = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_Sort_Array = new System.Windows.Forms.ListView();
            this.column_Sort_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columm_Sort_Element = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel_InputOutput = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Output = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Time = new System.Windows.Forms.TextBox();
            this.textBox_Comparisons = new System.Windows.Forms.TextBox();
            this.textBox_Swaps = new System.Windows.Forms.TextBox();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_Equals = new System.Windows.Forms.Label();
            this.label_Swaps = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Input = new System.Windows.Forms.TableLayoutPanel();
            this.label_N = new System.Windows.Forms.Label();
            this.label_A = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_buttons = new System.Windows.Forms.TableLayoutPanel();
            this.button_Sort = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Name = new System.Windows.Forms.TableLayoutPanel();
            this.label_Name = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.tableLayoutPanel_Arrays.SuspendLayout();
            this.tableLayoutPanel_InputOutput.SuspendLayout();
            this.tableLayoutPanel_Output.SuspendLayout();
            this.tableLayoutPanel_Input.SuspendLayout();
            this.tableLayoutPanel_buttons.SuspendLayout();
            this.tableLayoutPanel_Name.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 2;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.19328F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.80672F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_Arrays, 1, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_InputOutput, 0, 0);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 54);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 1;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(952, 606);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // tableLayoutPanel_Arrays
            // 
            this.tableLayoutPanel_Arrays.ColumnCount = 2;
            this.tableLayoutPanel_Arrays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Arrays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Arrays.Controls.Add(this.label_OriginArray, 0, 0);
            this.tableLayoutPanel_Arrays.Controls.Add(this.label_SortArray, 1, 0);
            this.tableLayoutPanel_Arrays.Controls.Add(this.list_Origin_Array, 0, 1);
            this.tableLayoutPanel_Arrays.Controls.Add(this.list_Sort_Array, 1, 1);
            this.tableLayoutPanel_Arrays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Arrays.Location = new System.Drawing.Point(319, 3);
            this.tableLayoutPanel_Arrays.Name = "tableLayoutPanel_Arrays";
            this.tableLayoutPanel_Arrays.RowCount = 2;
            this.tableLayoutPanel_Arrays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel_Arrays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel_Arrays.Size = new System.Drawing.Size(630, 600);
            this.tableLayoutPanel_Arrays.TabIndex = 0;
            // 
            // label_OriginArray
            // 
            this.label_OriginArray.AutoSize = true;
            this.label_OriginArray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_OriginArray.Location = new System.Drawing.Point(3, 0);
            this.label_OriginArray.Name = "label_OriginArray";
            this.label_OriginArray.Size = new System.Drawing.Size(309, 72);
            this.label_OriginArray.TabIndex = 0;
            this.label_OriginArray.Text = "Исходный массив";
            this.label_OriginArray.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_SortArray
            // 
            this.label_SortArray.AutoSize = true;
            this.label_SortArray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_SortArray.Location = new System.Drawing.Point(318, 0);
            this.label_SortArray.Name = "label_SortArray";
            this.label_SortArray.Size = new System.Drawing.Size(309, 72);
            this.label_SortArray.TabIndex = 1;
            this.label_SortArray.Text = "Отсортированный массив";
            this.label_SortArray.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_Origin_Array
            // 
            this.list_Origin_Array.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.list_Origin_Array.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Id,
            this.column_Element});
            this.list_Origin_Array.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_Origin_Array.GridLines = true;
            this.list_Origin_Array.HideSelection = false;
            this.list_Origin_Array.Location = new System.Drawing.Point(3, 75);
            this.list_Origin_Array.Name = "list_Origin_Array";
            this.list_Origin_Array.Size = new System.Drawing.Size(309, 522);
            this.list_Origin_Array.TabIndex = 2;
            this.list_Origin_Array.UseCompatibleStateImageBehavior = false;
            this.list_Origin_Array.View = System.Windows.Forms.View.Details;
            // 
            // column_Id
            // 
            this.column_Id.Text = "Номер";
            this.column_Id.Width = 100;
            // 
            // column_Element
            // 
            this.column_Element.Text = "Элемент";
            this.column_Element.Width = 100;
            // 
            // list_Sort_Array
            // 
            this.list_Sort_Array.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Sort_Id,
            this.columm_Sort_Element});
            this.list_Sort_Array.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_Sort_Array.GridLines = true;
            this.list_Sort_Array.HideSelection = false;
            this.list_Sort_Array.Location = new System.Drawing.Point(318, 75);
            this.list_Sort_Array.Name = "list_Sort_Array";
            this.list_Sort_Array.Size = new System.Drawing.Size(309, 522);
            this.list_Sort_Array.TabIndex = 3;
            this.list_Sort_Array.UseCompatibleStateImageBehavior = false;
            this.list_Sort_Array.View = System.Windows.Forms.View.Details;
            // 
            // column_Sort_Id
            // 
            this.column_Sort_Id.Text = "Номер";
            this.column_Sort_Id.Width = 100;
            // 
            // columm_Sort_Element
            // 
            this.columm_Sort_Element.Text = "Элемент";
            this.columm_Sort_Element.Width = 100;
            // 
            // tableLayoutPanel_InputOutput
            // 
            this.tableLayoutPanel_InputOutput.ColumnCount = 1;
            this.tableLayoutPanel_InputOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_InputOutput.Controls.Add(this.tableLayoutPanel_Output, 0, 1);
            this.tableLayoutPanel_InputOutput.Controls.Add(this.tableLayoutPanel_Input, 0, 0);
            this.tableLayoutPanel_InputOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_InputOutput.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_InputOutput.Name = "tableLayoutPanel_InputOutput";
            this.tableLayoutPanel_InputOutput.RowCount = 2;
            this.tableLayoutPanel_InputOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_InputOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_InputOutput.Size = new System.Drawing.Size(310, 600);
            this.tableLayoutPanel_InputOutput.TabIndex = 5;
            // 
            // tableLayoutPanel_Output
            // 
            this.tableLayoutPanel_Output.ColumnCount = 2;
            this.tableLayoutPanel_Output.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.72131F));
            this.tableLayoutPanel_Output.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.27869F));
            this.tableLayoutPanel_Output.Controls.Add(this.textBox_Time, 1, 0);
            this.tableLayoutPanel_Output.Controls.Add(this.textBox_Comparisons, 1, 1);
            this.tableLayoutPanel_Output.Controls.Add(this.textBox_Swaps, 1, 2);
            this.tableLayoutPanel_Output.Controls.Add(this.label_Time, 0, 0);
            this.tableLayoutPanel_Output.Controls.Add(this.label_Equals, 0, 1);
            this.tableLayoutPanel_Output.Controls.Add(this.label_Swaps, 0, 2);
            this.tableLayoutPanel_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Output.Location = new System.Drawing.Point(3, 303);
            this.tableLayoutPanel_Output.Name = "tableLayoutPanel_Output";
            this.tableLayoutPanel_Output.RowCount = 3;
            this.tableLayoutPanel_Output.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Output.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Output.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Output.Size = new System.Drawing.Size(304, 294);
            this.tableLayoutPanel_Output.TabIndex = 3;
            // 
            // textBox_Time
            // 
            this.textBox_Time.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Time.Enabled = false;
            this.textBox_Time.Location = new System.Drawing.Point(114, 37);
            this.textBox_Time.Name = "textBox_Time";
            this.textBox_Time.ReadOnly = true;
            this.textBox_Time.Size = new System.Drawing.Size(100, 22);
            this.textBox_Time.TabIndex = 0;
            // 
            // textBox_Comparisons
            // 
            this.textBox_Comparisons.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Comparisons.Enabled = false;
            this.textBox_Comparisons.Location = new System.Drawing.Point(114, 134);
            this.textBox_Comparisons.Name = "textBox_Comparisons";
            this.textBox_Comparisons.ReadOnly = true;
            this.textBox_Comparisons.Size = new System.Drawing.Size(100, 22);
            this.textBox_Comparisons.TabIndex = 1;
            // 
            // textBox_Swaps
            // 
            this.textBox_Swaps.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Swaps.Enabled = false;
            this.textBox_Swaps.Location = new System.Drawing.Point(114, 233);
            this.textBox_Swaps.Name = "textBox_Swaps";
            this.textBox_Swaps.ReadOnly = true;
            this.textBox_Swaps.Size = new System.Drawing.Size(100, 22);
            this.textBox_Swaps.TabIndex = 2;
            // 
            // label_Time
            // 
            this.label_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(3, 40);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(105, 16);
            this.label_Time.TabIndex = 3;
            this.label_Time.Text = "Время";
            this.label_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Equals
            // 
            this.label_Equals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Equals.AutoSize = true;
            this.label_Equals.Location = new System.Drawing.Point(3, 137);
            this.label_Equals.Name = "label_Equals";
            this.label_Equals.Size = new System.Drawing.Size(105, 16);
            this.label_Equals.TabIndex = 4;
            this.label_Equals.Text = "Сравнения";
            this.label_Equals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Swaps
            // 
            this.label_Swaps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Swaps.AutoSize = true;
            this.label_Swaps.Location = new System.Drawing.Point(3, 236);
            this.label_Swaps.Name = "label_Swaps";
            this.label_Swaps.Size = new System.Drawing.Size(105, 16);
            this.label_Swaps.TabIndex = 5;
            this.label_Swaps.Text = "Перестановок";
            this.label_Swaps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_Input
            // 
            this.tableLayoutPanel_Input.ColumnCount = 2;
            this.tableLayoutPanel_Input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel_Input.Controls.Add(this.label_N, 0, 0);
            this.tableLayoutPanel_Input.Controls.Add(this.label_A, 0, 1);
            this.tableLayoutPanel_Input.Controls.Add(this.label_B, 0, 2);
            this.tableLayoutPanel_Input.Controls.Add(this.textBox_N, 1, 0);
            this.tableLayoutPanel_Input.Controls.Add(this.textBox_A, 1, 1);
            this.tableLayoutPanel_Input.Controls.Add(this.textBox_B, 1, 2);
            this.tableLayoutPanel_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Input.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_Input.Name = "tableLayoutPanel_Input";
            this.tableLayoutPanel_Input.RowCount = 3;
            this.tableLayoutPanel_Input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Input.Size = new System.Drawing.Size(304, 294);
            this.tableLayoutPanel_Input.TabIndex = 4;
            // 
            // label_N
            // 
            this.label_N.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_N.AutoSize = true;
            this.label_N.Location = new System.Drawing.Point(3, 40);
            this.label_N.Name = "label_N";
            this.label_N.Size = new System.Drawing.Size(54, 16);
            this.label_N.TabIndex = 0;
            this.label_N.Text = "N";
            this.label_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_A
            // 
            this.label_A.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_A.AutoSize = true;
            this.label_A.Location = new System.Drawing.Point(3, 137);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(54, 16);
            this.label_A.TabIndex = 1;
            this.label_A.Text = "A";
            this.label_A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_B
            // 
            this.label_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(3, 236);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(54, 16);
            this.label_B.TabIndex = 2;
            this.label_B.Text = "B";
            this.label_B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_N
            // 
            this.textBox_N.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_N.Location = new System.Drawing.Point(63, 37);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(100, 22);
            this.textBox_N.TabIndex = 3;
            this.textBox_N.TextChanged += new System.EventHandler(this.textBox_N_TextChanged);
            // 
            // textBox_A
            // 
            this.textBox_A.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_A.Location = new System.Drawing.Point(63, 134);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(100, 22);
            this.textBox_A.TabIndex = 4;
            this.textBox_A.TextChanged += new System.EventHandler(this.textBox_A_TextChanged);
            // 
            // textBox_B
            // 
            this.textBox_B.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_B.Location = new System.Drawing.Point(63, 233);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(100, 22);
            this.textBox_B.TabIndex = 5;
            this.textBox_B.TextChanged += new System.EventHandler(this.textBox_B_TextChanged);
            // 
            // tableLayoutPanel_buttons
            // 
            this.tableLayoutPanel_buttons.ColumnCount = 3;
            this.tableLayoutPanel_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel_buttons.Controls.Add(this.button_Sort, 0, 0);
            this.tableLayoutPanel_buttons.Controls.Add(this.button_Clear, 1, 0);
            this.tableLayoutPanel_buttons.Controls.Add(this.buttonCalc, 2, 0);
            this.tableLayoutPanel_buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel_buttons.Location = new System.Drawing.Point(0, 660);
            this.tableLayoutPanel_buttons.Name = "tableLayoutPanel_buttons";
            this.tableLayoutPanel_buttons.RowCount = 1;
            this.tableLayoutPanel_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_buttons.Size = new System.Drawing.Size(952, 59);
            this.tableLayoutPanel_buttons.TabIndex = 5;
            // 
            // button_Sort
            // 
            this.button_Sort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Sort.Enabled = false;
            this.button_Sort.Location = new System.Drawing.Point(3, 3);
            this.button_Sort.Name = "button_Sort";
            this.button_Sort.Size = new System.Drawing.Size(311, 53);
            this.button_Sort.TabIndex = 0;
            this.button_Sort.Text = "Сортировка";
            this.button_Sort.UseVisualStyleBackColor = true;
            this.button_Sort.Click += new System.EventHandler(this.button_Sort_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Clear.Enabled = false;
            this.button_Clear.Location = new System.Drawing.Point(320, 3);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(311, 53);
            this.button_Clear.TabIndex = 1;
            this.button_Clear.Text = "Очистка";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCalc.Location = new System.Drawing.Point(637, 3);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(312, 53);
            this.buttonCalc.TabIndex = 2;
            this.buttonCalc.Text = "Расчёты";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // tableLayoutPanel_Name
            // 
            this.tableLayoutPanel_Name.ColumnCount = 1;
            this.tableLayoutPanel_Name.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Name.Controls.Add(this.label_Name, 0, 0);
            this.tableLayoutPanel_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_Name.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Name.Name = "tableLayoutPanel_Name";
            this.tableLayoutPanel_Name.RowCount = 1;
            this.tableLayoutPanel_Name.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Name.Size = new System.Drawing.Size(952, 54);
            this.tableLayoutPanel_Name.TabIndex = 6;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(3, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(946, 54);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Сортировка данных";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 719);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Controls.Add(this.tableLayoutPanel_buttons);
            this.Controls.Add(this.tableLayoutPanel_Name);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсовая работа";
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.tableLayoutPanel_Arrays.ResumeLayout(false);
            this.tableLayoutPanel_Arrays.PerformLayout();
            this.tableLayoutPanel_InputOutput.ResumeLayout(false);
            this.tableLayoutPanel_Output.ResumeLayout(false);
            this.tableLayoutPanel_Output.PerformLayout();
            this.tableLayoutPanel_Input.ResumeLayout(false);
            this.tableLayoutPanel_Input.PerformLayout();
            this.tableLayoutPanel_buttons.ResumeLayout(false);
            this.tableLayoutPanel_Name.ResumeLayout(false);
            this.tableLayoutPanel_Name.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Arrays;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Output;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Input;
        private System.Windows.Forms.Label label_N;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.TextBox textBox_Time;
        private System.Windows.Forms.TextBox textBox_Comparisons;
        private System.Windows.Forms.TextBox textBox_Swaps;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_Equals;
        private System.Windows.Forms.Label label_Swaps;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_buttons;
        private System.Windows.Forms.Button button_Sort;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label label_OriginArray;
        private System.Windows.Forms.Label label_SortArray;
        private System.Windows.Forms.ListView list_Origin_Array;
        private System.Windows.Forms.ColumnHeader column_Id;
        private System.Windows.Forms.ColumnHeader column_Element;
        private System.Windows.Forms.ListView list_Sort_Array;
        private System.Windows.Forms.ColumnHeader column_Sort_Id;
        private System.Windows.Forms.ColumnHeader columm_Sort_Element;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_InputOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Name;
        private System.Windows.Forms.Label label_Name;
    }
}

