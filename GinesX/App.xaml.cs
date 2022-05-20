using GinesX.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GinesX
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            WindowBilder.ShowMainWindow();
            InitDB();
            base.OnStartup(e);
        }
        void InitDB()
        {
            try
            {
                using(BDConnect db = new BDConnect())
                {
                    db.Database.Initialize(false);
                    User ASS = new User(1, "ASS", "ASS@yansde.ru", "PassWord!");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка инициализации"); //https://professorweb.ru/my/entity-framework/6/level2/2_10.php
            }
        }
    }
}
