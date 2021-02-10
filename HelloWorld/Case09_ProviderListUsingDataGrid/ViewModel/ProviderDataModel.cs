namespace Case09_ProviderListUsingDataGrid.ViewModel
{
    public enum EditionType
    {
        ORiN2SDK,
        forIoT,
        forDENSO
    }

    public class ProviderDataModel : BasePropertyChanged
    {
        private string _providerName;
        public string ProviderName { 
            get { return _providerName; } 
            set { SetValue(value, ref _providerName); } 
        }

        private EditionType _edition;
        public EditionType Edition
        {
            get { return _edition; }
            set { SetValue(value, ref _edition); }
        }

        private ushort _releaseYear;
        public ushort ReleaseYear {
            get {return _releaseYear; }
            set { SetValue(value, ref _releaseYear); } 
        }

    }
}