using System.Linq;
using System.Web.Http;
using System.Web.Http.Controllers;
using Microsoft.Azure.Mobile.Server;
using OlusolaSurveyApp1.DataObjects;
using OlusolaSurveyApp1.Models;

namespace OlusolaSurveyApp1.Controllers
{
    public class QuestionsController : TableController<SurveyQuestions>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<SurveyQuestions>(context, Request);
        }

        // GET tables/Questions
        public IQueryable<SurveyQuestions> GetAllSurveyQuestion()
        {
            return Query();
        }

        // GET tables/Questions/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<SurveyQuestions> GetSurveyQuestion(string id)
        {
            return Lookup(id);
        }
    }
}
