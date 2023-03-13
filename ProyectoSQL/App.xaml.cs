using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyectoSQL.Data;
using System.IO;

namespace ProyectoSQL
{    
    public partial class App : Application
    {
        static SQLiteHelper db;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
        public static SQLiteHelper SQLiteDB
        {
            get 
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"Escuela.db3"));
                }
                return db; 
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
