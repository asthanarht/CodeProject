using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CPMobile.Models;

namespace CPMobile.Views
{
    
    public class MasterPage:TabbedPage
    {

      
        public MasterPage()
        {


           
           
            Children.Add(new MainListPage() { Title="Article"});
            Children.Add(new MainListPage() { Title="Second"});

            
            
        }


      

    }
}
