using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Case09_ProviderListUsingDataGrid.View;

namespace Case09_ProviderListUsingDataGrid.ViewModel
{
    public class MainWindowViewModel
    {
        public ObservableCollection<ProviderDataModel> GridData{get; set;} = new ObservableCollection<ProviderDataModel>() 
                                                                            {  new ProviderDataModel() { ProviderName = "SLMP", Edition = EditionType.ORiN2SDK, ReleaseYear = 2015 },
                                                                               new ProviderDataModel() { ProviderName = "DataQueue", Edition = EditionType.ForIoT, ReleaseYear = 2016 },
                                                                               new ProviderDataModel() { ProviderName = "JSW.JAD", Edition = EditionType.ForDenso, ReleaseYear = 2021 },
                                                                            };


        public ProviderDataModel SelectedItem { get; set; } = new ProviderDataModel();

        private DelegateCommand _addCommand;
        private DelegateCommand _deleteCommand;

        public ICommand AddCommand
        {
            get
            {
                return _addCommand ??= new DelegateCommand(AddRow, _ => true);
            }
        }

        //private void AddRow(object _)    引数を使用しない場合は「_」で書くのがお約束
        private void AddRow()
        {
            GridData.Add(new ProviderDataModel() { ProviderName= "Name", Edition = EditionType.ORiN2SDK , ReleaseYear = 2021});
        }

        public ICommand DeleteCommand
        {
            get
            {
                return _deleteCommand ??= new DelegateCommand(DeleteRow, _ => GridData.Count>0);
            }
        }

        private void DeleteRow()
        {
            // 選択しているアイテムを削除
            GridData.Remove(SelectedItem);
        }
    }
}
