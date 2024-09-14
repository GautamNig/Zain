using System;
using System.Collections.Generic;
using System.Text;
using Common.Library;
using WpfZain.DataLayer.EntityClasses;

namespace WpfZain.ViewModelLayer
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Private Variables

        private User _UserEntity = new User();

        #endregion

        public User UserEntity
        {
            get { return _UserEntity; }
            set
            {
                _UserEntity = value;
                RaisePropertyChanged("UserEntity");
            }
        }


    }
}
