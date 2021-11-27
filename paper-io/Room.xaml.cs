﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace paper_io
{
    /// <summary>
    /// Логика взаимодействия для Start.xaml
    /// </summary>
    public partial class Room : Window
    {

        public Room(byte n)
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(MovePlayer);
            timer.Start();
        }
        /// <summary>
        /// движение игрока (как будут меняться координаты игрока при нажатии)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovePlayer(object sender, EventArgs e)
        {

        }
    }
}
