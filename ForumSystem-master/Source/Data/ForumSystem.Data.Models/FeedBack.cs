namespace ForumSystem.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class FeedBack
    {
        public FeedBack()
        {
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        public string Title { get; set; }

        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        [Display(Name = "Content")]
        public string Content { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}
