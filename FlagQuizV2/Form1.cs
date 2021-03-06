﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagQuizV2
{
    public partial class Form1 : Form
    {
        TestForm testForm;
        TrainForm trainForm;
        static int var1; 

        public Form1(string selectedCtns)
        {
            selectedCtns = pickContinentBox.SelectedItems.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void mainTrainBtn_Click(object sender, EventArgs e)
        {
            trainForm = new TrainForm(var1); // hier wordt TrainForm geïnstantieerd(aangemaakt).
            MessageBox.Show(var1.ToString()); //kleine test of de juiste data aan 'var1' wordt meegegeven
            var selectedContinents = pickContinentBox.SelectedItems.ToString();


            if(selectedContinents == "4")
            {
                this.Hide();
                trainForm.Show();
            }
            else
            {
                MessageBox.Show("Please select 'Europe' as a testcase, other continents have to be implemented");
            }
        }

        private void pickContinentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var1 = pickContinentBox.SelectedIndex; //Hier geef ik de index van het geselecteerde continent mee aan var1.
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void mainTestBtn_Click(object sender, EventArgs e)
        {
            testForm = new TestForm(var1); // hier wordt TestForm geïnstantieerd(aangemaakt).
            MessageBox.Show(var1.ToString()); //kleine test of de juiste data aan 'var1' wordt meegegeven
            var selectedContinents = pickContinentBox.SelectedItems.ToString();


            if (selectedContinents != null)
            {
                this.Hide();
                testForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a continent");
            }
        }
    }
}
