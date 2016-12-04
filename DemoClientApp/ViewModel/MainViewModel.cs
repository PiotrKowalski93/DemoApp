using GalaSoft.MvvmLight;
using DemoClientApp.Model;
using GalaSoft.MvvmLight.Command;
using System.Net.Http;
using System.Collections.Generic;
using System;
using DemoDataModel.Models;
using System.Security.Cryptography;
using DemoClientApp.Encryption;
using Newtonsoft.Json;
using System.Text;

namespace DemoClientApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private SomeEncryptionClass encryption;

        private bool isAuthorized = false;
        private string login;
        private string password;

        #region Properties
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                Set(ref login, value);
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = encryption.Encrypt(value);
            }
        }

        public bool IsAuthorized
        {
            get
            {
                return isAuthorized;
            }
            set
            {
                Set(ref isAuthorized, value);
            }
        }
        #endregion

        public RelayCommand LoginUserCommand { private set; get; }

        public MainViewModel(IDataService dataService)
        {
            encryption = new SomeEncryptionClass();
            
            PrepareCommands();
        }

        public async void LoginUser()
        {
            UserToAuthorize user = new UserToAuthorize();
            user.Login = Login;
            user.Password = Password;
            
            string json = JsonConvert.SerializeObject(user);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080");
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("/api/login", content);
                var code = response.StatusCode; 
            }
            // IF CODE IS RIGHT THEN SHOW ALL CONTROLS/NEW VIEW
        }

        private void PrepareCommands()
        {
            LoginUserCommand = new RelayCommand(LoginUser);
        }

    }
}