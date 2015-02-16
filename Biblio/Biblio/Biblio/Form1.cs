using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Biblio
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.TabPage tabpagetemplate1;
        private MySQLManager bibli;
        private bool flagfirst = true;

        public Form1(MySQLManager biblip)
        {
            InitializeComponent();
      




            //Heritage bibli
            bibli = biblip; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resized(object sender, EventArgs e)
        {
            if (!flagfirst)
            {
                tabControl1.SetBounds(0, menuStrip1.ClientSize.Height+1, this.ClientSize.Width, this.ClientSize.Height - (((statusStrip1.ClientSize.Height) * 2)+4));

            } flagfirst = false;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
          
            //Connection
            toolStripStatusLabel1.Text = "Connexion au serveur MySQL";
            toolStripStatusLabel2.Text = toolStripProgressBar1.Value.ToString() + "%";
            if (!bibli.Start())
            {
                toolStripStatusLabel1.Text = "Erreur Connexion au serveur MySQL";
                MessageBox.Show("Erreur lors de la connection au serveur");
            }
            else
            {
                toolStripStatusLabel1.Text = "Connexion au serveur Ok";
                toolStripProgressBar1.Value = 50;
                toolStripStatusLabel2.Text = toolStripProgressBar1.Value.ToString() + "%";

                //Requete recuperation produit
                bibli.SeekProductKnow("","");
                toolStripStatusLabel1.Text = "Recuperation des produit Ok";
                toolStripProgressBar1.Value = 100;
                toolStripStatusLabel2.Text = toolStripProgressBar1.Value.ToString() + "%";
                toolStripStatusLabel2.Text = "Prêt";

            }
        }

        private void ajouterUnProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void typeDeProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouteronglet("Livretest");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            /*e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();*/
        }

        private void toutSaufLongletSelctionnéToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ajouteronglet(string nom)
        {
            //Template d'onglet
            tabpagetemplate1 = new System.Windows.Forms.TabPage();
            this.tabpagetemplate1.Location = new System.Drawing.Point(4, 25);
            this.tabpagetemplate1.Name = "Template";
            this.tabpagetemplate1.Padding = new System.Windows.Forms.Padding(3);
            this.tabpagetemplate1.Size = new System.Drawing.Size(this.ClientSize.Width, this.ClientSize.Height);
            this.tabpagetemplate1.TabIndex = 0;
            this.tabpagetemplate1.Text = nom;
            this.tabpagetemplate1.UseVisualStyleBackColor = true;
            this.tabpagetemplate1.Click += new System.EventHandler(this.tabPage1_Click);
            tabControl1.Controls.Add(this.tabpagetemplate1);
        }

        private void longletSelectionnéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(tabControl1.SelectedTab);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
