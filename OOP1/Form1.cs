using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1
{
    public partial class Form1 : Form
    {
        int i = 0;    //счетчик для создания кнопок
        int sch = 0; //счетчик для кнопки со сменой цветов
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 200; //интервал таймера
            timer1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text; //изменение текста во втором текстовом поле 
        }                                  //таким образом, чтобы оно было таким же как в первом

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; //очищаем текстовые поля с помощью нажатия на кнопку
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sch++;                                              //изменение цвета кнопки
            if (sch % 4 == 0) button2.BackColor = Color.White;
            if (sch % 4 == 1) button2.BackColor = Color.Purple;
            if (sch % 4 == 2) button2.BackColor = Color.Cyan;
            if (sch % 4 == 3) button2.BackColor = Color.Yellow;
        }

        private void button6_Click(object sender, EventArgs e)
        {                  
            button6.Location = new Point(22, 455);
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {             //изменение размера формы
            if (checkedListBox1.SelectedIndex == 0)
            {
                Size = new Size(1200, 700);
            }
            if (checkedListBox1.SelectedIndex == 1)
            {
                Size = new Size(600, 400);
            }
            if (checkedListBox1.SelectedIndex == 2)
            {
                Size = new Size(885, 607);
            }
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {       //изменение цвета и положения "убегающей" кнопки
            button6.BackColor = Color.Red;
            button6.Location = new Point(button6.Location.X + 15, button6.Location.Y - 10);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {       //делаем кнопку белой, когда курсор уходит с кнопки
            button6.BackColor = Color.White;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {           //если нажимаем галочку, появляется картина
            if (checkBox1.Checked) 
                 pictureBox1.Visible= true;
                    //если убираем галочку, картина исчезает
            if (checkBox1.Checked==false)
                pictureBox1.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {           //делаем подпись видимым
            label5.Visible = true;
            if (textBox3.Text == "132")
            {       //если решено верно, выводим сообщение зеленым цветом
                label5.Text = "верно";
                label5.ForeColor = Color.Green;
            }
                
            if (textBox3.Text != "132")
            {       //если решено не верно, выводим сообщение красным цветом
                label5.ForeColor = Color.Red;
                label5.Text = "неверно";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i++; 
            Button oldbtn = (Button)sender;
            Button newbtn = new Button(); //создаем кнопку
            newbtn.Text = "Новая Кнопка";       //определяем свойства
            newbtn.Width = oldbtn.Width;
            newbtn.Height = oldbtn.Height;
            newbtn.Location = new Point(oldbtn.Location.X, oldbtn.Location.Y + i * 49);
            //newbtn.Click += new EventHandler(button3_Click);
            this.Controls.Add(newbtn); //добавляем на форму новую кнопку кнопок
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {           //когда нажимаем галочку, все три элемента окрашиваются в оранжевый
            if (checkBox2.Checked)
            {
                button5.BackColor = Color.Orange;
                label6.ForeColor = Color.Orange;
                checkBox2.ForeColor = Color.Orange;
            }
                    //когда убираем галочку, со всех трех элементов цвет убирается
            if (checkBox2.Checked == false)
            {
                button5.BackColor = Color.White;
                label6.ForeColor = Color.Black;
                checkBox2.ForeColor = Color.Black;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {           //когда нажимаем на зеленую кнопку, цвет убирается
            if (button5.BackColor == Color.Green)
            {
                button5.BackColor = Color.White;
                label6.ForeColor = Color.Black;
                checkBox2.ForeColor = Color.Black;
            }
            else    //когда нажимаем на белую кнопку, все три элемента окрашиваются в зеленый
            {
                button5.BackColor = Color.Green;
                label6.ForeColor = Color.Green;
                checkBox2.ForeColor = Color.Green;
            }
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {           //когда наводим курсор на текст, элементы окрашиваются в фиолетовый
            button5.BackColor = Color.BlueViolet;
            label6.ForeColor = Color.BlueViolet;
            checkBox2.ForeColor = Color.BlueViolet;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {           //когда убираем курсор, цвет убирается
            button5.BackColor = Color.White;
            label6.ForeColor = Color.Black;
            checkBox2.ForeColor = Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {               //увеличение прогресса каждый тик таймера
            if(timerscheck.Checked)
            {
                progressBar1.Value += 5;
            }
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {               //удаляем последний созданный объект, а именно кнопку
            if (i > 0)
            {
                this.Controls.RemoveAt(this.Controls.Count - 1);
            }
            if (i > 0) i--;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {            //если нажимаем, кнопка исчезает
            if (radioButton1.Checked)
            {
                radioButton1.Visible = false;
            }
            else
            {       
                radioButton1.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {            //если нажимаем, кнопка исчезает
            if (radioButton2.Checked)
            {
                radioButton2.Visible = false;
            }
            else
            {
                radioButton2.Visible = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {            //если нажимаем, кнопка исчезает
            if (radioButton3.Checked)
            {
                radioButton3.Visible = false;
            }
            else
            {
                radioButton3.Visible = true;
            }
        }
    }
}
