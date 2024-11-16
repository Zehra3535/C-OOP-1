using System;


namespace C__OOP_1
{
    public class Ogrenci
    {
        public int age;
        public string name;

        public int sinif;
        public int id;
        public void print()
        {
            Console.WriteLine("Name:{0} \t Age:{1}", name,age);
        }

        public void EnterData(int s,int i)
        { 
            sinif=s;
            id = i;
            Console.WriteLine("Sınıf:{0} \t Id:{1}",sinif,id);
        }

        public void Method3(int sinif,int id)
        {
            this.sinif = sinif;
            this.id = id;

            Console.WriteLine("Sinif:{0} \t id:{1}", sinif, id);
        }

    }

}
