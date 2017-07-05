using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Controls.Maps;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EntryFarmWorkTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            using (var db = new Context())
            {
                Blogs.ItemsSource = db.GroupLeadersViews.ToList();
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new Context())
            {
                if (NewBlogUrl.Text == "") return;
             
                var view = new CourseLeadersView { SCLAppNo = 123456, SchoolName = NewBlogUrl.Text, CourseCode = "799573337" };
                db.GroupLeadersViews.Add(view);             
                //var list = db.GroupLeadersViews.ToList();
                //foreach (var et in list)
                //{
                //    if (et.SchoolName == "")
                //    {
                //        db.GroupLeadersViews.RemoveRange(et);
                //    }
                //}
                db.SaveChanges();
                Blogs.ItemsSource = db.GroupLeadersViews.ToList();
            }
        }
    }
}
