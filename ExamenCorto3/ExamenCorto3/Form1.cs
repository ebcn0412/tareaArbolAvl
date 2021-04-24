using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenCorto3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArbolAVL arbolito = new ArbolAVL();
        proyecto nuevo = new proyecto();

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(1);comboBox2.Items.Add("Chiquimula"); comboBox2.Items.Add("Zacapa"); comboBox2.Items.Add("El Progreso");
            comboBox1.Items.Add(2);comboBox2.Items.Add("Alta Verapaz"); comboBox2.Items.Add("Baja Verapaz"); comboBox2.Items.Add("Guatemala");
            comboBox1.Items.Add(3);
        }
        public void limpiar()
        {
            MessageBox.Show("Registro Exitoso");
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevo.departamento = comboBox2.Text;
            nuevo.nombre = textBox2.Text;
            nuevo.monto = Convert.ToDouble(textBox3.Text);
            nuevo.prioridad = Convert.ToInt32(comboBox1.Text);
            arbolito.insertar(nuevo);
            limpiar();
            
        }
    }
}
