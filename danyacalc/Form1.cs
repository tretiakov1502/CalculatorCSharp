using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace danyacalc
{
    public partial class Form1 : Form
    {
        enum Operation
        {
            Add, // сложение
            Subtract, // вычитание
            Multiply, // умножение
            Divide, // деление
            Power, // возведение в степень
            Precent, // процент
            Abs, // модуль
            Radical, //корень
            Ln, //логарифм
        }

        private bool checkop = false, checkend = false, checktext = false; // переменные для условий
        private string numbera, numberb; // переменные для конвертизации
        private double a, b, result; // переменные для вычислений
        private int j; // счечик символов
        Operation operation; // переменная типа перечисления
        public Form1()
        {
            InitializeComponent();
        }

        private void number1_Click(object sender, EventArgs e)
        {
            if (!checkend)
            {
                textBox1.Text += 1;// печатает цифру
                checktext = true; // есть текст
            }
        }

        private void number2_Click(object sender, EventArgs e)
        {
            if (!checkend) // проверкая об окончании вычислений чтобы после = не печатались цифры
            {
                textBox1.Text += 2;// печатает цифру
                checktext = true; // есть текст
            }
        }

        private void number3_Click(object sender, EventArgs e)
        {
            if (!checkend) // проверкая об окончании вычислений чтобы после = не печатались цифры
            {
                textBox1.Text += 3;// печатает цифру
                checktext = true; // есть текст
            }
        }

        private void number4_Click(object sender, EventArgs e)
        {
            if (!checkend) // проверкая об окончании вычислений чтобы после = не печатались цифры
            {
                textBox1.Text += 4;// печатает цифру
                checktext = true; // есть текст
            }
        }

        private void number5_Click(object sender, EventArgs e)
        {
            if (!checkend) // проверкая об окончании вычислений чтобы после = не печатались цифры
            {
                textBox1.Text += 5;// печатает цифру
                checktext = true; // есть текст
            }
        }

        private void number6_Click(object sender, EventArgs e)
        {
            if (!checkend) // проверкая об окончании вычислений чтобы после = не печатались цифры
            {
                textBox1.Text += 6;// печатает цифру
                checktext = true; // есть текст
            }
        }

        private void number7_Click(object sender, EventArgs e)
        {
            if (!checkend) // проверкая об окончании вычислений чтобы после = не печатались цифры
            {
                textBox1.Text += 7;// печатает цифру
                checktext = true; // есть текст
            }
        }

        private void number8_Click(object sender, EventArgs e)
        {
            if (!checkend) // проверкая об окончании вычислений чтобы после = не печатались цифры
            {
                textBox1.Text += 8;// печатает цифру
                checktext = true; // есть текст
            }
        }


        private void number9_Click(object sender, EventArgs e)
        {
            if (!checkend) // проверкая об окончании вычислений чтобы после = не печатались цифры
            {
                textBox1.Text += 9;// печатает цифру
                checktext = true; // есть текст
            }
        }


        private void number0_Click(object sender, EventArgs e)
        {
            if (!checkend) // проверкая об окончании вычислений чтобы после = не печатались цифры
            {
                textBox1.Text += 0; // печатает цифру
                checktext = true; // есть текст
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void buttonequally_Click(object sender, EventArgs e)
        {
            if (checkop) // проверка, была ли операция
            {
                if (j != 0) // счетчик j = 0 когда переменная b не требуется
                {
                    for (int i = 0; i < j - 1; i++) // цикл заполнение для переменной a
                    {
                        numbera += textBox1.Text[i];
                    }
                    for (int i = j; i < textBox1.TextLength; i++) // цикл заполнение для переменной b
                    {
                        numberb += textBox1.Text[i];
                    }
                    b = Convert.ToDouble(numberb); // конвертация string в double
                    numberb = ""; // обнуление переменной
                }
                else
                {
                    j = textBox1.TextLength; // присваиваем значение j, для нахождение переменной a, в случае, когда переменная b не используется
                    for (int i = 0; i < j; i++)
                    {
                        numbera += textBox1.Text[i];
                    }
                }
                a = Convert.ToDouble(numbera); // конвертация string в double
                numbera = ""; // обнуление переменной
                textBox1.Text += "="; // печатает символ
                switch (operation)
                {
                    case Operation.Add: // сложение
                        result = a + b;
                        break;
                    case Operation.Subtract: // вычитание
                        result = a - b;
                        break;
                    case Operation.Multiply: // умножение
                        result = a * b;
                        break;
                    case Operation.Divide:// деление
                        result = a / b;
                        break;
                    case Operation.Power:// возведение в степень
                        result = System.Math.Pow(a, b);
                        break;
                    case Operation.Abs://модуль
                        result = System.Math.Abs(a);
                        break;
                    case Operation.Radical://корень
                        result = System.Math.Sqrt(a);
                        break;
                    case Operation.Ln://натуральный логарифм
                        result = System.Math.Log(a);
                        break;
                    case Operation.Precent://процент от числа
                        result = a * b * 0.01;
                        break;
                    default:
                        break;
                }
                textBox1.Text += result; // выводится результат
                checkend = true; // переменная, отвечающая за окончание подсчетов
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            numbera = ""; // обнуление переменной
            numberb = ""; // обнуление переменной
            checktext = false;
            checkop = false;
            checkend = false;
            textBox1.Text = ""; // обнуление массива
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            if (!checkop && checktext){ // проверка операции и наличие текста
                operation = Operation.Add;
                checkop = true;
                textBox1.Text += '+'; // печатает символ операции
                j = textBox1.TextLength;
            }
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            if (!checktext) // проверка, есть ли символы. по дефолту false
            {
                textBox1.Text += '-';
                checktext = true;
            }
            if (checkop && (textBox1.Text[textBox1.TextLength - 1] != '-')) textBox1.Text += '-'; // проверка, что была операция и последний символ не минус
            if ((!checkop) && (textBox1.Text[textBox1.TextLength - 1] != '-'))
            {
                operation = Operation.Subtract; // выбор операции
                checkop = true; // значение true, которое говорит, что было вызвано арифмитическое действие
                textBox1.Text += '-'; // добавление знака минуса
                j = textBox1.TextLength; // счетчик символов равен следующему внесенному симвлоу
            }
        }


        private void buttonmultiply_Click(object sender, EventArgs e)
        {
            if (!checkop && checktext) // проверка операции и наличие текста
            {
                operation = Operation.Multiply; // выбор операции
                checkop = true;
                textBox1.Text += '*'; // печатает символ операции
                j = textBox1.TextLength; // счетчик для символов
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string patch = @"C:\Users\Dm1tr1ch\Desktop";
            DirectoryInfo dirinfo = new DirectoryInfo(patch);
            if (!dirinfo.Exists)
            {
                dirinfo.Create();
            }
            string text = textBox1.Text;

            using (FileStream fstream = new FileStream(@"C:\Users\Dm1tr1ch\Desktop\danya.txt", FileMode.OpenOrCreate))  
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);

                fstream.Write(array, 0, array.Length);
            }
            using (FileStream fstream = File.OpenRead(@"C:\Users\Dm1tr1ch\Desktop\danya.txt"))  
            {
                //convert 
                byte[] array = new byte[fstream.Length];
                //reading data 
                fstream.Read(array, 0, array.Length);
                //deconding 
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                label1.Text = textFromFile;
               
            }


        }

        private void buttonpower_Click(object sender, EventArgs e)
        {
            if (!checkop && checktext) // проверка операции и наличие текста
            {
                operation = Operation.Power; // выбор операции
                checkop = true;
                textBox1.Text += '^'; // печатает символ операции
                j = textBox1.TextLength; // счетчик для символов
            }
        }


        private void buttondivide_Click(object sender, EventArgs e)
        {
            if (!checkop && checktext) // проверка операции и наличие текста
            {
                operation = Operation.Divide; // выбор операции
                checkop = true;
                textBox1.Text += '/'; // печатает символ операции
                j = textBox1.TextLength; // счетчик для символов
            }
        }
        private void buttonabs_Click(object sender, EventArgs e)
        {
            if (!checkop && checktext) // проверка операции и наличие текста
            {
                operation = Operation.Abs; // выбор операции
                checkop = true;
                checkend = true;
                j = 0; // счетчик для символов
            }
        }
        private void buttonradical_Click(object sender, EventArgs e)
        {
            if (!checkop && checktext) // проверка операции и наличие текста
            {
                operation = Operation.Radical; // выбор операции
                checkop = true;
                checkend = true;
                j = 0; // счетчик для символов
            }
        }
        private void buttonpercent_Click(object sender, EventArgs e)
        {
            if (!checkop) // проверка операции и наличие текста
            {
                operation = Operation.Precent; // выбор операции
                checkop = true;
                textBox1.Text += '%'; // печатает символ действия
                j = textBox1.TextLength;
            }
        }
    }
}
