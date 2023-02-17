using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace GuiDemo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void button1_Click_1(object sender, EventArgs e)
    {
        MessageBox.Show("Button Click");
    }
    //private void button1_Click(object sender, EventArgs e)
    //{
    //    MessageBox.Show("Welcome ");
    //}

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void label8_Click(object sender, EventArgs e)
    {

    }

    // Trayectoria km
    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        string txt = textBox1.Text;
        if (!double.TryParse(txt, out double d))
        {
            textBox1.Clear();
        }
        else
        {
            double costo_operario = 850.0 / 350.0 * Convert.ToDouble(textBox1.Text);
            textBox4.Text = costo_operario.ToString();

            double costo_comida = 200.0 / 350.0 * Convert.ToDouble(textBox1.Text);
            textBox15.Text = costo_comida.ToString();
        }
    }

    // Precio Diesel galon
    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        if (double.TryParse(textBox2.Text, out double d) || int.TryParse(textBox2.Text, out int i))
        {
            double precio_dep = Convert.ToDouble(textBox2.Text) * 0.25;
            textBox3.Text = precio_dep.ToString();
        }
        else
        {
            textBox2.Clear();
            textBox3.Clear();
        }
    }

    // Precio depreciacion
    private void textBox3_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox3.Text, out double d))
        {
            textBox3.Clear();
        }
    }

    // Rendimiento descargado
    private void textBox11_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox11.Text, out double d))
        {
            textBox11.Clear();
        }
        else
        {
            // Actualizar rendimientos
            double num25 = Convert.ToDouble(textBox11.Text) * 0.9;
            double num50 = Convert.ToDouble(textBox11.Text) * 0.7;
            double num100 = 9 * 1.6;
            textBox10.Text = num25.ToString();
            textBox9.Text = num50.ToString();
            textBox8.Text = num100.ToString();

            // Actualizar costos / retornos
            double trayecto = Convert.ToDouble(textBox1.Text);
            double rend25 = Convert.ToDouble(textBox10.Text);
            double rend50 = Convert.ToDouble(textBox9.Text);
            double rend100 = Convert.ToDouble(textBox8.Text);
            double precio_diesel = Convert.ToDouble(textBox2.Text);
            double precio_dep = Convert.ToDouble(textBox3.Text);
            double rend_descargado = Convert.ToDouble(textBox11.Text);

            double cost25 = ((trayecto / rend25) * (precio_diesel + precio_dep) + trayecto / rend_descargado * (precio_diesel + precio_dep));
            double cost50 = ((trayecto / rend50) * (precio_diesel + precio_dep) + trayecto / rend_descargado * (precio_diesel + precio_dep));
            double cost100 = ((trayecto / rend100) * (precio_diesel + precio_dep) + trayecto / rend_descargado * (precio_diesel + precio_dep));
            textBox7.Text = cost25.ToString();
            textBox6.Text = cost50.ToString();
            textBox5.Text = cost100.ToString();
        }
    }

    // Rendimiento 25%
    private void textBox10_TextChanged(object sender, EventArgs e)
    {
        
    }

    // Rendimiento 50%
    private void textBox9_TextChanged(object sender, EventArgs e)
    {
        
    }

    // Rendimiento 100%
    private void textBox8_TextChanged(object sender, EventArgs e)
    {
        
    }

    // Costo 25% Retorno 0
    private void textBox7_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox7.Text, out double d))
        {
            textBox7.Clear();
        }
    }

    // Costo 50% Retorno 0
    private void textBox6_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox6.Text, out double d))
        {
            textBox6.Clear();
        }
    }

    // Cost a mas de 50% retorno 0
    private void textBox5_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox5.Text, out double d))
        {
            textBox5.Clear();
        }
    }

    // Costo 25 - 50
    private void textBox13_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox13.Text, out double d))
        {
            textBox13.Clear();
        }
    }

    // Costo operario por dia
    private void textBox4_TextChanged(object sender, EventArgs e)
    {
       
    }

    // Costo comida por dia
    private void textBox15_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox15.Text, out double d))
        {
            textBox15.Clear();
        }
    }

    // Cobrar 0 - 25
    private void textBox14_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox14.Text, out double d))
        {
            textBox14.Clear();
        }
    }

    // Costo 50 - 100
    private void textBox12_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox12.Text, out double d))
        {
            textBox12.Clear();
        }
    }

    private void textBox16_TextChanged(object sender, EventArgs e)
    {
        if (!double.TryParse(textBox16.Text, out double d))
        {
            textBox16.Clear();
        }
    }
}
