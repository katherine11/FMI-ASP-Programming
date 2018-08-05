using System.Xml.Serialization;

namespace SampleTestProject.Models
{
    [XmlRoot("Sample")]
    public class Sample
    {
        //xml serializes only public fields:
        [XmlAttribute(AttributeName = "sampleId")]
        public int id { get; set; }
        [XmlElement(ElementName = "sampleName")]
        public string name { get; set; }
        [XmlElement(ElementName = "sampleAge")]
        public int age { get; set; }
        [XmlElement(ElementName = "sampleGender")]
        public string gender { get; set; }
        [XmlElement(ElementName = "sampleAddress")]
        public string address { get; set; }

        public Sample()
        {
            
        }

        public Sample(int id, string name, int age, string gender, string address)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
        }
    }
}