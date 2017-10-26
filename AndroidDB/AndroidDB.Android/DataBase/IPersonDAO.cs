using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidDB
{
    public interface IPersonDAO
    {
        List<Person> Read();
        void Update(Person person);
        void Delete(Person person);
        void Create(Person person);
    }
}