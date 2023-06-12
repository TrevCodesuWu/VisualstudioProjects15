using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GymManagement.Models; 

namespace GymManagement.ViewModels
{
    public class User_Gender_ViewModel
    {
        public UserProfile userprofile { get; set; }
        public IEnumerable<Gender> GenderList { get; set; }

    }
}