using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        IFirebaseConfig databaza = new FirebaseConfig()
        {
            AuthSecret = "vySWaZ1JWoZoDOOkJtZYLldqDm86tqBJbqu6GDN2",
            BasePath = "https://registracia-vakcin-default-rtdb.firebaseio.com"

        };

        IFirebaseClient client;


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(databaza);
            }

            catch
            {
                MessageBox.Show("Nemožno zaregistrovť, skúste neskôr");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User uzivatel = new User()
            {
                Meno = tboxmeno.Text,
                Priezvisko = tboxpriezvisko.Text,
                Bydlisko = tboxbydlisko.Text,
                Email = tboxemail.Text,
                Psč = tboxpsc.Text,
                Poisťovňa = tboxpoistovna.Text,
                Pohlavie = checkBox1.Text 



            };

            SetResponse set = client.Set(@"Appka/" + tboxmeno.Text, uzivatel);

            MessageBox.Show("Vaša regsitrácia bola prihjatá.Bude Vám poslaná SMS s ďaľšmi inštrukciami.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FirebaseResponse set = client.Delete(@"appka/" + tboxmeno.Text);
            MessageBox.Show("Client úspešne odtránený!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User uzivatel = new User()
            {
                Meno = tboxmeno.Text,
                Priezvisko = tboxpriezvisko.Text,
                Bydlisko = tboxbydlisko.Text,
                Email = tboxemail.Text, 
                Psč = tboxpsc.Text,
                Poisťovňa = tboxpoistovna.Text,
                Pohlavie = checkBox1.Text



            };

            SetResponse set = client.Set(@"Appka/" + tboxmeno.Text, uzivatel);

            MessageBox.Show("Prebehla najnovšia aktualizácia databázy!");
        }

        
    }

}














