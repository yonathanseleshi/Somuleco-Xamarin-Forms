using System;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SharedDotNetLibrary.ViewModels
{
    public class SignupViewModel : INotifyPropertyChanged
    {

        string firstName;
        string lastName;
        string email;
        string username;
        string displayName;
        string password;
        string confirmPassword;

        public Command Submit { get; }

        public SignupViewModel()
        {

            Submit = new Command(SubmitSignup)
        }

        public string FirstName {
            get
            {
                return firstName;
            }
           
         set 
            {

            firstName = value;
            OnPropertyChanged(nameof(FirstName));
            
            } 

        }
       

        public string LastName {
            get 
            { 
            
            return lastName; 
            
            }
            set
            {

             lastName = value;
             OnPropertyChanged(nameof(LastName));
            } 
         }
       

        public string Email { 
            get 
            { 
                return email; 
            } 
            set 
            { 
                email = value;
                OnPropertyChanged();
            }
        }


       

        public string Username { 
            get
            {
                return username;
             }
            set
            {
                username = value;
                OnPropertyChanged();
            }
         }


        public string DisplayName { get => displayName; set => displayName = value; }


        public string Password { get => password; set => password = value; }

        public string ConfirmPassword { get => confirmPassword; set => confirmPassword = value; }


        public event PropertyChangedEventHandler PropertyChanged;


        void SubmitSignup()
        {


        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
