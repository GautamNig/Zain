using System;
using System.Collections.Generic;
using System.Text;
using Common.Library;
using WpfZain.DataLayer.EntityClasses;

namespace WpfZain.AppLayer
{
    public class AppSettings : CommonBase
    {
        private User _UserEntity = new User();

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
