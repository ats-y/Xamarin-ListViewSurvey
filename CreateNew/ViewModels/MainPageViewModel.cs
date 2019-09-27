using System;
using System.Collections.Generic;
using CreateNew.Models;
using Prism.Navigation;
using Reactive.Bindings;

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
                    name: "a",
                    dest: Employee.EDestination.GoOut));
            EmployeeList.Add(
                new Employee(
                    name: "B",
                    dest: Employee.EDestination.Unknown));
        }
    }
}
