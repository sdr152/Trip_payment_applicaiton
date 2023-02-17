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

    private void textBox3_TextChanged(object sender, EventArgs e)
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
    
    // Rendimiento descargado
    private void textBox11_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox11.Text, out double d))
        {
            textBox11.Clear();
        }
        else
        {
            double num25 = Convert.ToDouble(textBox11.Text) * 0.9;
            double num50 = Convert.ToDouble(textBox11.Text) * 0.7;
            double num100 = 9 * 1.6;
            textBox10.Text = num25.ToString();
            textBox9.Text = num50.ToString();
            textBox8.Text = num100.ToString();
        }
    }

    // Rendimiento 25%
    private void textBox10_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox10.Text, out double d))
        {
            textBox10.Clear();
        }
        else
        {
            double num = Convert.ToDouble(textBox11.Text) * 0.9;
            textBox10.Text = num.ToString();
        }
    }

    // Rendimiento 50%
    private void textBox9_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox9.Text, out double d))
        {
            textBox9.Clear();
        }
        else
        {
            double num = Convert.ToDouble(textBox11.Text) * 0.7;
            textBox9.Text = num.ToString();
        }
    }

    // Rendimiento 100%
    private void textBox8_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox8.Text, out double d))
        {
            textBox8.Clear();
        }
        else
        {
            double num = Convert.ToDouble(textBox11.Text) * 1.6;
            textBox11.Text = num.ToString();
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

    // Costo operario por dia
    private void textBox4_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox4.Text, out double d))
        {
            textBox4.Clear();
        }
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
