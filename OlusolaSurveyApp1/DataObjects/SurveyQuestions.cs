using Microsoft.Azure.Mobile.Server;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlusolaSurveyApp1.DataObjects
{

      
    [Table("questions")]
    public class SurveyQuestions : EntityData
    {
        public string Text { get; set; }
        public string Answers { get; set; }
    }
}