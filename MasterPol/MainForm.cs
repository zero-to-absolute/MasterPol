using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterPol
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кружков_УПDataSet2.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.Кружков_УПDataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кружков_УПDataSet11.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.Кружков_УПDataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кружков_УПDataSet.ТипыМатериалов". При необходимости она может быть перемещена или удалена.
            this.типыМатериаловTableAdapter.Fill(this.Кружков_УПDataSet.ТипыМатериалов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кружков_УПDataSet.Материалы". При необходимости она может быть перемещена или удалена.
            this.материалыTableAdapter.Fill(this.Кружков_УПDataSet.Материалы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кружков_УПDataSet.ПозицииПоставок". При необходимости она может быть перемещена или удалена.
            this.позицииПоставокTableAdapter.Fill(this.Кружков_УПDataSet.ПозицииПоставок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кружков_УПDataSet.Поставки". При необходимости она может быть перемещена или удалена.
            this.поставкиTableAdapter.Fill(this.Кружков_УПDataSet.Поставки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кружков_УПDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.Кружков_УПDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кружков_УПDataSet.Продукция". При необходимости она может быть перемещена или удалена.
            this.продукцияTableAdapter.Fill(this.Кружков_УПDataSet.Продукция);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кружков_УПDataSet.ПозицииЗаказов". При необходимости она может быть перемещена или удалена.
            this.позицииЗаказовTableAdapter.Fill(this.Кружков_УПDataSet.ПозицииЗаказов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кружков_УПDataSet1.Партнеры". При необходимости она может быть перемещена или удалена.
            this.партнерыTableAdapter.Fill(this.Кружков_УПDataSet.Партнеры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кружков_УПDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.Кружков_УПDataSet.Заказы);

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
