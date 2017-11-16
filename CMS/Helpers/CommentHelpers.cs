using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telerik.Sitefinity.Services;
using Telerik.Sitefinity.Services.Comments;
using Telerik.Sitefinity.Web.UI;

namespace SitefinityWebApp.Helpers
{
	public static class CommentHelpers
	{
		public static IEnumerable<IComment> GetCommentsBySpecificBlogPost(Guid blogPostId)
		{
			//gets an instance of the comments service
			var cs = SystemManager.GetCommentsService();

			//adds an instance to the comment filter
			var filter = new CommentFilter();

			//gets the thread related to the blog post
			var language = Thread.CurrentThread.CurrentUICulture.Name;
			var threadKey = ControlUtilities.GetLocalizedKey(blogPostId, language);

			//adds the thread key to the comments filter
			filter.ThreadKey.Add(threadKey);

			//retrieves all comments by specific blog post
			var comments = cs.GetComments(filter);

			return comments;
		}

		public static int GetBlogPostCommentCount(Guid blogPostId)
		{
			if (blogPostId != null)
				return GetCommentsBySpecificBlogPost(blogPostId).Count();
			else
				return 0;
		}
	}
}
