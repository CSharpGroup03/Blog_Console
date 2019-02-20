using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork
{
    public class CommentManager
    {
        private Dictionary<string, BaseComment> _baseComment = new Dictionary<string, BaseComment>();

        public BaseComment this[string key] {

            get { return _baseComment[key]; }
            set { _baseComment.Add(key, value); }
        }

    }
}
