namespace ForumSystem.Web.ViewModels.Home
{
    using ForumSystem.Data.Models;
    using ForumSystem.Web.Infrastructure.Mapping;
using System.Collections.Generic;

    public class IndexBlogPostViewModel : IMapFrom<Post>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<Tag> Tags { get; set; }
    }
}