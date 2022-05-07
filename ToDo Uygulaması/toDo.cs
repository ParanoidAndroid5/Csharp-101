using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoUygulaması
{
    public class toDo
    {
        // baslık icerik atanan kisi büyüklük
        public static int sayac = 0;
        
       public int Id { get => sayac; set => sayac = value; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }

        public TakimUyesi AtananKisi { get; set; }
        public Buyukluk Buyukluk { get; set; }
        public Board Board { get; set; }

        public toDo()
        {
            sayac += 1;
            Id = sayac;

        }


    }

    public class ToDos
    {
        public static List<toDo> toDoList;
        public List<toDo> ToDoList
        {
            get { return toDoList; }
            private set { toDoList = value; }
        }
        public static List<TakimUyesi> kisiList;
        public List<TakimUyesi> KisiList
        {
            get { return kisiList; }
            private set { kisiList = value; }
        }
        public ToDos()
        {
            ToDoList = new List<toDo>();
            KisiList = new List<TakimUyesi>();
            KisiList.Add(new TakimUyesi() { Ad = "Kisi 1" });
            KisiList.Add(new TakimUyesi() { Ad = "Kisi 2" });
            KisiList.Add(new TakimUyesi() { Ad = "Kisi 2" });
            KisiList.Add(new TakimUyesi() { Ad = "Kisi 3" });
            AddTodo(new toDo()
            {
                Baslik = "Baslik 1",
                AtananKisi = KisiList[0],
                Icerik = "icerik 1",
                Board = Board.TODO,
                Buyukluk = Buyukluk.M
            });
            AddTodo(new toDo()
            {
                Baslik = "Baslik 2",
                AtananKisi = KisiList[1],
                Icerik = "icerik 2",
                Board = Board.TODO,
                Buyukluk = Buyukluk.XS
            });
            AddTodo(new toDo()
            {
                Baslik = "Baslik 3",
                AtananKisi = KisiList[2],
                Icerik = "icerik 3",
                Board = Board.IN_PROGRESS,
                Buyukluk = Buyukluk.L
            });
            AddTodo(new toDo()
            {
                Baslik = "Baslik 4",
                AtananKisi = KisiList[2],
                Icerik = "icerik 4",
                Board = Board.IN_PROGRESS,
                Buyukluk = Buyukluk.XL
            });
        }
        public void AddTodo(toDo toDo)
        {
            toDoList.Add(toDo);
        }
    }

}

    public class TakimUyesi
    {
        public static int sayac = 0;
        public int Id
        {
            get { return sayac; }
            private set { sayac = value; }
        }
        public string Ad { get; set; }
        public TakimUyesi()
        {
            sayac += 1;
            Id = sayac;
        }
    }

    public enum Buyukluk
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
    public enum Board
    {
        TODO,
        IN_PROGRESS,
        DONE
    }

