namespace ForumSystem.Web.Controllers
{
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;

    using ForumSystem.Data.Common.Repository;
    using ForumSystem.Data.Models;
    using ForumSystem.Web.ViewModels.Home;

    public class HomeController : Controller
    {
        private readonly IDeletableEntityRepository<Post> posts;

        public HomeController(IDeletableEntityRepository<Post> posts)
        {
            this.posts = posts;
        }

        public ActionResult Index(string message)
        {
            var model = this.posts.All().Project().To<IndexBlogPostViewModel>();
            ViewBag.Message = message;
            return this.View(model);
        }
 

        public ActionResult Details(int Id)
        {
            var details = this.posts.GetById(Id);

            return this.View(details);
        }
    }
}