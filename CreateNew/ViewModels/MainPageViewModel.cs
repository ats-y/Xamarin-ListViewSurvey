using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using CreateNew.Models;
using Prism.Navigation;
using Reactive.Bindings;
using Xamarin.Forms;

namespace CreateNew.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        /// <summary>
        /// 社員リスト
        /// </summary>
        private List<Employee> _employeeList;

        /// <summary>
        /// 社員リストプロパティ
        /// SetProperty()でViewのEmployeeListとバインディング。
        /// </summary>
        public List<Employee> EmployeeList
        {
            get { return _employeeList; }
            set { SetProperty(ref _employeeList, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Prism.Forms!";

            // 社員リストにデータを設定する。
            EmployeeList = new List<Employee>();
            EmployeeList.Add(
                new Employee(
                    name: "社員 太郎",
                    dest: Employee.EDestination.GoOut,
                    histories:new ObservableCollection<DestinationHistory>
                    {
                        new DestinationHistory
                        {
                            Title = "2019/9/25 10:00 出社",
                        },
                        new DestinationHistory
                        {
                            Title = "2019/9/25 13:00 外出",
                        },
                    }
                    ));
            EmployeeList.Add(
                new Employee(
                    name: "社員 二郎",
                    dest: Employee.EDestination.Unknown,
                    histories: new ObservableCollection<DestinationHistory>
                    {
                        new DestinationHistory
                        {
                            Title = "2019/9/25 9:00 出社",
                        },
                        new DestinationHistory
                        {
                            Title = "2019/9/25 10:00 外出",
                        },
                        new DestinationHistory
                        {
                            Title = "2019/9/25 17:30 帰宅",
                        },

                    }));

            EmployeeList.Add(
                new Employee(
                    name: "社員 三郎",
                    dest: Employee.EDestination.Unknown,
                    histories: new ObservableCollection<DestinationHistory>()
                    ));

        }

        /// <summary>
        /// 社員行タップコマンド
        /// </summary>
        public Command<Employee> ItemTappedCommand =>
            new Command<Employee>(emp =>
            {
               Debug.WriteLine("ItemTappedCommand");
               emp.ChangeDestination();
            });
    }
}
