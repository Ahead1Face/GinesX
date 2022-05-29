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
            base.OnStartup(e);
            InitDB();
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
                        string imagesPath = @"Image\Game\";
                        Game ACV = new Game(1, "Assassin’s Creed Valhalla", 2390, imagesPath + "Assassin’s Creed Valhalla.jpg"); 
                        db.Game.Add(ACV);
                        Game KCD = new Game(1, "Kindom Come Deliverance", 600, imagesPath + "KindomComeDeliverance.jpg");
                        db.Game.Add(KCD);
                        Game RDR2 = new Game(1, "Red Dead Redemption 2", 4300, imagesPath + "Red Dead Redemption 2.jpeg");
                        db.Game.Add(RDR2);
                        Game Sify = new Game(1, "Sify", 3000, imagesPath + "sify.jpg");
                        db.Game.Add(Sify);
                        Game LSS = new Game(1, "The Skywalker Saga", 1400, imagesPath + "The Skywalker Saga.jpg");
                        db.Game.Add(LSS);
                        Game TW3 = new Game(1, "The Witcher 3", 300, imagesPath + "Witcher3.jpg");
                        db.Game.Add(TW3);

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
