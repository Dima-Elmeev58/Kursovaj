using System.Windows.Forms;

namespace Приложение_курсового
{
    partial class Form1
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
            SortButton1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox3 = new TextBox();
            SortTextBox1 = new TextBox();
            textBoxInput = new TextBox();
            SuspendLayout();
            // 
            // SortButton1
            // 
            SortButton1.Location = new Point(31, 133);
            SortButton1.Name = "SortButton1";
            SortButton1.Size = new Size(258, 29);
            SortButton1.TabIndex = 0;
            SortButton1.Text = "Отсортировать";
            SortButton1.UseVisualStyleBackColor = true;
            SortButton1.Click += SortButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(503, 133);
            button2.Name = "button2";
            button2.Size = new Size(258, 29);
            button2.TabIndex = 1;
            button2.Text = "Отсортировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonSort_Click;
            // 
            // button3
            // 
            button3.Location = new Point(266, 301);
            button3.Name = "button3";
            button3.Size = new Size(278, 29);
            button3.TabIndex = 5;
            button3.Text = "Слиять массивы";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonMerge_Click;            // 
            // textBox3
            // 
            textBox3.Location = new Point(266, 258);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 27);
            textBox3.TabIndex = 6;
            // 
            // SortTextBox1
            // 
            SortTextBox1.Location = new Point(31, 76);
            SortTextBox1.Name = "SortTextBox1";
            SortTextBox1.Size = new Size(258, 27);
            SortTextBox1.TabIndex = 7;
            SortTextBox1.TextChanged += SortTextBox1_TextChanged;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(503, 76);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(258, 27);
            textBoxInput.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources.фон_приложения1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxInput);
            Controls.Add(SortTextBox1);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(SortButton1);
            Name = "Form1";
            Text = "Сортировка массивов";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            try
            {

                string input = SortTextBox1.Text;
                int[] MyArray = Array.ConvertAll(input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
                InsertionSort(MyArray);
                SortTextBox1.Text = string.Join(" ", MyArray);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите дополнительные числа разделенные пробелами. Ошибка ввода");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка:" + ex.Message);
            }


        }
        private void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            // Получаем входные данные из текстового поля
            string input = textBoxInput.Text;
            int[] array;

            try
            {
                // Преобразуем строку в массив чисел
                array = input.Split(' ')
                             .Select(int.Parse)
                             .ToArray();

                // Сортировка массива простыми вставками
                InsertionSort(array);

                // Отображаем отсортированный массив
                textBoxInput.Text = string.Join(" ", array);
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите числа, разделенные пробелами.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void InsertionSort1(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                // Перемещаем элементы массива, которые больше ключа
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }
        private void buttonMerge_Click(object sender, EventArgs e)
        {
            // Получаем входные данные из текстовых полей
            string input1 = SortTextBox1.Text;
            string input2 = textBoxInput.Text;

            try
            {
                // Преобразуем строки в массивы чисел
                int[] array1 = input1.Split(' ')
                                      .Select(int.Parse)
                                      .ToArray();
                int[] array2 = input2.Split(' ')
                                      .Select(int.Parse)
                                      .ToArray();

                // Слияние двух отсортированных массивов
                int[] mergedArray = MergeSortedArrays(array1, array2);

                // Отображаем результат
                textBox3.Text = string.Join(" ", mergedArray);
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите числа, разделенные запятыми.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private int[] MergeSortedArrays(int[] array1, int[] array2)
        {
            int[] merged = new int[array1.Length + array2.Length];
            int i = 0, j = 0, k = 0;

            // Слияние массивов
            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] <= array2[j])
                {
                    merged[k++] = array1[i++];
                }
                else
                {
                    merged[k++] = array2[j++];
                }
            }

            // Копируем оставшиеся элементы из первого массива
            while (i < array1.Length)
            {
                merged[k++] = array1[i++];
            }

            // Копируем оставшиеся элементы из второго массива
            while (j < array2.Length)
            {
                merged[k++] = array2[j++];
            }

            return merged;
        }


        #endregion

        private Button SortButton1;
        private Button button2;
        private Button button3;
        private TextBox textBox3;
        private TextBox SortTextBox1;
        private TextBox textBoxInput;
    }
}
