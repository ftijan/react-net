using System.Collections.Generic;

namespace Example.React.App.Models
{
    public class IndexViewModel
    {
        public IReadOnlyList<CommentModel> Comments { get; set; }
        public int CommentsPerPage { get; set; }
        public int Page { get; set; }
    }
}
