﻿using System;
using System.Windows.Forms;

namespace NetOne_Cash_Requisition_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loginfrm());
        }
    }
}
