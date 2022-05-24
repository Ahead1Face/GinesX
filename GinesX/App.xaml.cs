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
                    
                    if(db.User.Count() == 0 && db.Game.Count() == 0)
                    {
                        User ASS = new User(1, "ASS", "ASS@yansde.ru", "PassWord!");
                        db.User.Add(ASS);
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка инициализации: {ex.Message}"); //https://professorweb.ru/my/entity-framework/6/level2/2_10.php
            }
        }
    }
}
