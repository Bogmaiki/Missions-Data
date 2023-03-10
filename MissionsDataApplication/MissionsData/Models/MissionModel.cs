using System.ComponentModel.DataAnnotations;

namespace MissionsData.Models
{
    public class MissionModel
    {
        public int RecordKey { get; set; }
        [Required(ErrorMessage ="יש לשלוח שדה עבור משימה")]
        [MinLength(5, ErrorMessage ="שם משימה צריך להכיל 5 תווים לפחות")]
        public string MissionName { get; set; }

        //public MissionModel(int id, string name)
       // {
        //    this.RecordKey = id;
       //     this.MissionName = name;
       // }
    }
}
