using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateNew.Models;
using Xamarin.Forms;

namespace CreateNew.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Debug.WriteLine("コンストラクタ");

            InitializeComponent();

            
            // 社員リストのタップイベント
            EmployeeListView.ItemTapped += (sender, e) =>
            {
                Debug.WriteLine("tap");

                // タップされた行のアイテムの選択状態を切り替える。
                Employee emp = e.Item as Employee;
                if( emp != null)
                {
                    emp.ChangeDestination();
                }
            };
        }
    }
}
