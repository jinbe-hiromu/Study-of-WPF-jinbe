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
                                                                               new ProviderDataModel() { ProviderName = "DataQueue", Edition = EditionType.forIoT, ReleaseYear = 2016 },
                                                                               new ProviderDataModel() { ProviderName = "JSW.JAD", Edition = EditionType.forDENSO, ReleaseYear = 2021 },
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

        private void AddRow(object obj)
        {
            GridData.Add(new ProviderDataModel() { ProviderName= "Name", Edition = EditionType.ORiN2SDK , ReleaseYear = 2021});
        }

        public ICommand DeleteCommand
        {
            get
            {
                return _deleteCommand ??= new DelegateCommand(DeleteRow, _ => true);
            }
        }

        private void DeleteRow(object obj)
        {
            // 選択しているアイテムを削除
            GridData.Remove(SelectedItem);
        }
    }
}
