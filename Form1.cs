//
//GUI-based Asian Options Stock Pricing Program
//
//Author: Adolfo Moreno
//U. of Illinois, Chicago
//CS341, Fall 2015
//Homework 7
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {
    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {
    }

    private void textBox6_TextChanged(object sender, EventArgs e)
    {
    }

    private void textBox7_TextChanged(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //Get the inputs from all text fields and convert them
      long sims = System.Convert.ToInt64(this.textBox1.Text);
      double initialPrice = System.Convert.ToDouble(this.textBox2.Text);
      double excercisePrice = System.Convert.ToDouble(this.textBox3.Text);
      double upGrowth = System.Convert.ToDouble(this.textBox4.Text);
      double downGrowth = System.Convert.ToDouble(this.textBox5.Text);
      double interestRate = System.Convert.ToDouble(this.textBox6.Text);
      long periods = System.Convert.ToInt64(this.textBox7.Text);

      //Run
      int start = System.Environment.TickCount; //Start Time
      this.Cursor = Cursors.WaitCursor;
      double pricing = AsianOptionsLib.Pricing.Simulation(initialPrice, excercisePrice, upGrowth, downGrowth, interestRate, periods, sims);
      this.Cursor = Cursors.Default;
      int stop = System.Environment.TickCount;
      double elapsedTimeInSecs = (stop - start) / 1000.0;

      this.listBox1.Items.Clear();//Clear Text Box for next iteration

      //Populate listBox with Items
      this.listBox1.Items.Add("*********PARAMETERS USED*********");
      this.listBox1.Items.Add("Simulations Run: " + System.Convert.ToString(sims));
      this.listBox1.Items.Add("Initial Price: $" + initialPrice);
      this.listBox1.Items.Add("Excercise Price: $" + excercisePrice);
      this.listBox1.Items.Add("Up Growth: " + upGrowth);
      this.listBox1.Items.Add("Down Growth: " + downGrowth);
      this.listBox1.Items.Add("Interest Rate: " + interestRate + "%");
      this.listBox1.Items.Add("Maturity Period: " + initialPrice);

      //Print  results
      this.listBox1.Items.Add("\n");
      this.listBox1.Items.Add("*********RESULTS*********");
      this.listBox1.Items.Add("Price of Option: $" + System.Convert.ToString(pricing));
      this.listBox1.Items.Add("Time: " + elapsedTimeInSecs + " secs");

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

 

  }
}
