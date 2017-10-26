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
    public class DBFactory
    {
        public static IPersonDAO GetInstance(string type)
        {
            IPersonDAO db = null;

            switch (type)
            {
                case "SQLite": db = new PersonDAO_SQLite(); break;
                case "Realm": db = new PersonDAO_Realm(); break;
            }

            return db;
        }
    }
}