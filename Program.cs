using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Dog));
        using (FileStream fileStream = new FileStream("User_Atr.xml", FileMode.OpenOrCreate))
        {
            Dog dog = serializer.Deserialize(fileStream) as Dog;
            Console.WriteLine(dog.name + dog.age);
        }

    }
}

public class Dog
{
    [XmlAttribute]
    public string name;
    [XmlAttribute]
    public int age;

    public Dog(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public Dog()
    {

    }
}