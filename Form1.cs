using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;

namespace GuiDemo;

public partial class Form1 : Form
{
    
    public Form1()
    {
        InitializeComponent();
        textBox18.Enabled = false;
        textBox3.AccessibleDescription = "SAFSDFASDFASDFASDFASDfas";
        
        
    }
    private void button1_Click_1(object sender, EventArgs e)
    {
        //MessageBox.Show("Button Click");
        textBox11_TextChanged(sender, e);
        textBox10_TextChanged(sender, e);
        textBox9_TextChanged(sender, e);
        textBox8_TextChanged(sender, e);
        textBox7_TextChanged(sender, e);
        textBox6_TextChanged(sender, e);
        textBox5_TextChanged(sender, e);
        textBox12_TextChanged(sender, e);
        textBox13_TextChanged(sender, e);
        textBox14_TextChanged(sender, e);
        textBox15_TextChanged(sender, e);
        textBox4_TextChanged(sender, e);
        
        textBox16_TextChanged_1(sender, e);
        textBox17_TextChanged(sender, e);
        textBox18_TextChanged(sender, e);
        textBox19_TextChanged(sender, e);
        textBox20_TextChanged(sender, e);
        textBox21_TextChanged(sender, e);
        textBox22_TextChanged(sender, e);

    }

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
        string trayecto = textBox1.Text;
        if (!double.TryParse(trayecto, out double d))
        {
            textBox1.Text = "0.0";
        }  
    }

    // Precio Diesel galon
    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        
        if (double.TryParse(textBox2.Text, out double d) || int.TryParse(textBox2.Text, out int i))
        {
            textBox3_TextChanged(sender, e);   
        }
        else
        {
            textBox2.Text = "0.0";
            textBox3.Text = "0.0";
        }
    }

    // Precio depreciacion
    private void textBox3_TextChanged(object sender, EventArgs e)
    {
        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.25);
    }

    // Rendimiento descargado
    private void textBox11_TextChanged(object sender, EventArgs e)
    {
        textBox11.Text = "25.6";
        textBox10_TextChanged(sender, e);
        textBox9_TextChanged(sender, e);
        textBox8_TextChanged(sender, e);
    }

    // Rendimiento 25%
    private void textBox10_TextChanged(object sender, EventArgs e)
    {
        textBox10.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 0.9);
    }

    // Rendimiento 50%
    private void textBox9_TextChanged(object sender, EventArgs e)
    {
        textBox9.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 0.7);
    }

    // Rendimiento 100%
    private void textBox8_TextChanged(object sender, EventArgs e)
    {
        textBox8.Text = Convert.ToString(9.0 * 1.6);
    }

    // Costo 25% Retorno 0
    private void textBox7_TextChanged(object sender, EventArgs e)
    {
        double trayectoria = Convert.ToDouble(textBox1.Text);
        double rend_descargado = Convert.ToDouble(textBox11.Text);
        double rend25 = Convert.ToDouble(textBox10.Text);
        double precio_diesel = Convert.ToDouble(textBox2.Text);
        double precio_dep = Convert.ToDouble(textBox3.Text);
        textBox7.Text = Convert.ToString(trayectoria/rend25*(precio_diesel+precio_dep) + trayectoria/rend_descargado*(precio_diesel+precio_dep));
    }

    // Costo 50% Retorno 0
    private void textBox6_TextChanged(object sender, EventArgs e)
    {
        double trayectoria = Convert.ToDouble(textBox1.Text);
        double rend_descargado = Convert.ToDouble(textBox11.Text);
        double rend50 = Convert.ToDouble(textBox9.Text);
        double precio_diesel = Convert.ToDouble(textBox2.Text);
        double precio_dep = Convert.ToDouble(textBox3.Text);
        textBox6.Text = Convert.ToString(trayectoria / rend50 * (precio_diesel + precio_dep) + trayectoria / rend_descargado * (precio_diesel + precio_dep));

    }

    // Cost a mas de 50% retorno 0
    private void textBox5_TextChanged(object sender, EventArgs e)
    {
        double trayectoria = Convert.ToDouble(textBox1.Text);
        double rend_descargado = Convert.ToDouble(textBox11.Text);
        double rend100 = Convert.ToDouble(textBox8.Text);
        double precio_diesel = Convert.ToDouble(textBox2.Text);
        double precio_dep = Convert.ToDouble(textBox3.Text);
        textBox5.Text = Convert.ToString(trayectoria / rend100 * (precio_diesel + precio_dep) + trayectoria / rend_descargado * (precio_diesel + precio_dep));
    }

    // Costo total al 0 - 25%
    private void textBox14_TextChanged(object sender, EventArgs e)
    {
        double cost25 = Convert.ToDouble(textBox7.Text);
        double costo_operario = Convert.ToDouble(textBox12.Text);
        double costo_comida = Convert.ToDouble(textBox13.Text);
        double costo_total25 = cost25 + costo_operario + costo_comida;
        textBox14.Text = costo_total25.ToString();
    }

    // Costo total al 25 - 50%
    private void textBox15_TextChanged(object sender, EventArgs e)
    {
        double cost50 = Convert.ToDouble(textBox6.Text);
        double costo_operario = Convert.ToDouble(textBox12.Text);
        double costo_comida = Convert.ToDouble(textBox13.Text);
        double costo_total25 = cost50 + costo_operario + costo_comida;
        textBox15.Text = costo_total25.ToString();
    }

    // Costo a mas de 50%
    private void textBox4_TextChanged(object sender, EventArgs e)
    {
        double cost100 = Convert.ToDouble(textBox5.Text);
        double costo_operario = Convert.ToDouble(textBox12.Text);
        double costo_comida = Convert.ToDouble(textBox13.Text);
        double costo_total25 = cost100 + costo_operario + costo_comida;
        textBox4.Text = costo_total25.ToString();
    }

    // Costo operario por dia
    private void textBox12_TextChanged(object sender, EventArgs e)
    {
        // Actualizar Costo Operario y Costo Comida
        double costo_operario = 850.0 / 350.0 * Convert.ToDouble(textBox1.Text);
        textBox12.Text = costo_operario.ToString();
    }

    // Costo comida por dia
    private void textBox13_TextChanged(object sender, EventArgs e)
    {
        double costo_comida = 200.0 / 350.0 * Convert.ToDouble(textBox1.Text);
        textBox13.Text = costo_comida.ToString();
    }

    // Cobrar 0 - 25
    private void textBox16_TextChanged_1(object sender, EventArgs e)
    {
        double cobro25 = Convert.ToDouble(textBox14.Text) / 0.7;
        textBox16.Text = cobro25.ToString();
    }

    // Cobrar 25 - 50
    private void textBox17_TextChanged(object sender, EventArgs e)
    {
        double cobro50 = Convert.ToDouble(textBox15.Text) / 0.7;
        textBox17.Text = cobro50.ToString();
        textBox18_TextChanged(sender, e);
    }

    // Cobrar 100
    private void textBox18_TextChanged(object sender, EventArgs e)
    {
        double cobro100 = Convert.ToDouble(textBox4.Text) / 0.7;
        textBox18.Text = cobro100.ToString();
    }
    
    // Descuento
    private void textBox19_TextChanged(object sender, EventArgs e)
    {
        string dsc = textBox19.Text;
        if (!Double.TryParse(dsc, out double d))
        {
            textBox19.Text = "0.0";
        }
    }

    // Precio25 con descuento
    private void textBox20_TextChanged(object sender, EventArgs e)
    {
        double dsc = Convert.ToDouble(textBox19.Text);
        double cobro25 = Convert.ToDouble(textBox16.Text);
        double precio_des25 = cobro25 * (1.0 - (dsc / 100));
        textBox20.Text = precio_des25.ToString();
    }

    // Precio50 con descuento 
    private void textBox21_TextChanged(object sender, EventArgs e)
    {
        double dsc = Convert.ToDouble(textBox19.Text);
        double cobro50 = Convert.ToDouble(textBox17.Text);
        double precio_des25 = cobro50 * (1.0 - (dsc / 100));
        textBox21.Text = precio_des25.ToString();
    }

    // Precio100 con descuento 
    private void textBox22_TextChanged(object sender, EventArgs e)
    {
        double dsc = Convert.ToDouble(textBox19.Text);
        double cobro100 = Convert.ToDouble(textBox18.Text);
        double precio_des25 = cobro100 * (1.0 - (dsc / 100));
        textBox22.Text = precio_des25.ToString();
    }
}

