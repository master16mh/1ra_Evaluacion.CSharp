using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Evaluación1c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declarar la variable
            string lista;
            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                MessageBox.Show("Ingrese un valor");
                return;

            }


            //asignar a la variable el valor de lo que ingresemos en el cuadro de texto
            lista = Convert.ToString(textBox1.Text);
            //agregamos lo que tenga la variable valor al listbox
            listBox1.Items.Add(lista);
            //limpie items de listbox2
            listBox2.Items.Clear();


            //generamos ciclo for que empiece desde 1 para que cuente desde 1 
            for (int i = 1; i <= listBox1.Items.Count; i++)
            {
               
                listBox2.Items.Add(i.ToString());
                
            }
            //limpiar el cuadro de texto y darle el enfoque
            textBox1.Text = "";
        }

        /// <summary>
        /// metodo privado que elimina a a
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            //declarar una variable tipo entero
            string valor;
            int valor1;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Ingrese un valor");
                return;
            }

            valor1 = Convert.ToInt32(textBox1.Text); //lo que ingresamos en cuadro de texto sera el indice
            if (valor1 > listBox1.Items.Count - 1)
            {
                MessageBox.Show ("El valor ingresado está fuera del índice");
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                valor = listBox1.Items[valor1].ToString();
                MessageBox.Show("El nombre es: " + valor);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {
            var ok = listBox1.SelectedItem;
            string item;
            
            item = Convert.ToString(listBox1.SelectedItem);
            listBox2.Items.Remove(listBox1.Items.Count.ToString());
            listBox1.Items.Remove(item);     
            textBox1.Text = "";
            listBox1.Focus();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
