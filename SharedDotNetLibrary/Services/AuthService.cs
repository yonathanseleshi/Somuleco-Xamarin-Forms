using System;
using SharedDotNetLibrary.DAOs;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Reactive.Subjects;
using System.Reactive.Linq;
using SharedDotNetLibrary.Models;
using SharedDotNetLibrary.ModelsRealm;

namespace SharedDotNetLibrary.Services
{
    public class AuthService
    {

        HttpClient _client;
        BehaviorSubject<bool> isAuthenticated;
        IObservable<bool> authStatus;
        FacebookUser fbUser;
        GoogleUser googleUser;
        User user;

        BehaviorSubject<User> userObj;
        IObservable<User> currentUser;

        BehaviorSubject<FacebookUser> fbUserObj;
        IObservable<FacebookUser> currentFbUser;

        BehaviorSubject<GoogleUser> googleUserObj;
        IObservable<GoogleUser> currentGoogleUser;

        public AuthService()
        {
            _client = new HttpClient();


            isAuthenticated = new BehaviorSubject<bool>(false);
           authStatus = isAuthenticated.AsObservable<bool>();

         

            userObj = new BehaviorSubject<User>(new User());

            currentUser = userObj.AsObservable<User>();

            fbUserObj = new BehaviorSubject<FacebookUser>(new FacebookUser());
            currentFbUser = fbUserObj.AsObservable<FacebookUser>();

            googleUserObj = new BehaviorSubject<GoogleUser>(new GoogleUser());
            currentGoogleUser = googleUserObj.AsObservable<GoogleUser>();



            checkAuth();
        }



        public void checkAuth() {

          
        
        
        }


    }
}
