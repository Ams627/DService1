﻿using System.Windows;

namespace DService1
{
    class ActualDialog<T> : IDialogService where T : Window, new()
    {
        object datacontext;
        public ActualDialog(object datacontext)
        {
            this.datacontext = datacontext;
        }

        public void ShowDialog()
        {
            var window = new T();
            window.DataContext = datacontext;
            window.ShowDialog();
        }
    }
}
