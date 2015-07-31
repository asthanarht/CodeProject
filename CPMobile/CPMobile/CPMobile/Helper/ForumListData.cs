using CPMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CPMobile.Helper
{
    public static class ForumListData
    {
        public static List<ForumType> GetData()
		{
            return new List<ForumType> {
				new ForumType () {
					ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W") },
					Name = ".Net Framework",
					ForumId=1650
				},
                new ForumType () {
					ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W") },
					Name = "C/C++/MFC",
					ForumId=1647
				},
                new ForumType () {
					ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W") },
					Name = "C#",
					ForumId=1649
				},
                new ForumType () {
					ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W") },
					Name = "Java",
					ForumId=1643
				},
                new ForumType () {
					ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W") },
					Name = "LINQ",
					ForumId=1004117
				},
                new ForumType () {
					ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W") },
					Name = "Visual Basic",
					ForumId=1646
				},
                new ForumType () {
					ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W") },
					Name = "Visual Studio",
					ForumId=3831
				},
                new ForumType () {
					ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W") },
					Name = "WCF and WF",
					ForumId=1004114
				},
                new ForumType () {
					ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W") },
					Name = ".NetFramework",
					ForumId=1650
				},
                new ForumType () {
					ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W") },
					Name = "Windows form",
					ForumId=387161
				},
                new ForumType () {
					ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W") },
					Name = "ASP.NET",
					ForumId=12076
				},
                new ForumType () {
					ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W") },
					Name = "JavaScript",
					ForumId=1580226
				},
                new ForumType () {
					ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W") },
					Name = "Web Development",
					ForumId=1640
				},
                new ForumType () {
					ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W") },
					Name = "Android",
					ForumId=1848626
				},
                new ForumType () {
					ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W") },
					Name = "iOS",
					ForumId=1876716
				},
                 new ForumType () {
					ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W") },
					Name = "Mobile",
					ForumId=13695
				},
                 new ForumType () {
					ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W") },
					Name = "Database",
					ForumId=1725
				},
            };
        }
    }
}
