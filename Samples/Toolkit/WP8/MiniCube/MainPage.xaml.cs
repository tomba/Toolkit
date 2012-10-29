﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MiniCube.Resources;

namespace MiniCube
{
    public partial class MainPage : PhoneApplicationPage
    {
        private MiniCubeGame helloWorldGame;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            helloWorldGame = new MiniCubeGame();
            helloWorldGame.Run(DrawingSurface);
        }
    }
}