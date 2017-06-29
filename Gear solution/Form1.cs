using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace Gear_solution
{
    public partial class Form1 : Form
    {
        // DATA!!!
        double[] Modules = { /*0.5, 0.6, 0.7, 0.8, 0.9,*/ 1.0, 1.125, 1.25, 1.375, 1.5, 1.75, 2.0, 2.25, 2.5,
                             2.75, 3.0, 3.5, 4.0, 4.5, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0, 11.0, 12.0, 14.0,
                             16.0, 18.0, 20.0, 22.0, 25.0, 28.0, 32.0, 36.0};
        double teethNum = 0;                // число зубьев шестерни           - z
        double diaDelitelnoyOkruznosty = 0; // диаметр делительной окружности  - d = m * z
        double diaVershinZubiev = 0;        // диаметр вершин зубъев           - da = d + (2 * m) + (2 * x * m)     // da = m * (z + 2)
        double diaVpadinZubiev = 0;         // диаметр впадин зубъев           - df = d - (2.5 * m) + (2 * x * m)   // df = m * (z - 2.5)   
        double koeffSmestenia = 0;          // коэффициент смещения            - x
        int selectedModul = 0;              // выбранный модуль шестерни (индекс в массиве Modules)
        int ModulListLength = 0;            // длина списка модулей

        // завершение DATA


        
        // конструктор of - CLASS  FORM1 : FORM  !!!
        public Form1()
        {
            InitializeComponent();
            ModulListLength = Modules.GetLength(0);
            int i = 0;                      // подсчет циклов
            // инициализация listBox1
            while (i < ModulListLength)
            {
                listBox1.Items.Add(Modules[i++]);                
            }
            listBox1.SelectedIndex = 0;     // выделяем первую строку в listBox1 
        }   // завершение конструктор of - CLASS  FORM1 : FORM  !!!  



        // txtBoxInt1_TextChanged
        private void txtBoxInt1_TextChanged(object sender, EventArgs e)
        {
            // Конвертировать текст в окне в double (а не в int !)
            txtBoxInt1.strToDbl(out teethNum);
            // показать диаметр делительной окружности
            showDiaDelitelnoyOkruznosty();
            // показать диаметр окружности вершин зубъев
            showDiaVershinZubiev();
            // показать диаметр окружности впадин зубъев
            showDiaVpadinZubiev();
        }   // завершение txtBoxInt1_TextChanged



        // listBox1_SelectedIndexChanged
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedModul = listBox1.SelectedIndex;
            // показать диаметр делительной окружности            
            showDiaDelitelnoyOkruznosty();
            // показать диаметр окружности вершин зубъев
            showDiaVershinZubiev();
            // показать диаметр окружности впадин зубъев
            showDiaVpadinZubiev();
        }   // завершение listBox1_SelectedIndexChanged



        // txtBoxDbl1_TextChanged
        private void txtBoxDbl1_TextChanged(object sender, EventArgs e)
        {
            // Конвертировать текст в окне в double
            txtBoxDbl1.strToDbl(out koeffSmestenia);
            // показать диаметр окружности вершин зубъев
            showDiaVershinZubiev();
            // показать диаметр окружности впадин зубъев
            showDiaVpadinZubiev();
        }   // завершение txtBoxDbl1_TextChanged



        //***** S H O W *****//

        // showDiaDelitelnoyOkruznosty
        void showDiaDelitelnoyOkruznosty()
        {           
            // вычислить диаметр делительной окружности
            // диаметр делительной окружности   d = m * z
                diaDelitelnoyOkruznosty = Modules[selectedModul] * teethNum;
                aLabel1.setText(diaDelitelnoyOkruznosty, " мм");
        }   // завершение showDiaDelitelnoyOkruznosty



        // showDiaVershinZubiev
        void showDiaVershinZubiev()
        {
            if (teethNum > 0)
            {
                // вычислить диаметр окружности вершин зубъев
                // диаметр вершин зубъев  da = d + (2 * m) + (2 * x * m)       // da = m * (z + 2)
                diaVershinZubiev = diaDelitelnoyOkruznosty + (2.0 * Modules[selectedModul])
                                   + (koeffSmestenia * 2.0 * Modules[selectedModul]);
                //diaVershinZubiev = Modules[selectedModul] * (teethNum + 2);
                aLabel2.setText(diaVershinZubiev, " мм");
            }
            else
                aLabel2.setText( 0, " мм");
        }   // завершение showdiaVershinZubiev

        
        
        // showDiaVpadinZubiev
        void showDiaVpadinZubiev()
        {
            if (teethNum > 0)
            {
                // вычислить диаметр окружности впадин зубъев
                // диаметр впадин зубъев  df = d - (2.5 * m) + (2 * x * m)      // df = m * (z - 2,5)
                diaVpadinZubiev = diaDelitelnoyOkruznosty - (2.5 * Modules[selectedModul])
                                  + (koeffSmestenia * 2.0 * Modules[selectedModul]);
                //diaVpadinZubiev = Modules[selectedModul] * (teethNum - 2.5);
            aLabel3.setText(diaVpadinZubiev, " мм");
            }
            else
                aLabel3.setText( 0, " мм");
        }   // завершение showDiaVpadinZubiev  



        //
        //  кнопка "Exit"
        //
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Чета не понял - ВЫХОДИМ???", "Хрена-се...",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }   // завершение button1_Click() - кнопка "Exit"
        }

    }   // завершение class Form1 : Form
}       // завершение namespace Gear_solution
