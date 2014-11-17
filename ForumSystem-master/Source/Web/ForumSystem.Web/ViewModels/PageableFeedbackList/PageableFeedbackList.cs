namespace ForumSystem.Web.ViewModels.Home
{
    using ForumSystem.Data.Models;
    using ForumSystem.Web.Infrastructure.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class PageableFeedbackList : IMapFrom<FeedBack>
    {
        public PageableFeedbackList()
        { }
        public int Id { get; set; }

        public string Title { get; set; }

        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }
        
        [Display(Name = "Content")]
        public string Content { get; set; }
        public DateTime? CreatedOn { get; set; }

       
    }
}