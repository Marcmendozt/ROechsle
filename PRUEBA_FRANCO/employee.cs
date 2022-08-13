using System.ComponentModel.DataAnnotations.Schema;

namespace PRUEBA_FRANCO
{
    public class employee
    {
       
        public int id { get; set; }

     
        public string name { get; set; }

        public string document_number { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal salary { get; set; }
        public int age { get; set; }
        public string profile { get; set; }
        public string email { get; set; }
        public string address { get; set; }
    }
}
