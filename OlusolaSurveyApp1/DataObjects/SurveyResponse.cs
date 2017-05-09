using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Azure.Mobile.Server;
using Newtonsoft.Json;

namespace OlusolaSurveyApp1.DataObjects
{
    [Table("responses")]
    public class SurveyResponse : EntityData
    {
        [JsonProperty("questionId")]
        public string QuestionId { get; set; }

        public string Name { get; set; }
        [JsonProperty("answer")]
        public int AnswerIndex { get; set; }
    }
}