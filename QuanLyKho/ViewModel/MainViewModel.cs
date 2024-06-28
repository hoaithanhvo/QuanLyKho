using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLyKho.ViewModel
{
    public class MainViewModel : BaseViewModel
    {

        public bool IsLoading  = false;

        public MainViewModel()
        {
            if (!IsLoading)
            {
                IsLoading = true;
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();
            }

        }
    }
}
