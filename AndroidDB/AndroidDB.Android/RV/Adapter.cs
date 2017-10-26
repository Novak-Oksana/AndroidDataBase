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
using Android.Support.V7.Widget;

namespace AndroidDB.Droid.RV
{
    public class PersonDBAdapter : RecyclerView.Adapter
    {
        List<Person> people;

        public PersonDBAdapter(List<Person> people)
        {
            this.people = people;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)//адаптер передаёт управление ViewHolder 
        {
            // set the view's size, margins, paddings and layout parameters
            var id = Resource.Layout.RecV;// создаём вьюшки
            var itemView = LayoutInflater.From(parent.Context).Inflate(id, parent, false);//возвращает вьюшку
            //развёртывание(представление) axml файла в виде экземпляра класса View; создаём конкретный объект класса в itemView из axml файла
            return new PersonViewHolder(itemView);//передаём вьюшки в ViewHolder
        }//PersonViewHolder это наш класс

        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)//отображение данных на экране
        {
            Person person = people.ElementAt(position);

            var holder = viewHolder as PersonViewHolder;//наш ViewHolder который создан в ViewHolder.cs
            holder.Id.Text = person.Id.ToString();//Id из ViewHolder.cs мы в него записываем Id из БД
            holder.FirstName.Text = person.FirstName;//обращаемся к полям Id, FirstName,LastName, Age конкретной вьюшки
            holder.LastName.Text = person.LastName;
            holder.Age.Text = person.Age.ToString();
        }

        public override int ItemCount
        {
            get { return people.Count; }//определяем сколько нужно создать ViewHolder из количества строк в базе; получаем количество строк или карточек 
        }
    }
}