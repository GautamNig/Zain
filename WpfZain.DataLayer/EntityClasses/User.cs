using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Common.Library;

namespace WpfZain.DataLayer.EntityClasses
{
    [Table("User", Schema = "dbo")]
    public class User : CommonBase
    {
        private int _Id;
        private string _FirstName = string.Empty;
        private string _LastName = string.Empty;
        private int _Age;
        private string _Address;

        [Required]
        [Key]
        public int Id
        {
            get { return _Id; }
            set
            {
                _Id = value;
                RaisePropertyChanged("Id");
            }
        }

        [Required]
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                _FirstName = value;
                RaisePropertyChanged("FirstName");
            }
        }

        [Required]
        public string LastName
        {
            get { return _LastName; }
            set
            {
                _LastName = value;
                RaisePropertyChanged("LastName");
            }
        }

        [Required]
        public string Address
        {
            get { return _Address; }
            set
            {
                _Address = value;
                RaisePropertyChanged("Address");
            }
        }

        [Required]
        public int Age
        {
            get { return _Age; }
            set
            {
                _Age = value;
                RaisePropertyChanged("Age");
            }
        }
    }
}